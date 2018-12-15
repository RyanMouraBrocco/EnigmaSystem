using EnigmaClass;
using EnigmaClass.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaSystem
{
    public partial class Form_Exercicios : Form
    {
        Conteudo conteudo = new Conteudo();
        Exercicio Gabarito = new Exercicio();
        Exercicio Resolvido = new Exercicio();
        int[] sequencia = new int[0];
        int[] sequenciaalternativa = new int[0];
        int QuestaoAtual = 0;
        TextBox[] textBoxes = new TextBox[0];
        bool[] respostas = new bool[0];
        bool processar = true;
        bool enviar = false;
        bool realizando = false;
        public Form_Exercicios(Conteudo conteudo)
        {
            InitializeComponent();
            this.conteudo = conteudo;
            ExercicioDAL dal = new ExercicioDAL();
            try
            { 
                conteudo.Exercicio = dal.ConsultarTodos(conteudo.ID);
            }
            catch
            {
                this.Close();
            }
            Color cor = ColorTranslator.FromHtml("#000449");
            Grid_Exercicios.RowTemplate.DefaultCellStyle.BackColor = cor;
            Grid_Exercicios.RowTemplate.DefaultCellStyle.SelectionBackColor = cor;
            Btn_Proximo.BackColor = cor;
            CarregarGrid();
            if (Grid_Exercicios.RowCount>0)
            {
                foreach (var item in conteudo.Exercicio.Where(x => x.ID == Convert.ToInt32(Grid_Exercicios.Rows[0].Cells[1].Value)))
                {
                    try
                    {
                        Lbl_Respostas.Visible = true;
                        Btn_Proximo.Visible = true;
                        LimparCampos();
                        Gabarito = dal.Consultar(item.ID);
                        Resolvido = dal.Consultar(item.ID);
                        Resolvido.Questao.Clear();
                        CarregarSequencia();
                        MostrarQuestao();
                        realizando = true;
                    }
                    catch 
                    {
                        this.Close();
                    }
                    
                }
            }
        }
        void CarregarGrid()
        {
            Grid_Exercicios.Rows.Clear();
            int linha = 0;
            foreach (var item in conteudo.Exercicio)
            {
                Grid_Exercicios.Rows.Add();
                Grid_Exercicios.Rows[linha].Cells[0].Value = item.Descricao;
                Grid_Exercicios.Rows[linha].Cells[1].Value = item.ID;
                linha += 1;
            }
        }

        private void Form_Exercicios_Load(object sender, EventArgs e)
        {
        }

        void MostrarQuestao()
        {
            foreach (var item in Gabarito.Questao.Where(x=>x.Ordem == sequencia[QuestaoAtual]))
            {
                Panel_Pergunta.Controls.Clear();
                Point pontopergunta = new Point(16,21);
                Label lbl_pergunta = new Label();
                lbl_pergunta.Font = new Font("Arial", 14);
                lbl_pergunta.AutoSize = true;
                lbl_pergunta.MaximumSize = new Size(800,1000000);
                lbl_pergunta.Location = pontopergunta;
                lbl_pergunta.Text = item.Pergunta;
                lbl_pergunta.MouseEnter += (object sender, EventArgs e) =>
                {
                    Program.PanelMaterias.Visible = false;
                    Program.PanelUsuario.Visible = false;
                };
                Panel_Pergunta.Controls.Add(lbl_pergunta);
                foreach (var i in item.Imagem)
                {
                    PictureBox pb = new PictureBox();
                    pb.Width = 393;
                    pb.Height = 179;
                    MemoryStream ms = new MemoryStream(i._Imagem);
                    Image img = Image.FromStream(ms);
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.Image = img;
                    pb.Location = new Point(206,lbl_pergunta.Location.Y + lbl_pergunta.Height);
                    pb.MouseEnter += (object sender, EventArgs e) =>
                    {
                        Program.PanelMaterias.Visible = false;
                        Program.PanelUsuario.Visible = false;
                    };
                    Panel_Pergunta.Controls.Add(pb);
                }
                sequenciaalternativa = new int[item.Alternativa.Count];
                if (item.AleatorioAlternativa)
                {
                    Random rd = new Random();
                    List<int> numeros = new List<int>();
                    int numero = 0;
                    for (int i = 0; i < item.Alternativa.Count; i++)
                    {
                        numero = rd.Next(1, item.Alternativa.Count + 1);
                        while (numeros.Contains(numero))
                        {
                            if (numeros.Count >= item.Alternativa.Count)
                            {
                                break;
                            }
                            else
                            {
                                numero = rd.Next(1, item.Alternativa.Count + 1);
                            }

                        }
                        numeros.Add(numero);
                    }
                    int index = 0;
                    foreach (var i in numeros)
                    {
                        sequenciaalternativa[index] = i;
                        index += 1;
                    }
                }
                else
                {
                    int index = 0;
                    foreach (var it in item.Alternativa.OrderBy(x=>x.Ordem))
                    {
                        sequenciaalternativa[index] = it.Ordem;
                        index += 1;
                    }
                }
                Panel_Respostas.Controls.Clear();
                Point ponto = new Point(20, 20);
                int quantidade = 1;
                int indice = 0;
                if (item.Tipo == "C")
                {
                    textBoxes = new TextBox[item.Alternativa.Count];
                }
                else
                {
                    respostas = new bool[item.Alternativa.Count];
                }
                int alternativaatual = 0;
                while (alternativaatual < item.Alternativa.Count)
                {
                    foreach (var it in item.Alternativa.Where(x => x.Ordem == sequenciaalternativa[alternativaatual]))
                    {
                        if (item.Tipo == "C")
                        {
                            TextBox tx = new TextBox();
                            tx.Font = new Font("Arial", 10);
                            tx.Width = 250;
                            tx.Location = ponto;
                            ponto.Y += tx.Height + 10;
                            tx.MouseEnter += (object sender, EventArgs e) =>
                            {
                                Program.PanelMaterias.Visible = false;
                                Program.PanelUsuario.Visible = false;
                            };
                            Panel_Respostas.Controls.Add(tx);
                            textBoxes[indice] = tx;
                        }
                        else
                        {
                            RadioButton rb = new RadioButton();
                            rb.Text = quantidade + "- " + it.Conteudo;
                            rb.AutoSize = true;
                            rb.Location = ponto;
                            ponto.Y += rb.Height;
                            rb.MouseEnter += (object sender, EventArgs e) =>
                            {
                                Program.PanelMaterias.Visible = false;
                                Program.PanelUsuario.Visible = false;
                            };
                            rb.CheckedChanged += (object sender, EventArgs e) =>
                            {
                                RadioButton este = sender as RadioButton;
                                if (este.Checked == true)
                                {
                                    for (int i = 0; i < respostas.Length; i++)
                                    {
                                        respostas[i] = false;
                                    }
                                    int posicao = Convert.ToInt32(este.Text.Trim().Substring(0, este.Text.IndexOf("-", StringComparison.Ordinal))) - 1;
                                    respostas[posicao] = true;
                                }
                            };
                            Panel_Respostas.Controls.Add(rb);
                            respostas[indice] = false;
                        }
                        quantidade += 1;
                        indice += 1;
                    }
                    alternativaatual += 1;
                }
            }
        }

        void CarregarSequencia()
        {
            sequencia = new int[Gabarito.Questao.Count];
            if (Gabarito.AleatorioQuestao)
            {
                Random rd = new Random();
                List<int> numeros = new List<int>();
                int numero = 0;
                for (int i = 0; i < Gabarito.Questao.Count; i++)
                { 
                    numero = rd.Next(1, Gabarito.Questao.Count +1);
                    while (numeros.Contains(numero))
                    {
                        if (numeros.Count >= Gabarito.Questao.Count )
                        {
                            break;
                        }
                        else
                        {
                            numero = rd.Next(1, Gabarito.Questao.Count + 1);
                        }

                    }
                    numeros.Add(numero);
                }
                int index = 0;
                foreach (var item in numeros)
                {
                    sequencia[index] = item;
                    index += 1;
                }
            }
            else
            {
                int index = 0;
                foreach (var item in Gabarito.Questao.OrderBy(x=>x.Ordem))
                {
                    sequencia[index] = item.Ordem;
                    index += 1;
                }
            }
        }

        private void Grid_Exercicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid_Exercicios.RowCount>0)
            {
                foreach (var item in conteudo.Exercicio.Where(x=>x.ID == Convert.ToInt32(Grid_Exercicios.CurrentRow.Cells[1].Value)))
                {
                    try
                    {
                        Program.PanelCarregando.Visible = true;
                        Program.PanelCarregando.Refresh();
                        Lbl_Respostas.Visible = true;
                        Btn_Proximo.Visible = true;
                        ExercicioDAL dal = new ExercicioDAL();
                        LimparCampos();
                        Gabarito = dal.Consultar(item.ID);
                        Resolvido = dal.Consultar(item.ID);
                        Resolvido.Questao.Clear();
                        CarregarSequencia();
                        MostrarQuestao();
                        realizando = true;
                        Program.PanelCarregando.Visible = false;
                    }
                    catch 
                    {
                        MessageBox.Show("Erro de Conexão, tente novamente", "Enigma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Program.PanelCarregando.Visible = false;
                    }
                    
                }
            }
        }

        void Proximo()
        {
            if (realizando)
            {
                if (enviar == false)
                {
                    Questao questao = new Questao();
                    questao.Alternativa = new List<Alternativa>();
                    foreach (var item in Gabarito.Questao.Where(x => x.Ordem == sequencia[QuestaoAtual]))
                    {
                        questao.ID = item.ID;
                        questao.Ordem = item.Ordem;
                        questao.Tipo = item.Tipo;
                        questao.Pergunta = item.Pergunta;
                        questao.Usuario = UsuarioAtual.ID;
                        questao.AleatorioAlternativa = item.AleatorioAlternativa;
                        questao.Exercicio = item.Exercicio;
                    }
                    if (questao.Tipo.Trim() == "C")
                    {
                        bool validar = true;
                        for (int i = 0; i < textBoxes.Length; i++)
                        {
                            if (textBoxes[i].Text.Trim() == "")
                            {
                                validar = false;
                            }
                        }
                        if (validar)
                        {
                            int ordem = 1;
                            for (int i = 0; i < textBoxes.Length; i++)
                            {
                                Alternativa alternativa = new Alternativa
                                {
                                    Conteudo = textBoxes[i].Text.Trim(),
                                    Ordem = ordem,
                                    Questao = questao,
                                    Tipo = "R",
                                    Usuario = UsuarioAtual.ID
                                };
                                questao.Alternativa.Add(alternativa);
                                ordem += 1;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Preencha todos os campos", "Enigma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            processar = false;
                        }
                    }
                    else
                    {
                        bool validar = false;
                        int resposta = 0;
                        for (int i = 0; i < respostas.Length; i++)
                        {
                            if (respostas[i] == true)
                            {
                                validar = true;
                                resposta = i;
                            }
                        }
                        if (validar)
                        {
                            Alternativa alternativa = new Alternativa();
                            foreach (var item in Gabarito.Questao.Where(x => x.Ordem == sequencia[QuestaoAtual]))
                            {
                                foreach (var it in item.Alternativa.Where(x => x.Ordem == sequenciaalternativa[resposta]))
                                {
                                    alternativa = new Alternativa
                                    {
                                        Conteudo = it.Conteudo,
                                        Ordem = it.Ordem,
                                        Questao = it.Questao,
                                        Tipo = "R",
                                        Usuario = UsuarioAtual.ID
                                    };
                                }
                            }
                            questao.Alternativa.Add(alternativa);
                        }
                        else
                        {
                            MessageBox.Show("Selecione uma alternativa", "Enigma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            processar = false;
                        }
                    }
                    if (processar)
                    {
                        Resolvido.Questao.Add(questao);
                        if (QuestaoAtual + 1 == Gabarito.Questao.Count)
                        {
                            enviar = true;
                        }
                        else
                        {
                            QuestaoAtual += 1;
                            MostrarQuestao();
                        }
                    }
                }
                if (enviar)
                {
                    try
                    {
                        Program.PanelCarregando.Visible = true;
                        Program.PanelCarregando.Refresh();
                        ExercicioDAL dal = new ExercicioDAL();
                        NotaDAL dalnota = new NotaDAL();
                        Nota n = new Nota();
                        n = dal.Corrigir(Resolvido, Gabarito);
                        dalnota.Inserir(n);
                        DesempenhoDAL daldesempenho = new DesempenhoDAL();
                        ConteudoDAL dalconteudo = new ConteudoDAL();
                        Gabarito.Conteudo = dalconteudo.Consultar(Gabarito.Conteudo.ID);
                        Desempenho desempenho = daldesempenho.Consultar(Gabarito.Conteudo.Materia.ID, Resolvido.Usuario);
                        if (desempenho.ID == 0)
                        {
                            desempenho = new Desempenho
                            {
                                HorasEstudadas = 0,
                                Materia = Gabarito.Conteudo.Materia,
                                Porcentagem = 0,
                                Usuario = new Usuario { ID = Resolvido.Usuario }
                            };
                            daldesempenho.Inserir(desempenho);
                        }
                        else
                        {
                            daldesempenho.Alterar(desempenho);
                        }
                        Form frm = new Form_ExibirNota(dalnota.ConsultarUltimo(UsuarioAtual.ID, Gabarito.ID));
                        frm.ShowDialog();
                        LimparCampos();
                    }
                    catch 
                    {
                        MessageBox.Show("Erro de Conexão, tente novamente", "Enigma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Program.PanelCarregando.Visible = false;
                }
                processar = true;
            }
        }

        void LimparCampos()
        {
            Panel_Pergunta.Controls.Clear();
            Panel_Respostas.Controls.Clear();
            enviar = false;
            sequencia = new int[0];
            sequenciaalternativa = new int[0];
            textBoxes = new TextBox[0];
            respostas = new bool[0];
            QuestaoAtual = 0;
            Gabarito = new Exercicio();
            Resolvido = new Exercicio();
            realizando = false;
        }

        private void Form_Exercicios_MouseEnter(object sender, EventArgs e)
        {
            Program.PanelMaterias.Visible = false;
            Program.PanelUsuario.Visible = false;
        }

        private void Grid_Exercicios_MouseEnter(object sender, EventArgs e)
        {
            Program.PanelMaterias.Visible = false;
            Program.PanelUsuario.Visible = false;
        }

        private void Btn_Proximo_Click(object sender, EventArgs e)
        {
            Proximo();
        }

        private void Btn_Proximo_MouseEnter(object sender, EventArgs e)
        {
            Color cor = ColorTranslator.FromHtml("#00058d");
            Btn_Proximo.BackColor = cor;
        }

        private void Btn_Proximo_MouseLeave(object sender, EventArgs e)
        {
            Color cor = ColorTranslator.FromHtml("#000449");
            Btn_Proximo.BackColor = cor;
        }
    }
}
