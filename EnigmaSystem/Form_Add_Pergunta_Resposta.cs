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
    public partial class Form_Add_Pergunta_Resposta : Form
    {
        bool processar = true;
        bool cadastrarpergunta = true;
        List<Imagem> imagens = new List<Imagem>();
        Pergunta pergunta = new Pergunta();
        public Form_Add_Pergunta_Resposta()
        {
            InitializeComponent();
        }
        public Form_Add_Pergunta_Resposta(Pergunta pergunta)
        {
            InitializeComponent();
            this.pergunta = pergunta;
            Lbl_Pergunta_Resposta.Text = "Resposta";
            cadastrarpergunta = false;
        }
        private void Form_Add_Pergunta_Resposta_Load(object sender, EventArgs e)
        {
            Color cor = ColorTranslator.FromHtml("#000449");
            Panel_Superior.BackColor = cor;
            Btn_Publicar.BackColor = cor;
        }
        void SumirErro()
        {
            Lbl_ErroTitulo.Visible = false;
            Lbl_ErroPerguntaResposta.Visible = false;
        }

        private void Btn_Publicar_Click(object sender, EventArgs e)
        {
            SumirErro();
            if (Txt_Titulo.Text.Trim()=="")
            {
                Lbl_ErroTitulo.Visible = true;
                processar = false;
            }
            if (Txt_PerguntaResposta.Text.Trim()=="")
            {
                if (cadastrarpergunta)
                {
                    Lbl_ErroPerguntaResposta.Text = "Digite o pergunta";
                }
                else
                {
                    Lbl_ErroPerguntaResposta.Text = "Digite a resposta";
                }
                Lbl_ErroPerguntaResposta.Visible = true;
                processar = false;
            }
            if (processar)
            {
                Form frm = new Form_Load();
                frm.Show();
                frm.Refresh();
                if (cadastrarpergunta)
                {
                    Pergunta Novapergunta = new Pergunta
                    {
                        Resposta = null,
                        Imagem = new List<Imagem>(),
                        Texto = Txt_PerguntaResposta.Text.Trim(),
                        Titulo = Txt_Titulo.Text.Trim(),
                        Usuario = UsuarioAtual.ID,
                        Visibilidade = true
                    };
                    if (imagens.Count > 0)
                    {
                        Novapergunta.Imagem = imagens;
                    }
                    try
                    {
                        PerguntaDAL dal = new PerguntaDAL();
                        dal.Inserir(Novapergunta);
                        frm.Close();
                        this.Close();
                    }
                    catch 
                    {
                        MessageBox.Show("Erro de Conexão, tente novamente", "Enigma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        frm.Close();
                    }
                    
                }
                else
                {
                    Resposta resposta = new Resposta
                    {
                        Pergunta = this.pergunta,
                        Imagem = new List<Imagem>(),
                        Texto = Txt_PerguntaResposta.Text.Trim(),
                        Titulo = Txt_Titulo.Text.Trim(),
                        Usuario = UsuarioAtual.ID,
                        Visibilidade = true
                    };
                    if (imagens.Count > 0)
                    {
                        resposta.Imagem = imagens;
                    }
                    try
                    {
                        RespostaDAL dal = new RespostaDAL();
                        dal.Inserir(resposta);
                        frm.Close();
                        this.Close();
                    }
                    catch 
                    {
                        MessageBox.Show("Erro de Conexão, tente novamente", "Enigma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        frm.Close();
                    }
                }
            }
            processar = true;
        }

        private void Llb_AddImagem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                Imagem img = new Imagem
                {
                    Extensao = Path.GetExtension(FileDialog.FileName),
                    Nome = Path.GetFileName(FileDialog.FileName),
                    Usuario = UsuarioAtual.ID,
                    _Imagem = File.ReadAllBytes(FileDialog.FileName)
                };
                imagens.Add(img);
                List_Imagem.Items.Add(Path.GetFileName(FileDialog.FileName));
            }
        }

        private void List_Imagem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (List_Imagem.SelectedItem!=null)
                {
                    if (MessageBox.Show("Deseja deletar essa imagem ?","Enigma",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                    {
                        for (int i = 0; i < List_Imagem.Items.Count; i++)
                        {
                            if (List_Imagem.Items[i] == List_Imagem.SelectedItem)
                            {
                                imagens.RemoveAt(i);
                                List_Imagem.Items.RemoveAt(i);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void Btn_Publicar_MouseLeave(object sender, EventArgs e)
        {
            Color cor = ColorTranslator.FromHtml("#000449");
            Btn_Publicar.BackColor = cor;
        }

        private void Btn_Publicar_MouseEnter(object sender, EventArgs e)
        {
            Color cor = ColorTranslator.FromHtml("#00058d");
            Btn_Publicar.BackColor = cor;
        }

        private void Pb_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point Ponto = new Point();
        int x, y;

        private void Panel_Superior_MouseDown(object sender, MouseEventArgs e)
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
    }
}
