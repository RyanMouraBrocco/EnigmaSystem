using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnigmaClass;
using EnigmaClass.CRUD;

namespace EnigmaSystem
{
    public partial class Form_Login : Form
    {
        bool processar = true;
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string colorcode = "#000449";
            Color c = System.Drawing.ColorTranslator.FromHtml(colorcode);
            PanelSuperior.BackColor = c;
        }

        private void PTB_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PTB_Logar_Click(object sender, EventArgs e)
        {
            if (Txt_Login.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o Login","Enigma",MessageBoxButtons.OK,MessageBoxIcon.Error);
                processar=false;
            }
            if (Txt_Senha.Text.Trim()=="")
            {
                MessageBox.Show("Preencha a Senha", "Enigma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                processar=false;
            }
            if (processar)
            {
                Form frm = new Form_Load();
                frm.Show();
                frm.Refresh();
                try
                {
                    UsuarioDAL dal = new UsuarioDAL();
                    if (dal.Logar(Txt_Login.Text.Trim(), Txt_Senha.Text.Trim()))
                    {
                        Usuario atual = dal.Consultar(Txt_Login.Text.Trim());
                        if (atual.TipoConta != "B")
                        {
                            Form menu = new Form_Menu();
                            this.Visible = false;
                            Program.Email = "";
                            UsuarioAtual.ID = atual.ID;
                            UsuarioAtual.Nome = atual.Nome;
                            UsuarioAtual.Email = atual.Email;
                            UsuarioAtual.Foto = atual.Foto;
                            UsuarioAtual.TipoConta = atual.TipoConta;
                            UsuarioAtual.Senha = "";
                            Program.Login = this;
                            frm.Close();
                            menu.ShowDialog();
                            Txt_Login.Clear();
                            Txt_Senha.Clear();
                            Program.Email = "";
                            Txt_Login.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Essa conta foi banida", "Enigma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            frm.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login e/ou Senha estão incorretos", "Enigma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        frm.Close();
                    }
                }
                catch 
                {
                    MessageBox.Show("Erro de conexão, tente novamente", "Enigma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    frm.Close();
                }
            }
            processar = true;
        }

        private void Ll_Cadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Cadastro frm = new Form_Cadastro();
            frm.ShowDialog();
            if (Program.Email!="")
            {
                Txt_Login.Text = Program.Email;
            }
        }
        
    }
}
