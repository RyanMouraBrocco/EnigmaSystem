namespace EnigmaSystem
{
    partial class Form_Perfil
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
            this.Pb_Foto = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbl_ErroEmail = new System.Windows.Forms.Label();
            this.Lbl_ErroNome = new System.Windows.Forms.Label();
            this.Btn_Senha = new System.Windows.Forms.Button();
            this.Gb_Senha = new System.Windows.Forms.GroupBox();
            this.Lbl_ErroConfirmar = new System.Windows.Forms.Label();
            this.Lbl_ErroSenha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_ConfirmarSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Btn_Alterar = new System.Windows.Forms.Button();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Foto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Gb_Senha.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pb_Foto
            // 
            this.Pb_Foto.Location = new System.Drawing.Point(30, 66);
            this.Pb_Foto.Name = "Pb_Foto";
            this.Pb_Foto.Size = new System.Drawing.Size(252, 163);
            this.Pb_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_Foto.TabIndex = 0;
            this.Pb_Foto.TabStop = false;
            this.Pb_Foto.MouseEnter += new System.EventHandler(this.Form_Perfil_MouseEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbl_ErroEmail);
            this.groupBox1.Controls.Add(this.Lbl_ErroNome);
            this.groupBox1.Controls.Add(this.Btn_Senha);
            this.groupBox1.Controls.Add(this.Gb_Senha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txt_Email);
            this.groupBox1.Controls.Add(this.Txt_Nome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(310, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 446);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perfil";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Lbl_ErroEmail
            // 
            this.Lbl_ErroEmail.AutoSize = true;
            this.Lbl_ErroEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ErroEmail.ForeColor = System.Drawing.Color.Red;
            this.Lbl_ErroEmail.Location = new System.Drawing.Point(81, 108);
            this.Lbl_ErroEmail.Name = "Lbl_ErroEmail";
            this.Lbl_ErroEmail.Size = new System.Drawing.Size(90, 16);
            this.Lbl_ErroEmail.TabIndex = 8;
            this.Lbl_ErroEmail.Text = "Digite o email";
            this.Lbl_ErroEmail.Visible = false;
            // 
            // Lbl_ErroNome
            // 
            this.Lbl_ErroNome.AutoSize = true;
            this.Lbl_ErroNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ErroNome.ForeColor = System.Drawing.Color.Red;
            this.Lbl_ErroNome.Location = new System.Drawing.Point(81, 38);
            this.Lbl_ErroNome.Name = "Lbl_ErroNome";
            this.Lbl_ErroNome.Size = new System.Drawing.Size(91, 16);
            this.Lbl_ErroNome.TabIndex = 7;
            this.Lbl_ErroNome.Text = "Digite o nome";
            this.Lbl_ErroNome.Visible = false;
            // 
            // Btn_Senha
            // 
            this.Btn_Senha.BackColor = System.Drawing.Color.Navy;
            this.Btn_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Senha.ForeColor = System.Drawing.Color.White;
            this.Btn_Senha.Location = new System.Drawing.Point(28, 178);
            this.Btn_Senha.Name = "Btn_Senha";
            this.Btn_Senha.Size = new System.Drawing.Size(164, 46);
            this.Btn_Senha.TabIndex = 4;
            this.Btn_Senha.Text = "Alterar Senha";
            this.Btn_Senha.UseVisualStyleBackColor = false;
            this.Btn_Senha.Click += new System.EventHandler(this.Btn_Senha_Click);
            this.Btn_Senha.MouseEnter += new System.EventHandler(this.Form_Senha_MouseEnter);
            this.Btn_Senha.MouseLeave += new System.EventHandler(this.Btn_Senha_MouseLeave);
            // 
            // Gb_Senha
            // 
            this.Gb_Senha.Controls.Add(this.Lbl_ErroConfirmar);
            this.Gb_Senha.Controls.Add(this.Lbl_ErroSenha);
            this.Gb_Senha.Controls.Add(this.label4);
            this.Gb_Senha.Controls.Add(this.Txt_ConfirmarSenha);
            this.Gb_Senha.Controls.Add(this.label3);
            this.Gb_Senha.Controls.Add(this.Txt_Senha);
            this.Gb_Senha.Location = new System.Drawing.Point(124, 262);
            this.Gb_Senha.Name = "Gb_Senha";
            this.Gb_Senha.Size = new System.Drawing.Size(319, 140);
            this.Gb_Senha.TabIndex = 6;
            this.Gb_Senha.TabStop = false;
            this.Gb_Senha.Text = "Alterar Senha";
            this.Gb_Senha.Visible = false;
            // 
            // Lbl_ErroConfirmar
            // 
            this.Lbl_ErroConfirmar.AutoSize = true;
            this.Lbl_ErroConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ErroConfirmar.ForeColor = System.Drawing.Color.Red;
            this.Lbl_ErroConfirmar.Location = new System.Drawing.Point(145, 78);
            this.Lbl_ErroConfirmar.Name = "Lbl_ErroConfirmar";
            this.Lbl_ErroConfirmar.Size = new System.Drawing.Size(146, 16);
            this.Lbl_ErroConfirmar.TabIndex = 10;
            this.Lbl_ErroConfirmar.Text = "Senhas não combinam";
            this.Lbl_ErroConfirmar.Visible = false;
            // 
            // Lbl_ErroSenha
            // 
            this.Lbl_ErroSenha.AutoSize = true;
            this.Lbl_ErroSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ErroSenha.ForeColor = System.Drawing.Color.Red;
            this.Lbl_ErroSenha.Location = new System.Drawing.Point(72, 26);
            this.Lbl_ErroSenha.Name = "Lbl_ErroSenha";
            this.Lbl_ErroSenha.Size = new System.Drawing.Size(94, 16);
            this.Lbl_ErroSenha.TabIndex = 9;
            this.Lbl_ErroSenha.Text = "Digite a senha";
            this.Lbl_ErroSenha.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirmar Senha";
            // 
            // Txt_ConfirmarSenha
            // 
            this.Txt_ConfirmarSenha.Location = new System.Drawing.Point(14, 97);
            this.Txt_ConfirmarSenha.Name = "Txt_ConfirmarSenha";
            this.Txt_ConfirmarSenha.PasswordChar = '*';
            this.Txt_ConfirmarSenha.Size = new System.Drawing.Size(289, 26);
            this.Txt_ConfirmarSenha.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha";
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Location = new System.Drawing.Point(14, 45);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PasswordChar = '*';
            this.Txt_Senha.Size = new System.Drawing.Size(289, 26);
            this.Txt_Senha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            this.label2.MouseEnter += new System.EventHandler(this.Form_Perfil_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            this.label1.MouseEnter += new System.EventHandler(this.Form_Perfil_MouseEnter);
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(28, 127);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(526, 26);
            this.Txt_Email.TabIndex = 1;
            this.Txt_Email.MouseEnter += new System.EventHandler(this.Form_Perfil_MouseEnter);
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(28, 57);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(526, 26);
            this.Txt_Nome.TabIndex = 0;
            this.Txt_Nome.MouseEnter += new System.EventHandler(this.Form_Perfil_MouseEnter);
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn_Salvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Salvar.FlatAppearance.BorderSize = 6666;
            this.Btn_Salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salvar.ForeColor = System.Drawing.Color.White;
            this.Btn_Salvar.Location = new System.Drawing.Point(890, 416);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(199, 87);
            this.Btn_Salvar.TabIndex = 2;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = false;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            this.Btn_Salvar.MouseEnter += new System.EventHandler(this.Btn_Salvar_MouseEnter);
            this.Btn_Salvar.MouseLeave += new System.EventHandler(this.Btn_Salvar_MouseLeave);
            // 
            // Btn_Alterar
            // 
            this.Btn_Alterar.BackColor = System.Drawing.Color.Navy;
            this.Btn_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Alterar.ForeColor = System.Drawing.Color.White;
            this.Btn_Alterar.Location = new System.Drawing.Point(73, 235);
            this.Btn_Alterar.Name = "Btn_Alterar";
            this.Btn_Alterar.Size = new System.Drawing.Size(164, 46);
            this.Btn_Alterar.TabIndex = 3;
            this.Btn_Alterar.Text = "Alterar Imagem";
            this.Btn_Alterar.UseVisualStyleBackColor = false;
            this.Btn_Alterar.Click += new System.EventHandler(this.Btn_Alterar_Click);
            this.Btn_Alterar.MouseEnter += new System.EventHandler(this.Form_AlterarImagem_MouseEnter);
            this.Btn_Alterar.MouseLeave += new System.EventHandler(this.Btn_Alterar_MouseLeave);
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "openFileDialog1";
            // 
            // Form_Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 504);
            this.Controls.Add(this.Btn_Alterar);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Pb_Foto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Perfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Perfil";
            this.Load += new System.EventHandler(this.Form_Perfil_Load);
            this.MouseEnter += new System.EventHandler(this.Form_Perfil_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Foto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Gb_Senha.ResumeLayout(false);
            this.Gb_Senha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb_Foto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.Button Btn_Alterar;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.Button Btn_Senha;
        private System.Windows.Forms.GroupBox Gb_Senha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_ConfirmarSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_ErroEmail;
        private System.Windows.Forms.Label Lbl_ErroNome;
        private System.Windows.Forms.Label Lbl_ErroConfirmar;
        private System.Windows.Forms.Label Lbl_ErroSenha;
    }
}