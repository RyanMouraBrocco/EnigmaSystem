using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnigmaClass.CRUD;
using EnigmaClass;

namespace EnigmaSystem
{
    public partial class Form_MinhasPerguntasRespostas : Form
    {
        List<Pergunta> perguntas = new List<Pergunta>();
        List<Resposta> respostas = new List<Resposta>();
        bool alterarpergunta = true;
         public Form_MinhasPerguntasRespostas()
        {
            InitializeComponent();
        }

        private void Form_MinhasPerguntasRespostas_Load(object sender, EventArgs e)
        {
            Color cor = ColorTranslator.FromHtml("#000449");
            Panel_Superior.BackColor = cor;
            Grid_Perguntas.RowTemplate.DefaultCellStyle.BackColor = cor;
            Grid_Perguntas.RowTemplate.DefaultCellStyle.SelectionBackColor = cor;
            Grid_Respostas.RowTemplate.DefaultCellStyle.BackColor = cor;
            Grid_Respostas.RowTemplate.DefaultCellStyle.SelectionBackColor = cor;
            Grid_Perguntas.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            Grid_Perguntas.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            Grid_Respostas.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            Grid_Respostas.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            try
            {
                CarregarPerguntas();
                CarregarRespostas();
            }
            catch
            {
                this.Close();
            }
            
        }

        void CarregarRespostas()
        {
            RespostaDAL dal = new RespostaDAL();
            respostas = dal.ConsultarPorUsuario(UsuarioAtual.ID);
            int linha = 0;
            foreach (var item in respostas)
            {
                Grid_Respostas.Rows.Add();
                Grid_Respostas.Rows[linha].Cells[0].Value = item.Titulo;
                Grid_Respostas.Rows[linha].Cells[1].Value = item.ID;
                linha += 1;
            }
        }
        void CarregarPerguntas()
        {
            PerguntaDAL dal = new PerguntaDAL();
            perguntas = dal.ConsultarPorUsuario(UsuarioAtual.ID);
            int linha = 0;
            foreach (var item in perguntas)
            {
                Grid_Perguntas.Rows.Add();
                Grid_Perguntas.Rows[linha].Cells[0].Value = item.Titulo;
                Grid_Perguntas.Rows[linha].Cells[1].Value = item.ID;
                linha += 1;  
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        Point Ponto = new Point();
        int x, y;

        private void Panel_Superior_MouseDown_1(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void Panel_Superior_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Ponto = MousePosition;
                Ponto.X -= x;
                Ponto.Y -= y;
                this.Location = Ponto;
                Application.DoEvents();
            }
        }

        private void Grid_Perguntas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid_Perguntas.Rows.Count>0)
            {
                foreach (var item in perguntas.Where(x=>x.ID == Convert.ToInt32(Grid_Perguntas.CurrentRow.Cells[1].Value)))
                {
                    Form frm = new Form_Load();
                    try
                    {
                        frm.Show();
                        frm.Refresh();
                        alterarpergunta = true;
                        Lbl_PerguntaResposta.Text = item.Titulo;
                        CB_Visivel.Visible = true;
                        AvaliacaoDAL dal = new AvaliacaoDAL();
                        Lbl_Likes.Text = dal.AvaliacaoPossitiva(item.ID, 0).ToString();
                        Lbl_Numeros_Dislikes.Text = dal.AvaliacaoNegativa(item.ID, 0).ToString();
                        Lbl_Numeros_Denucias.Text = dal.Denuncias(item.ID, 0).ToString();
                        CB_Visivel.Checked = item.Visibilidade;
                        frm.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Erro de Conexão, tente novamente", "Enigma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        frm.Close();
                    }
                    
                }
            }
        }

        private void Grid_Respostas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid_Respostas.Rows.Count > 0)
            {
                foreach (var item in respostas.Where(x => x.ID == Convert.ToInt32(Grid_Respostas.CurrentRow.Cells[1].Value)))
                {
                    Form frm = new Form_Load();
                    try
                    {
                        frm.Show();
                        frm.Refresh();
                        alterarpergunta = false;
                        Lbl_PerguntaResposta.Text = item.Titulo;
                        CB_Visivel.Visible = true;
                        AvaliacaoDAL dal = new AvaliacaoDAL();
                        Lbl_Likes.Text = dal.AvaliacaoPossitiva(0, item.ID).ToString();
                        Lbl_Numeros_Dislikes.Text = dal.AvaliacaoNegativa(0, item.ID).ToString();
                        Lbl_Numeros_Denucias.Text = dal.Denuncias(0, item.ID).ToString();
                        CB_Visivel.Checked = item.Visibilidade;
                        frm.Close();
                    }
                    catch 
                    {
                        MessageBox.Show("Erro de Conexão, tente novamente", "Enigma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        frm.Close();
                    }
                }
            }
        }

        private void CB_Visivel_CheckedChanged(object sender, EventArgs e)
        {
            if (alterarpergunta)
            {
                foreach (var item in perguntas.Where(x=>x.ID == Convert.ToInt32(Grid_Perguntas.CurrentRow.Cells[1].Value)))
                {
                    try
                    {
                        PerguntaDAL dal = new PerguntaDAL();
                        if (CB_Visivel.Checked)
                        {
                            item.Visibilidade = true;
                        }
                        else
                        {
                            item.Visibilidade = false;
                        }
                        dal.Alterar(item);
                    }
                    catch 
                    {
                        MessageBox.Show("Erro de Conexão, tente novamente", "Enigma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                foreach (var item in respostas.Where(x => x.ID == Convert.ToInt32(Grid_Respostas.CurrentRow.Cells[1].Value)))
                {
                    try
                    {
                        RespostaDAL dal = new RespostaDAL();
                        if (CB_Visivel.Checked)
                        {
                            item.Visibilidade = true;
                        }
                        else
                        {
                            item.Visibilidade = false;
                        }
                        dal.Alterar(item);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro de Conexão, tente novamente", "Enigma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Pb_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
