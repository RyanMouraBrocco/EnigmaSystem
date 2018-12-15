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
    public partial class Form_Cadastro : Form
    {
        bool processar = true;
        public Form_Cadastro()
        {
            InitializeComponent();
        }

        private void Form_Cadastro_Load(object sender, EventArgs e)
        {
            Color color = ColorTranslator.FromHtml("#000449");
            Panel_Superior.BackColor = color;
            Btn_Cadastrar.BackColor = color;
        }

        void Cadastrar()
        {
            LimparErros();
            if (Txt_Nome.Text.Trim()=="")
            {
                Lbl_ErroNome.Visible = true;
                processar = false;
            }
            if (Txt_Email.Text.Trim()=="")
            {
                Lbl_ErroEmail.Text = "Digite o Email";
                Lbl_ErroEmail.Visible = true;
                processar = false;
            }
            else
            {
                if (!Txt_Email.Text.Trim().Contains("@") || !Txt_Email.Text.Trim().Contains(".com"))
                {
                    Lbl_ErroEmail.Text = "Email inválido";
                    Lbl_ErroEmail.Visible = true;
                    processar = false;
                }
                else
                {
                    Usuario usuario = new Usuario();
                    UsuarioDAL dal = new UsuarioDAL();
                    usuario = dal.Consultar(Txt_Email.Text.Trim());
                    if (usuario.ID != 0)
                    {
                        Lbl_ErroEmail.Text = "Email já cadastrado";
                        Lbl_ErroEmail.Visible = true;
                        processar = false;
                    }
                }
            }
            if (Txt_Senha.Text.Trim()=="")
            {
                Lbl_ErroSenha.Text = "Digite a senha";
                Lbl_ErroSenha.Visible = true;
                processar = false;
            }
            else
            {
                if (Txt_Senha.Text.Trim().Length != 8)
                {
                    Lbl_ErroSenha.Text = "A senha deve conter 8 dígitos";
                    Lbl_ErroSenha.Visible = true;
                    processar = false;
                }
                else
                {
                    if (Txt_Senha.Text.Trim()!= Txt_Confirmar.Text.Trim())
                    {
                        Lbl_ErroConfirmar.Visible = true;
                        processar = false;
                    }   
                }
            }
            if (processar)
            {
                Form frm = new Form_Load();
                frm.Show();
                frm.Refresh();
                try
                {
                    Usuario novo = new Usuario
                    {
                        Nome = Txt_Nome.Text.Trim(),
                        Email = Txt_Email.Text.Trim().ToLower(),
                        Foto = null,
                        Senha = Txt_Senha.Text.Trim(),
                        TipoConta = "E"
                    };
                    UsuarioDAL dal = new UsuarioDAL();
                    dal.Inserir(novo);
                    Program.Email = novo.Email;
                    frm.Close();
                    this.Close();
                }
                catch 
                {
                    MessageBox.Show("Erro de conexão, tente novamente","Enigma",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    frm.Close();
                }
                
            }
            processar = true;

        }

        void LimparErros()
        {
            Lbl_ErroConfirmar.Visible = false;
            Lbl_ErroSenha.Visible = false;
            Lbl_ErroNome.Visible = false;
            Lbl_ErroEmail.Visible = false;
        }

        

        private void Pb_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Cadastrar_MouseEnter(object sender, EventArgs e)
        {
            Color cor = ColorTranslator.FromHtml("#00058d");
            Btn_Cadastrar.BackColor = cor;
        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void Btn_Cadastrar_MouseLeave(object sender, EventArgs e)
        {
            Color cor = ColorTranslator.FromHtml("#000449");
            Btn_Cadastrar.BackColor = cor;
        }
    }
}
