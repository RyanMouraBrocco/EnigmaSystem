using EnigmaClass;
using EnigmaClass.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaSystem
{
    public partial class Form_Menu : Form
    {
        List<Materia> materias = new List<Materia>();
        Form Home = new Form_Home();
        public Form_Menu()
        {
            InitializeComponent();
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient)
                {
                    MdiClient ctlMDI = (MdiClient)ctl;
                    ctlMDI.BackColor = Color.White;
                    break;
                }
            }
        }

        void LimparForms()
        {
            for (int i = 0; i <  Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i]!= this && Application.OpenForms[i]!=Program.Login && Application.OpenForms[i] != Home)
                {
                    Application.OpenForms[i].Close();
                }
            }
        }
        private void Form_Menu_Load(object sender, EventArgs e)
        {
            Color corcima = ColorTranslator.FromHtml("#000449");
            Color cor = ColorTranslator.FromHtml("#00058d");
            Panel_Superior.BackColor = cor;
            Panel_Usuario.BackColor = cor;
            Panel_Materias.BackColor = cor;
            Panel_SuperiorCarregando.BackColor = corcima;
            Grid_Materias.RowTemplate.DefaultCellStyle.BackColor = corcima;
            Grid_Materias.RowTemplate.DefaultCellStyle.SelectionBackColor = corcima;
            Lbl_Usuario.Text = UsuarioAtual.Nome;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(30, 5, 60, 60, 0, 360);
            Pb_Img.Region = new System.Drawing.Region(path);
            if (UsuarioAtual.Foto!=null)
            {
                MemoryStream ms = new MemoryStream(UsuarioAtual.Foto);
                Pb_Img.Image = Image.FromStream(ms);
            }
            else
            {
                Pb_Img.Image = Properties.Resources.user__1_;
            }
            Home.MdiParent = this;
            Home.Show();
            Program.PanelUsuario = Panel_Usuario;
            Program.PanelMaterias = Panel_Materias;
            MateriaDAL dal = new MateriaDAL();
            materias = dal.ConsultarTodos();
            CarregarGrid();
            Program.PanelCarregando = Panel_Carregando;
            Program.Logoff = false;
        }

        void CarregarGrid()
        {
            Grid_Materias.Rows.Clear();
            int linha = 0;
            foreach (var item in materias)
            {
                Grid_Materias.Rows.Add();
                Grid_Materias.Rows[linha].Cells[0].Value = item.Nome;
                linha += 1;
            }
        }

        Point Ponto = new Point();
        int x, y;

        private void Panel_Superior_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        

        private void Pb_Menu_MouseEnter(object sender, EventArgs e)
        {
            Panel_Usuario.Visible = true;
            if (UsuarioAtual.Foto != null)
            {
                MemoryStream ms = new MemoryStream(UsuarioAtual.Foto);
                Pb_Img.Image = Image.FromStream(ms);
            }
            else
            {
                Pb_Img.Image = Properties.Resources.user__1_;
            }
            Lbl_Usuario.Text = UsuarioAtual.Nome;
        }
        

        private void Pb_Menu_Click(object sender, EventArgs e)
        {

        }

        private void Panel_Usuario_MouseLeave(object sender, EventArgs e)
        {
        }

        private void Panel_Superior_MouseEnter(object sender, EventArgs e)
        {
            Panel_Usuario.Visible = false;
            Panel_Materias.Visible = false;
        }

        private void Form_Menu_MouseEnter(object sender, EventArgs e)
        {
            Panel_Usuario.Visible = false;
            Panel_Materias.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_MouseEnter(object sender, EventArgs e)
        {
            Panel_Materias.Visible = true;
        }

        private void Grid_Materias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid_Materias.RowCount>0)
            {
                try
                {
                    LimparForms();
                    Panel_Carregando.Visible = true;
                    Panel_Carregando.Refresh();
                    this.Panel_Usuario.Visible = false;
                    this.Panel_Materias.Visible = false;
                    this.Refresh();
                    MateriaDAL dal = new MateriaDAL();
                    Form form = new Form_Conteudo(dal.Consultar(Grid_Materias.CurrentRow.Cells[0].Value.ToString()));
                    form.MdiParent = this;
                    form.Show();
                    Panel_Carregando.Visible = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro de Conexão, tente novamente", "Enigma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.PanelCarregando.Visible = false;
                    Form frm = new Form_Home();
                    frm.MdiParent = this;
                    frm.Show();
                }
                
            }
        }
        void Notas()
        {
            try
            {
                LimparForms();
                Panel_Carregando.Visible = true;
                Panel_Carregando.Refresh();
                this.Panel_Usuario.Visible = false;
                this.Panel_Materias.Visible = false;
                this.Refresh();
                Form frm = new Form_Notas();
                frm.MdiParent = this;
                frm.Show();
                Panel_Carregando.Visible = false;
            }
            catch
            {
                MessageBox.Show("Erro de Conexão, tente novamente", "Enigma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form frm = new Form_Home();
                frm.MdiParent = this;
                frm.Show();
                Program.PanelCarregando.Visible = false;
            }
        }
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            Notas();
            
        }

        void Perfil()
        {
            try
            {
                LimparForms();
                Panel_Carregando.Visible = true;
                Panel_Carregando.Refresh();
                this.Panel_Usuario.Visible = false;
                this.Panel_Materias.Visible = false;
                this.Refresh();
                Panel_Materias.Refresh();
                Panel_Usuario.Refresh();
                Form frm = new Form_Perfil();
                frm.MdiParent = this;
                frm.Show();
                Panel_Carregando.Visible = false;
            }
            catch
            {
                MessageBox.Show("Erro de Conexão, tente novamente", "Enigma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form frm = new Form_Home();
                frm.MdiParent = this;
                frm.Show();
                Program.PanelCarregando.Visible = false;
            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            Perfil();
        }
        void MinhasPR()
        {
            try
            {
                this.Panel_Usuario.Visible = false;
                this.Panel_Materias.Visible = false;
                this.Refresh();
                Form frm = new Form_MinhasPerguntasRespostas();
                frm.ShowDialog();
                Panel_Carregando.Visible = false;
            }
            catch
            {
                MessageBox.Show("Erro de Conexão, tente novamente", "Enigma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form frm = new Form_Home();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            MinhasPR();
        }

        void Forum()
        {
            try
            {
                LimparForms();
                Panel_Carregando.Visible = true;
                Panel_Carregando.Refresh();
                this.Panel_Usuario.Visible = false;
                this.Panel_Materias.Visible = false;
                this.Refresh();
                Form frm = new Form_Forum();
                frm.MdiParent = this;
                frm.Show();
                Panel_Carregando.Visible = false;
            }
            catch
            {
                MessageBox.Show("Erro de Conexão, tente novamente", "Enigma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.PanelCarregando.Visible = false;
                Form frm = new Form_Home();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            Forum();
        }

        private void Panel_Usuario_Paint(object sender, PaintEventArgs e)
        {

        }

        void Desempenho()
        {
            try
            {
                this.Panel_Usuario.Visible = false;
                this.Panel_Materias.Visible = false;
                this.Refresh();
                Form frm = new Form_Desempenho();
                frm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Erro de Conexão, tente novamente", "Enigma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form frm = new Form_Home();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            Desempenho();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Forum();
        }

        private void pictureBox22_MouseEnter(object sender, EventArgs e)
        {
            this.Panel_Materias.Visible = false;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.Panel_Materias.Visible = false;
        }

        private void Panel_Usuario_MouseEnter(object sender, EventArgs e)
        {
            this.Panel_Materias.Visible = false;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.Panel_Materias.Visible = false;
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            Program.PanelMaterias.Visible = false;
            Program.PanelUsuario.Visible = false;
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
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

        private void pictureBox24_MouseEnter(object sender, EventArgs e)
        {
            Program.PanelMaterias.Visible = false;
        }

        private void pictureBox21_MouseEnter(object sender, EventArgs e)
        {
            Program.PanelMaterias.Visible = false;
        }

        private void pictureBox23_MouseEnter(object sender, EventArgs e)
        {
            Program.PanelMaterias.Visible = false;
        }

        void ShowHome()
        {
            LimparForms();
            Panel_Carregando.Visible = true;
            Panel_Carregando.Refresh();
            this.Panel_Usuario.Visible = false;
            this.Panel_Materias.Visible = false;
            this.Refresh();
            Panel_Carregando.Visible = false;
        }
        private void pictureBox28_Click(object sender, EventArgs e)
        {
            ShowHome();
        }

        private void Panel_Carregando_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Perfil();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Desempenho();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MinhasPR();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Program.Logoff = true;
            this.Close();
        }

        private void Form_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.Logoff)
            {
                UsuarioAtual.Email ="";
                UsuarioAtual.Foto = null;
                UsuarioAtual.Nome = "";
                UsuarioAtual.ID = 0;
                UsuarioAtual.TipoConta = "";
                UsuarioAtual.Senha = "";
                Program.Login.Visible = true;
            }
            else
            {
                Application.Exit();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ShowHome();
        }

        private void Pb_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Notas();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Panel_Superior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
        
    }
}
