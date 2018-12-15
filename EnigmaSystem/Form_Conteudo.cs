using EnigmaClass;
using EnigmaClass.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaSystem
{
    public partial class Form_Conteudo : Form
    {

        Materia materia = new Materia();
        List<Resumo> Resumos = new List<Resumo>();
        Conteudo conteudo = new Conteudo();
        string[] links = new string[0];
        DateTime Agora;
        public Form_Conteudo(Materia materia)
        {
            InitializeComponent();
            this.materia = materia;
            Color cor = ColorTranslator.FromHtml("#000449");
            Grid_Conteudo.RowTemplate.DefaultCellStyle.BackColor = cor;
            Grid_Conteudo.RowTemplate.DefaultCellStyle.SelectionBackColor = cor;
            Grid_Resumos.RowTemplate.DefaultCellStyle.BackColor = cor;
            Grid_Resumos.RowTemplate.DefaultCellStyle.SelectionBackColor = cor;
            CarregarConteudos();
            if (Grid_Conteudo.RowCount>0)
            {
                foreach (var item in materia.Conteudo.Where(x => x.ID == Convert.ToInt32(Grid_Conteudo.Rows[0].Cells[1].Value)))
                {
                    Btn_Exercicios.Visible = true;
                    this.conteudo = new Conteudo();
                    try
                    {
                        ConteudoDAL dal = new ConteudoDAL();
                        this.conteudo = dal.Consultar(item.ID);
                    }
                    catch 
                    {
                        this.Close();
                    }
                    CarregarView();
                    this.Resumos = conteudo.Resumo;
                    CarregarResumos();
                }
            }
        }
        void CarregarConteudos()
        {
            Grid_Conteudo.Rows.Clear();
            int linha = 0;
            foreach (var item in materia.Conteudo)
            {
                Grid_Conteudo.Rows.Add();
                Grid_Conteudo.Rows[linha].Cells[0].Value = item.Nome;
                Grid_Conteudo.Rows[linha].Cells[1].Value = item.ID;
                linha += 1;
            }
        }

        private void Form_Conteudo_MouseEnter(object sender, EventArgs e)
        {
            Program.PanelMaterias.Visible = false;
            Program.PanelUsuario.Visible = false;
        }

        private void Form_Conteudo_Load(object sender, EventArgs e)
        {
            Color cor = ColorTranslator.FromHtml("#000449");
            Btn_Exercicios.BackColor = cor;
             Agora = DateTime.Now;
        }
        void CarregarView()
        {
            Panel_View.Controls.Clear();
            Point ponto = new Point(16,17);
            links = new string[conteudo.ConteudoTexto.Count];
            int index = 0;
            foreach (var item in conteudo.ConteudoTexto.OrderBy(x=>x.Ordem))
            {
                Btn_Exercicios.Visible = true;
                if (item.Texto!=null)
                {
                    Label label = new Label();
                    label.Location = ponto;
                    label.ForeColor = ColorTranslator.FromHtml(item.Texto.Cor);
                    label.MaximumSize = new Size(Panel_View.Width-57, 300000);
                    label.AutoSize = true;
                    label.Text = item.Texto.Conteudo;
                    if (item.Texto.Negrito)
                    {
                        label.Font = new Font("Arial", (float)item.Texto.Tamanho,FontStyle.Bold);
                    }
                    else
                    {
                        if (item.Texto.Italico)
                        {
                            label.Font = new Font("Arial", (float)item.Texto.Tamanho, FontStyle.Italic);
                        }
                        else
                        {
                            label.Font = new Font("Arial", (float)item.Texto.Tamanho);
                        }

                    }
                    label.MouseEnter+=(object sender, EventArgs e)=>
                    {
                        Program.PanelMaterias.Visible = false;
                        Program.PanelUsuario.Visible = false;
                    };
                    Panel_View.Controls.Add(label);
                    ponto.Y += label.Size.Height;
                }
                if (item.Imagem!=null)
                {
                    MemoryStream ms = new MemoryStream(item.Imagem._Imagem);
                    Image img = Image.FromStream(ms);
                    PictureBox pb = new PictureBox();
                    pb.Image = img;
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.Height = 400;
                    pb.Width = Panel_View.Width-50;
                    pb.Location = ponto;
                    pb.MouseEnter += (object sender, EventArgs e) =>
                    {
                        Program.PanelMaterias.Visible = false;
                        Program.PanelUsuario.Visible = false;
                    };
                    Panel_View.Controls.Add(pb);
                    ponto.Y += pb.Height;
                }
                if (item.Video!=null)
                {
                    LinkLabel ll = new LinkLabel
                    {
                        Text = item.Video.Nome +"(Clique aqui para assitir o video)",
                        Font = new Font("Arial", 14),
                        Location = ponto,
                        AutoSize = true,
                        Name = "ll"+index
                    };
                    links[index] = item.Video.Link;
                    ll.Click += (object sender, EventArgs e) =>
                    {
                        LinkLabel este = sender as LinkLabel;
                        System.Diagnostics.Process pStart = new System.Diagnostics.Process();
                        pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(links[Convert.ToInt32(este.Name.Replace("ll",""))]);
                        pStart.Start();
                    };
                    index += 1;
                    ponto.Y += ll.Size.Height;
                    Panel_View.Controls.Add(ll);
                }
            }
        }

        void CarregarResumos()
        {
            Grid_Resumos.Rows.Clear();
            int linha = 0;
            foreach (var item in Resumos)
            {
                Grid_Resumos.Rows.Add();
                Grid_Resumos.Rows[linha].Cells[0].Value = item.NomeArquivo;
                Grid_Resumos.Rows[linha].Cells[1].Value = item.ID;
                linha += 1;
            }
        }

        private void Grid_Conteudo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (var item in materia.Conteudo.Where(x=>x.ID == Convert.ToInt32(Grid_Conteudo.CurrentRow.Cells[1].Value)))
            {
                try
                {
                    Program.PanelCarregando.Visible = true;
                    Program.PanelCarregando.Refresh();
                    Btn_Exercicios.Visible = true;
                    this.conteudo = new Conteudo();
                    ConteudoDAL dal = new ConteudoDAL();
                    this.conteudo = dal.Consultar(item.ID);
                    CarregarView();
                    this.Resumos = conteudo.Resumo;
                    CarregarResumos();
                    Program.PanelCarregando.Visible = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro de Conexão, tente novamente","Enigma",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Program.PanelCarregando.Visible = false;
                }
                
            }
        }

        private void Grid_Conteudo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Grid_Conteudo_MouseEnter(object sender, EventArgs e)
        {
            Program.PanelMaterias.Visible = false;
            Program.PanelUsuario.Visible = false;
        }

        private void Panel_View_MouseEnter(object sender, EventArgs e)
        {
            Program.PanelMaterias.Visible = false;
            Program.PanelUsuario.Visible = false;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Program.PanelMaterias.Visible = false;
            Program.PanelUsuario.Visible = false;
        }


        private void Btn_Exercicios_Click(object sender, EventArgs e)
        {
            try
            {
                Program.PanelCarregando.Visible = true;
                Program.PanelCarregando.Refresh();
                Form frm = new Form_Exercicios(conteudo);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                Program.PanelCarregando.Visible = false;
            }
            catch 
            {
                MessageBox.Show("Erro de Conexão, tente novamente", "Enigma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.PanelCarregando.Visible = false;
            }
            
        }

        private void Btn_Exercicios_MouseLeave(object sender, EventArgs e)
        {
            Color cor = ColorTranslator.FromHtml("#000449");
            Btn_Exercicios.BackColor = cor;
        }

        private void Btn_Exercicios_MouseEnter(object sender, EventArgs e)
        {
            Color cor = ColorTranslator.FromHtml("#00058d");
            Btn_Exercicios.BackColor = cor;
        }

        private void Grid_Resumos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid_Resumos.RowCount > 0)
            {
                foreach (var item in Resumos.Where(x => x.ID == Convert.ToInt32(Grid_Resumos.CurrentRow.Cells[1].Value)))
                {
                    try
                    {
                        Program.PanelCarregando.Visible = true;
                        var nome = Path.GetFileName(item.NomeArquivo + item.Extensao);
                        File.WriteAllBytes(nome, item.Arquivo);
                        Process.Start(nome);
                        Program.PanelCarregando.Visible = false;
                    }
                    catch
                    {
                        MessageBox.Show("Algo de errado com o arquivo, tente novamente mais tarde","Enigma",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void Form_Conteudo_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                TimeSpan timeSpan = DateTime.Now - Agora;
                decimal horas = (decimal)timeSpan.Hours;
                decimal minutos = 0;
                if (timeSpan.Minutes > 0)
                {
                    minutos = (decimal)timeSpan.Minutes / (decimal)60;
                }
                if (timeSpan.Days > 0)
                {
                    horas += 24 * timeSpan.Days;
                }
                DesempenhoDAL dal = new DesempenhoDAL();
                Desempenho D = new Desempenho();
                decimal hestudadas = horas + minutos;
                D = dal.Consultar(this.materia.ID, UsuarioAtual.ID);
                if (D.ID == 0)
                {
                    D.Materia = this.materia;
                    D.Usuario = new Usuario { ID = UsuarioAtual.ID };
                    D.HorasEstudadas = hestudadas;
                    dal.Inserir(D);
                }
                else
                {
                    D.HorasEstudadas += hestudadas;
                    dal.Alterar(D);
                }

            }
            catch 
            {
            }
        }
    }
}
