namespace EnigmaSystem
{
    partial class Form_Add_Pergunta_Resposta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Add_Pergunta_Resposta));
            this.Panel_Superior = new System.Windows.Forms.Panel();
            this.Pb_Fechar = new System.Windows.Forms.PictureBox();
            this.Txt_Titulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Pergunta_Resposta = new System.Windows.Forms.Label();
            this.Txt_PerguntaResposta = new System.Windows.Forms.TextBox();
            this.List_Imagem = new System.Windows.Forms.ListBox();
            this.Llb_AddImagem = new System.Windows.Forms.LinkLabel();
            this.Btn_Publicar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_ErroTitulo = new System.Windows.Forms.Label();
            this.Lbl_ErroPerguntaResposta = new System.Windows.Forms.Label();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Panel_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Superior
            // 
            this.Panel_Superior.Controls.Add(this.Pb_Fechar);
            this.Panel_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Superior.Location = new System.Drawing.Point(0, 0);
            this.Panel_Superior.Name = "Panel_Superior";
            this.Panel_Superior.Size = new System.Drawing.Size(557, 56);
            this.Panel_Superior.TabIndex = 0;
            this.Panel_Superior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Superior_MouseDown);
            this.Panel_Superior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Superior_MouseMove);
            // 
            // Pb_Fechar
            // 
            this.Pb_Fechar.Image = global::EnigmaSystem.Properties.Resources.x;
            this.Pb_Fechar.Location = new System.Drawing.Point(510, 4);
            this.Pb_Fechar.Name = "Pb_Fechar";
            this.Pb_Fechar.Size = new System.Drawing.Size(40, 46);
            this.Pb_Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_Fechar.TabIndex = 0;
            this.Pb_Fechar.TabStop = false;
            this.Pb_Fechar.Click += new System.EventHandler(this.Pb_Fechar_Click);
            // 
            // Txt_Titulo
            // 
            this.Txt_Titulo.BackColor = System.Drawing.Color.Gainsboro;
            this.Txt_Titulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Titulo.Location = new System.Drawing.Point(16, 96);
            this.Txt_Titulo.Name = "Txt_Titulo";
            this.Txt_Titulo.Size = new System.Drawing.Size(526, 22);
            this.Txt_Titulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Título";
            // 
            // Lbl_Pergunta_Resposta
            // 
            this.Lbl_Pergunta_Resposta.AutoSize = true;
            this.Lbl_Pergunta_Resposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Pergunta_Resposta.Location = new System.Drawing.Point(12, 128);
            this.Lbl_Pergunta_Resposta.Name = "Lbl_Pergunta_Resposta";
            this.Lbl_Pergunta_Resposta.Size = new System.Drawing.Size(86, 24);
            this.Lbl_Pergunta_Resposta.TabIndex = 3;
            this.Lbl_Pergunta_Resposta.Text = "Pergunta";
            // 
            // Txt_PerguntaResposta
            // 
            this.Txt_PerguntaResposta.BackColor = System.Drawing.Color.Gainsboro;
            this.Txt_PerguntaResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PerguntaResposta.Location = new System.Drawing.Point(16, 155);
            this.Txt_PerguntaResposta.Multiline = true;
            this.Txt_PerguntaResposta.Name = "Txt_PerguntaResposta";
            this.Txt_PerguntaResposta.Size = new System.Drawing.Size(526, 114);
            this.Txt_PerguntaResposta.TabIndex = 4;
            // 
            // List_Imagem
            // 
            this.List_Imagem.BackColor = System.Drawing.Color.Gainsboro;
            this.List_Imagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_Imagem.FormattingEnabled = true;
            this.List_Imagem.ItemHeight = 16;
            this.List_Imagem.Location = new System.Drawing.Point(16, 281);
            this.List_Imagem.Name = "List_Imagem";
            this.List_Imagem.Size = new System.Drawing.Size(120, 100);
            this.List_Imagem.TabIndex = 5;
            this.List_Imagem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.List_Imagem_KeyUp);
            // 
            // Llb_AddImagem
            // 
            this.Llb_AddImagem.AutoSize = true;
            this.Llb_AddImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Llb_AddImagem.Location = new System.Drawing.Point(142, 365);
            this.Llb_AddImagem.Name = "Llb_AddImagem";
            this.Llb_AddImagem.Size = new System.Drawing.Size(89, 16);
            this.Llb_AddImagem.TabIndex = 6;
            this.Llb_AddImagem.TabStop = true;
            this.Llb_AddImagem.Text = "ADD Imagem";
            this.Llb_AddImagem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Llb_AddImagem_LinkClicked);
            // 
            // Btn_Publicar
            // 
            this.Btn_Publicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Publicar.ForeColor = System.Drawing.Color.White;
            this.Btn_Publicar.Location = new System.Drawing.Point(391, 309);
            this.Btn_Publicar.Name = "Btn_Publicar";
            this.Btn_Publicar.Size = new System.Drawing.Size(154, 76);
            this.Btn_Publicar.TabIndex = 7;
            this.Btn_Publicar.Text = "Publicar";
            this.Btn_Publicar.UseVisualStyleBackColor = true;
            this.Btn_Publicar.Click += new System.EventHandler(this.Btn_Publicar_Click);
            this.Btn_Publicar.MouseEnter += new System.EventHandler(this.Btn_Publicar_MouseEnter);
            this.Btn_Publicar.MouseLeave += new System.EventHandler(this.Btn_Publicar_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(540, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "_____________________________________________________";
            // 
            // Lbl_ErroTitulo
            // 
            this.Lbl_ErroTitulo.AutoSize = true;
            this.Lbl_ErroTitulo.ForeColor = System.Drawing.Color.Red;
            this.Lbl_ErroTitulo.Location = new System.Drawing.Point(74, 77);
            this.Lbl_ErroTitulo.Name = "Lbl_ErroTitulo";
            this.Lbl_ErroTitulo.Size = new System.Drawing.Size(74, 13);
            this.Lbl_ErroTitulo.TabIndex = 9;
            this.Lbl_ErroTitulo.Text = "Digite o Título";
            this.Lbl_ErroTitulo.Visible = false;
            // 
            // Lbl_ErroPerguntaResposta
            // 
            this.Lbl_ErroPerguntaResposta.AutoSize = true;
            this.Lbl_ErroPerguntaResposta.ForeColor = System.Drawing.Color.Red;
            this.Lbl_ErroPerguntaResposta.Location = new System.Drawing.Point(104, 136);
            this.Lbl_ErroPerguntaResposta.Name = "Lbl_ErroPerguntaResposta";
            this.Lbl_ErroPerguntaResposta.Size = new System.Drawing.Size(88, 13);
            this.Lbl_ErroPerguntaResposta.TabIndex = 10;
            this.Lbl_ErroPerguntaResposta.Text = "Digite a pergunta";
            this.Lbl_ErroPerguntaResposta.Visible = false;
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "openFileDialog1";
            // 
            // Form_Add_Pergunta_Resposta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(557, 393);
            this.Controls.Add(this.Lbl_ErroPerguntaResposta);
            this.Controls.Add(this.Lbl_ErroTitulo);
            this.Controls.Add(this.Btn_Publicar);
            this.Controls.Add(this.Llb_AddImagem);
            this.Controls.Add(this.List_Imagem);
            this.Controls.Add(this.Txt_PerguntaResposta);
            this.Controls.Add(this.Lbl_Pergunta_Resposta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Titulo);
            this.Controls.Add(this.Panel_Superior);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Add_Pergunta_Resposta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Add_Pergunta_Resposta";
            this.Load += new System.EventHandler(this.Form_Add_Pergunta_Resposta_Load);
            this.Panel_Superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Fechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Superior;
        private System.Windows.Forms.TextBox Txt_Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Pergunta_Resposta;
        private System.Windows.Forms.TextBox Txt_PerguntaResposta;
        private System.Windows.Forms.ListBox List_Imagem;
        private System.Windows.Forms.LinkLabel Llb_AddImagem;
        private System.Windows.Forms.Button Btn_Publicar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_ErroTitulo;
        private System.Windows.Forms.Label Lbl_ErroPerguntaResposta;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.PictureBox Pb_Fechar;
    }
}