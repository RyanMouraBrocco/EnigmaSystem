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
    public partial class Form_Perfil : Form
    {
        bool processar = true;
        bool alterarSenha = false;
        byte[] img = null;
        public Form_Perfil()
        {
            InitializeComponent();
            Txt_Nome.Text = UsuarioAtual.Nome;
            Txt_Email.Text = UsuarioAtual.Email;
            if (UsuarioAtual.Foto!=null)
            {
                img = UsuarioAtual.Foto;
                MemoryStream ms = new MemoryStream(UsuarioAtual.Foto);
                Pb_Foto.Image = Image.FromStream(ms);
            }
        }

        void SumirErros()
        {
            Lbl_ErroNome.Visible = false;
            Lbl_ErroEmail.Visible = false;
            Lbl_ErroSenha.Visible = false;
            Lbl_ErroConfirmar.Visible = false;
        }

        private void Form_Perfil_Load(object sender, EventArgs e)
        {
            Color cor = ColorTranslator.FromHtml("#000449");
            Btn_Salvar.BackColor = cor;
            Btn_Alterar.BackColor = cor;
            Btn_Senha.BackColor = cor;

        }

        private void Btn_Salvar_MouseEnter(object sender, EventArgs e)
        {
            Btn_Salvar.BackColor = Color.Navy;
        }

        private void Btn_Salvar_MouseLeave(object sender, EventArgs e)
        {
            Color cor = ColorTranslator.FromHtml("#000449");
            Btn_Salvar.BackColor = cor;
        }

        private void Btn_Alterar_Click(object sender, EventArgs e)
        {
            FileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                Pb_Foto.Image = Image.FromFile(FileDialog.FileName);
                img = File.ReadAllBytes(FileDialog.FileName);
            }
        }

        private void Btn_Senha_Click(object sender, EventArgs e)
        {
            if (alterarSenha==false)
            {
                Btn_Senha.Text = "Cancelar";
                Gb_Senha.Visible = true;
                alterarSenha = true;
            }
            else
            {
                Btn_Senha.Text = "Alterar Senha";
                Gb_Senha.Visible = false;
                alterarSenha = false;
            }
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            SumirErros();
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
                    Lbl_ErroEmail.Text = "Email iválido";
                    Lbl_ErroEmail.Visible = true;
                    processar = false;
                }
                else
                {
                    try
                    {
                        Program.PanelCarregando.Visible = true;
                        Program.PanelCarregando.Refresh();
                        UsuarioDAL dal = new UsuarioDAL();
                        Usuario usuario = new Usuario();
                        usuario = dal.Consultar(Txt_Email.Text.Trim());
                        if (usuario.ID != 0 && usuario.ID != UsuarioAtual.ID)
                        {
                            Lbl_ErroEmail.Text = "Email já cadastrado";
                            Lbl_ErroEmail.Visible = true;
                            processar = false;
                        }
                        Program.PanelCarregando.Visible = false;
                    }
                    catch 
                    {
                        MessageBox.Show("Erro de Conexão, tente novamente", "Enigma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Program.PanelCarregando.Visible = false;
                    }
                   
                }
                
            }
            if (alterarSenha)
            {
                if (Txt_Senha.Text.Trim()=="")
                {
                    Lbl_ErroSenha.Text = "Digite a senha";
                    Lbl_ErroSenha.Visible = true;
                    processar = false;
                }
                else
                {
                    if (Txt_Senha.Text.Trim().Length!=8)
                    {
                        Lbl_ErroSenha.Text = "A senha deve ter 8 digitos";
                        Lbl_ErroSenha.Visible = true;
                        processar = false;
                    }
                    else
                    {
                        if (Txt_ConfirmarSenha.Text.Trim() != Txt_Senha.Text.Trim())
                        {
                            Lbl_ErroConfirmar.Visible = true;
                            processar = false;
                        }
                    }
                }
            }
            if (processar)
            {
                Usuario atualizado = new Usuario
                {
                    ID = UsuarioAtual.ID,
                    Email = Txt_Email.Text.Trim().ToLower(),
                    TipoConta = UsuarioAtual.TipoConta,
                    Nome = Txt_Nome.Text.Trim(),
                    Foto=img
                };
                UsuarioDAL dal = new UsuarioDAL();
                if (alterarSenha)
                {
                    atualizado.Senha = Txt_Senha.Text.Trim();
                    dal.Alterar(atualizado);
                }
                else
                {
                    dal.AlterarSemSenha(atualizado);
                }
                UsuarioAtual.Nome = atualizado.Nome;
                UsuarioAtual.Email = atualizado.Email;
                UsuarioAtual.Foto = atualizado.Foto;
                this.Close();
            }
            processar = true;
        }

        private void Form_Perfil_MouseEnter(object sender, EventArgs e)
        {
            Program.PanelMaterias.Visible = false;
            Program.PanelUsuario.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            Program.PanelMaterias.Visible = false;
            Program.PanelUsuario.Visible = false;
        }

        private void Form_AlterarImagem_MouseEnter(object sender, EventArgs e)
        {
            Program.PanelMaterias.Visible = false;
            Program.PanelUsuario.Visible = false;
            Color cor = ColorTranslator.FromHtml("#00058d");
            Btn_Alterar.BackColor = cor;
        }

        private void Btn_Alterar_MouseLeave(object sender, EventArgs e)
        {
            Color cor = ColorTranslator.FromHtml("#000449");
            Btn_Alterar.BackColor = cor;
        }

        private void Form_Senha_MouseEnter(object sender, EventArgs e)
        {
            Program.PanelMaterias.Visible = false;
            Program.PanelUsuario.Visible = false;
            Color cor = ColorTranslator.FromHtml("#00058d");
            Btn_Senha.BackColor = cor;
        }

        private void Btn_Senha_MouseLeave(object sender, EventArgs e)
        {
            Color cor = ColorTranslator.FromHtml("#000449");
            Btn_Senha.BackColor = cor;
        }
    }
}