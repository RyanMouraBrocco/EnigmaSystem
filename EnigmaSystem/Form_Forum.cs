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
    public partial class Form_Forum : Form
    {
        List<Pergunta> perguntas = new List<Pergunta>();
        Pergunta Atual = new Pergunta();
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        List<PictureBox> pictureBoxesPergunta = new List<PictureBox>();
        public Form_Forum()
        {
            InitializeComponent();
            try
            {
                Buscar();
                CarregarGrid();
            }
            catch 
            {
                this.Close();
            }
           
        }
        void Buscar()
        {
            PerguntaDAL dal = new PerguntaDAL();
            perguntas = dal.ConsultarTodos();
        }

        void CarregarGrid()
        {
            int linha = 0;
            Grid_Perguntas.Rows.Clear();
            foreach (var item in perguntas)
            {
                AvaliacaoDAL dalaval = new AvaliacaoDAL();
                Avaliacao estaaval = new Avaliacao();
                estaaval = dalaval.Consultar(UsuarioAtual.ID, item.ID, 0);
                if (estaaval.Denuncia)
                {
                    item.Visibilidade = false;
                }
                if (item.Visibilidade)
                {
                    Grid_Perguntas.Rows.Add();
                    Grid_Perguntas.Rows[linha].Cells[0].Value = item.Titulo;
                    Grid_Perguntas.Rows[linha].Cells[1].Value = item.ID;
                    linha += 1;
                }
                
            }
        }

        void CarregarGrid(string texto)
        {
            int linha = 0;
            Grid_Perguntas.Rows.Clear();
            foreach (var item in perguntas.Where(x=>x.Titulo.Trim().ToUpper().Contains(texto.Trim().ToUpper())))
            {
                AvaliacaoDAL dalaval = new AvaliacaoDAL();
                Avaliacao estaaval = new Avaliacao();
                estaaval = dalaval.Consultar(UsuarioAtual.ID, item.ID, 0);
                if (estaaval.Denuncia)
                {
                    item.Visibilidade = false;
                }
                if (item.Visibilidade)
                {
                    Grid_Perguntas.Rows.Add();
                    Grid_Perguntas.Rows[linha].Cells[0].Value = item.Titulo;
                    Grid_Perguntas.Rows[linha].Cells[1].Value = item.ID;
                    linha += 1;
                }

            }
        }

        private void Form_Forum_Load(object sender, EventArgs e)
        {
            Color cor = ColorTranslator.FromHtml("#000449");
            Grid_Perguntas.RowTemplate.DefaultCellStyle.SelectionBackColor = cor;
            Grid_Perguntas.RowTemplate.DefaultCellStyle.BackColor = cor;
            Btn_NovaPergunta.BackColor = cor;
        }

        void CarregarPergunta()
        {
            Panel_View.Controls.Clear();
            Point point = new Point(25,18);
            UsuarioDAL dalus = new UsuarioDAL();
            Usuario RealizadorPergunta = new Usuario();
            RealizadorPergunta = dalus.Consultar(Atual.Usuario);
            PictureBox FotoUsuario = new PictureBox
            {
                Size = new Size(92, 64),
                Location = point,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            if (RealizadorPergunta.Foto != null)
            {
                MemoryStream ms = new MemoryStream(RealizadorPergunta.Foto);
                FotoUsuario.Image = Image.FromStream(ms);
            }
            else
            {
                FotoUsuario.Image = Properties.Resources.user__1_;
            }
            Panel_View.Controls.Add(FotoUsuario);
            Label NomeUsuario = new Label
            {
                Text = RealizadorPergunta.Nome,
                Font = new Font("Arial", 10),
                AutoSize = true,
                Location = new Point(point.X + FotoUsuario.Size.Width, point.Y)
            };
            Panel_View.Controls.Add(NomeUsuario);
            point.Y += FotoUsuario.Size.Height;
            Label Titulo = new Label
            {
                Text = Atual.Titulo,
                Font = new Font("Arial", 20, FontStyle.Bold),
                AutoSize = true,
                Location = point
            };
            Panel_View.Controls.Add(Titulo);
            point.Y += Titulo.Height;
            Label TextoPerg = new Label
            {
                Text = Atual.Texto,
                Font = new Font("Arial", 14),
                AutoSize = true,
                Location = point
            };
            Panel_View.Controls.Add(TextoPerg);
            point.Y += Titulo.Height;
            foreach (var item in Atual.Imagem)
            {
                PictureBox Img = new PictureBox
                {
                    Size = new Size(400,200),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Location = point
                };
                MemoryStream ms = new MemoryStream(item._Imagem);
                Img.Image = Image.FromStream(ms);
                Panel_View.Controls.Add(Img);
                point.Y += Img.Size.Height;
            }
            PictureBox Like = new PictureBox
            {
                Size = new Size(80, 40),
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = point,
                Name = "L"+Atual.ID.ToString()
            };
            AvaliacaoDAL dalAval = new AvaliacaoDAL();
            Avaliacao esta = dalAval.Consultar(UsuarioAtual.ID, Atual.ID, 0);
            if (esta.ID!= 0 && esta._Avaliacao)
            {
                Like.Image = Properties.Resources.like_ativo;
            }
            else
            {
                Like.Image = Properties.Resources.like;
            }
            Like.Click += (object sender, EventArgs e) => 
            {
                PictureBox este = sender as PictureBox;
                Avaliacao avaliacao = new Avaliacao();
                AvaliacaoDAL dal = new AvaliacaoDAL();
                avaliacao = dal.Consultar(UsuarioAtual.ID,Convert.ToInt32(este.Name.Substring(1,este.Name.Length - 1)),0);
                if (avaliacao.ID == 0)
                {
                    avaliacao = new Avaliacao
                    {
                        Denuncia = false,
                        Pergunta = Atual,
                        Resposta = null,
                        Usuario = new Usuario { ID = UsuarioAtual.ID },
                        _Avaliacao = true
                    };
                    dal.Inserir(avaliacao);
                }
                else
                {
                    avaliacao._Avaliacao = true;
                    dal.Alterar(avaliacao);
                }
                este.Image = Properties.Resources.like_ativo;
                foreach (var item in pictureBoxesPergunta.Where(x=>x.Name == "D"+este.Name.Replace("L","")))
                {
                    item.Image = Properties.Resources.dislike;
                }
            };
            Panel_View.Controls.Add(Like);
            PictureBox Dislike = new PictureBox
            {
                Size = new Size(80, 40),
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(point.X + Like.Size.Width, point.Y),
                Name = "D" + Atual.ID.ToString()
            };
            if (esta.ID != 0 && esta._Avaliacao==false)
            {
                Dislike.Image = Properties.Resources.dislike_ativo;
            }
            else
            {
                Dislike.Image = Properties.Resources.dislike;
            }
            Dislike.Click += (object sender, EventArgs e) =>
            {
                PictureBox este = sender as PictureBox;
                Avaliacao avaliacao = new Avaliacao();
                AvaliacaoDAL dal = new AvaliacaoDAL();
                avaliacao = dal.Consultar(UsuarioAtual.ID, Convert.ToInt32(este.Name.Substring(1, este.Name.Length - 1)), 0);
                if (avaliacao.ID == 0)
                {
                    avaliacao = new Avaliacao
                    {
                        Denuncia = false,
                        Pergunta = Atual,
                        Resposta = null,
                        Usuario = new Usuario { ID = UsuarioAtual.ID },
                        _Avaliacao = false
                    };
                    dal.Inserir(avaliacao);
                }
                else
                {
                    avaliacao._Avaliacao = false;
                    dal.Alterar(avaliacao);
                }
                este.Image = Properties.Resources.dislike_ativo;
                foreach (var item in pictureBoxesPergunta.Where(x => x.Name == "L" + este.Name.Replace("D", "")))
                {
                    item.Image = Properties.Resources.like;
                }
            };
            Panel_View.Controls.Add(Dislike);
            pictureBoxesPergunta.Add(Like);
            pictureBoxesPergunta.Add(Dislike);
            Label Denucia = new Label
            {
                Text = "Denunciar",
                Font = new Font("Arial", 10),
                AutoSize = true,
                Location = new Point(point.X + Like.Size.Width + Dislike.Size.Width, point.Y),
                ForeColor = ColorTranslator.FromHtml("#000449"),
                Name = Atual.ID.ToString()
            };
            Denucia.Click += (object sender, EventArgs e) =>
            {
                Label este = sender as Label;
                if (MessageBox.Show("Deseja realmente denunciar essa pergunta ? Essa ação não poderá ser desfeita","Enigma",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    Avaliacao avaliacao = new Avaliacao();
                    AvaliacaoDAL dal = new AvaliacaoDAL();
                    avaliacao = dal.Consultar(UsuarioAtual.ID, Convert.ToInt32(este.Name), 0);
                    if (avaliacao.ID == 0)
                    {
                        avaliacao = new Avaliacao
                        {
                            Denuncia = true,
                            Pergunta = Atual,
                            Resposta = null,
                            Usuario = new Usuario { ID = UsuarioAtual.ID },
                            _Avaliacao = false
                        };
                        dal.Inserir(avaliacao);
                    }
                    else
                    {
                        avaliacao.Denuncia = true;
                        dal.Alterar(avaliacao);
                    }
                    Panel_View.Controls.Clear();
                    Buscar();
                    CarregarGrid();
                }
            };
            Panel_View.Controls.Add(Denucia);
            point.Y += Like.Size.Height; 
            point.Y += 5;
            Label respostas = new Label
            {
                Text ="Respostas",
                Font = new Font("Arial", 24, FontStyle.Bold),
                AutoSize = true,
                Location = point
            };
            Panel_View.Controls.Add(respostas);
            Button responder = new Button
            {
                Text = "Responder",
                Font = new Font("Arial", 24),
                ForeColor = Color.White,
                BackColor = ColorTranslator.FromHtml("#000449"),
                Size = new Size(80, 40),
                AutoSize = true,
                Location = new Point(point.X + respostas.Size.Width,point.Y)
            };
            responder.MouseEnter+=(object sender, EventArgs e)=>
            {
                Program.PanelMaterias.Visible = false;
                Program.PanelUsuario.Visible = false;
                Button este = sender as Button;
                Color cor = ColorTranslator.FromHtml("#00058d");
                este.BackColor = cor;
            };
            responder.MouseLeave += (object sender, EventArgs e) =>
            {
                Color cor = ColorTranslator.FromHtml("#000449");
                Button este = sender as Button;
                este.BackColor = cor;
            };
            responder.Click += (object sender, EventArgs e) =>
            {
                Form form = new Form_Add_Pergunta_Resposta(Atual);
                form.ShowDialog();
                PerguntaDAL dal = new PerguntaDAL();
                Atual = dal.Consultar(Atual.ID);
                CarregarPergunta();
            };
            Panel_View.Controls.Add(responder);
            point.Y += respostas.Size.Height + 20;
            CarregarRespostas(point);
        }

        void CarregarRespostas(Point Ponto)
        {
            Point point = Ponto;
            foreach (var item in Atual.Resposta.Where(x=>x.Visibilidade))
            {
                AvaliacaoDAL dalAval = new AvaliacaoDAL();
                Avaliacao Denuncia = dalAval.Consultar(UsuarioAtual.ID, 0, item.ID);
                if (Denuncia.ID == 0 || Denuncia.Denuncia==false)
                {
                    // Montando Perfil do Usuario que realizou a resposta
                    UsuarioDAL dalus = new UsuarioDAL();
                    PictureBox FotoUsuario = new PictureBox
                    {
                        Size = new Size(92, 64),
                        Location = point,
                        SizeMode = PictureBoxSizeMode.Zoom
                    };
                    Usuario usuarioResposta = dalus.Consultar(item.Usuario);
                    if (usuarioResposta.Foto != null)
                    {
                        MemoryStream ms = new MemoryStream(usuarioResposta.Foto);
                        FotoUsuario.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        FotoUsuario.Image = Properties.Resources.user__1_;
                    }
                    Panel_View.Controls.Add(FotoUsuario);
                    Label NomeUsuario = new Label
                    {
                        Text = usuarioResposta.Nome,
                        Font = new Font("Arial", 10),
                        AutoSize = true,
                        Location = new Point(point.X + FotoUsuario.Size.Width, point.Y)
                    };
                    Panel_View.Controls.Add(NomeUsuario);
                    point.Y += FotoUsuario.Size.Height;
                    Label Titulo = new Label
                    {
                        Text = item.Titulo,
                        Font = new Font("Arial", 20, FontStyle.Bold),
                        AutoSize = true,
                        Location = point
                    };
                    Panel_View.Controls.Add(Titulo);
                    point.Y += Titulo.Height;
                    Label TextoPerg = new Label
                    {
                        Text = item.Texto,
                        Font = new Font("Arial", 14),
                        AutoSize = true,
                        Location = point
                    };
                    Panel_View.Controls.Add(TextoPerg);
                    point.Y += TextoPerg.Height;
                    foreach (var i in item.Imagem)
                    {
                        PictureBox Img = new PictureBox
                        {
                            Size = new Size(400, 200),
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Location = point
                        };
                        MemoryStream ms = new MemoryStream(i._Imagem);
                        Img.Image = Image.FromStream(ms);
                        Panel_View.Controls.Add(Img);
                        point.Y += Img.Size.Height;
                    }
                    PictureBox Like = new PictureBox
                    {
                        Size = new Size(80, 40),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Location = point,
                        Name = "L" + item.ID.ToString()
                    };
                    Avaliacao esta = dalAval.Consultar(UsuarioAtual.ID, 0, item.ID);
                    if (esta.ID != 0 && esta._Avaliacao)
                    {
                        Like.Image = Properties.Resources.like_ativo;
                    }
                    else
                    {
                        Like.Image = Properties.Resources.like;
                    }
                    Like.Click += (object sender, EventArgs e) =>
                    {
                        PictureBox este = sender as PictureBox;
                        Avaliacao avaliacao = new Avaliacao();
                        AvaliacaoDAL dal = new AvaliacaoDAL();
                        avaliacao = dal.Consultar(UsuarioAtual.ID, 0, Convert.ToInt32(este.Name.Substring(1, este.Name.Length - 1)));
                        if (avaliacao.ID == 0)
                        {
                            avaliacao = new Avaliacao
                            {
                                Denuncia = false,
                                Pergunta = null,
                                Resposta = item,
                                Usuario = new Usuario { ID = UsuarioAtual.ID },
                                _Avaliacao = true
                            };
                            dal.Inserir(avaliacao);
                        }
                        else
                        {
                            avaliacao._Avaliacao = true;
                            dal.Alterar(avaliacao);
                        }
                        este.Image = Properties.Resources.like_ativo;
                        foreach (var i in pictureBoxes.Where(x => x.Name == "D" + este.Name.Replace("L", "")))
                        {
                            i.Image = Properties.Resources.dislike;
                        }
                    };
                    Panel_View.Controls.Add(Like);
                    PictureBox Dislike = new PictureBox
                    {
                        Size = new Size(80, 40),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Location = new Point(point.X + Like.Size.Width, point.Y),
                        Name = "D" + item.ID.ToString()
                    };
                    if (esta.ID != 0 && esta._Avaliacao == false)
                    {
                        Dislike.Image = Properties.Resources.dislike_ativo;
                    }
                    else
                    {
                        Dislike.Image = Properties.Resources.dislike;
                    }
                    Dislike.Click += (object sender, EventArgs e) =>
                    {
                        PictureBox este = sender as PictureBox;
                        Avaliacao avaliacao = new Avaliacao();
                        AvaliacaoDAL dal = new AvaliacaoDAL();
                        avaliacao = dal.Consultar(UsuarioAtual.ID, 0, Convert.ToInt32(este.Name.Substring(1, este.Name.Length - 1)));
                        if (avaliacao.ID == 0)
                        {
                            avaliacao = new Avaliacao
                            {
                                Denuncia = false,
                                Pergunta = null,
                                Resposta = item,
                                Usuario = new Usuario { ID = UsuarioAtual.ID },
                                _Avaliacao = false
                            };
                            dal.Inserir(avaliacao);
                        }
                        else
                        {
                            avaliacao._Avaliacao = false;
                            dal.Alterar(avaliacao);
                        }
                        este.Image = Properties.Resources.dislike_ativo;
                        foreach (var i in pictureBoxes.Where(x => x.Name == "L" + este.Name.Replace("D", "")))
                        {
                            i.Image = Properties.Resources.like;
                        }
                    };
                    Panel_View.Controls.Add(Dislike);
                    pictureBoxes.Add(Like);
                    pictureBoxes.Add(Dislike);
                    Label Denucia = new Label
                    {
                        Text = "Denunciar",
                        Font = new Font("Arial", 10),
                        AutoSize = true,
                        Location = new Point(point.X + Like.Size.Width + Dislike.Size.Width, point.Y),
                        ForeColor = ColorTranslator.FromHtml("#000449"),
                        Name = Atual.ID.ToString()
                    };
                    Denucia.Click += (object sender, EventArgs e) =>
                    {
                        Label este = sender as Label;
                        if (MessageBox.Show("Deseja realmente denunciar essa resposta ? Essa ação não poderá ser desfeita", "Enigma", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Avaliacao avaliacao = new Avaliacao();
                            AvaliacaoDAL dal = new AvaliacaoDAL();
                            avaliacao = dal.Consultar(UsuarioAtual.ID, 0, Convert.ToInt32(este.Name));
                            if (avaliacao.ID == 0)
                            {
                                avaliacao = new Avaliacao
                                {
                                    Denuncia = true,
                                    Pergunta = null,
                                    Resposta = item,
                                    Usuario = new Usuario { ID = UsuarioAtual.ID },
                                    _Avaliacao = false
                                };
                                dal.Inserir(avaliacao);
                            }
                            else
                            {
                                avaliacao.Denuncia = true;
                                dal.Alterar(avaliacao);
                            }
                            CarregarPergunta();
                        }
                    };
                    Panel_View.Controls.Add(Denucia);
                    point.Y += Like.Size.Height;
                    Label fim = new Label
                    {
                        Text = "--------------------------------------------------------",
                        Font = new Font("Arial", 14),
                        AutoSize = true,
                        Location = point
                    };
                    Panel_View.Controls.Add(fim);
                    point.Y += fim.Size.Height;
                }
            }
        }

        private void Grid_Perguntas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid_Perguntas.Rows.Count>0)
            {
                foreach (var item in perguntas.Where(x=>x.ID == Convert.ToInt32(Grid_Perguntas.CurrentRow.Cells[1].Value)))
                {
                    try
                    {
                        Program.PanelCarregando.Visible = true;
                        Program.PanelCarregando.Refresh();
                        PerguntaDAL dal = new PerguntaDAL();
                        Atual = dal.Consultar(item.ID);
                        CarregarPergunta();
                        Program.PanelCarregando.Visible = false;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro de Conexão, tente novamente", "Enigma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Program.PanelCarregando.Visible = false;
                    }
                    
                }
            }
        }

        private void Txt_Pesquisa_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Pesquisa.Text.Trim()=="")
            {
                CarregarGrid();
            }
            else
            {
                CarregarGrid(Txt_Pesquisa.Text.Trim());
            }
        }

        private void Btn_NovaPergunta_Click(object sender, EventArgs e)
        {
            Form frm = new Form_Add_Pergunta_Resposta();
            frm.ShowDialog();
            Buscar();
            CarregarGrid();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Program.PanelMaterias.Visible = false;
            Program.PanelUsuario.Visible = false;
        }
        

        private void Btn_NovaPergunta_MouseLeave(object sender, EventArgs e)
        {
            Color cor = ColorTranslator.FromHtml("#000449");
            Btn_NovaPergunta.BackColor = cor;
        }

        private void Btn_NovaPergunta_MouseEnter(object sender, EventArgs e)
        {
            Program.PanelMaterias.Visible = false;
            Program.PanelUsuario.Visible = false;
            Color cor = ColorTranslator.FromHtml("#00058d");
            Btn_NovaPergunta.BackColor = cor;
        }

        private void Btn_NovaPergunta_Click_1(object sender, EventArgs e)
        {
            Form frm = new Form_Add_Pergunta_Resposta();
            frm.ShowDialog();
            Buscar();
            CarregarGrid();
        }
    }
}
