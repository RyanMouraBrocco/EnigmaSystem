namespace EnigmaSystem
{
    partial class Form_Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cadastro));
            this.Panel_Superior = new System.Windows.Forms.Panel();
            this.Pb_Fechar = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Txt_Confirmar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Lbl_ErroNome = new System.Windows.Forms.Label();
            this.Lbl_ErroEmail = new System.Windows.Forms.Label();
            this.Lbl_ErroSenha = new System.Windows.Forms.Label();
            this.Lbl_ErroConfirmar = new System.Windows.Forms.Label();
            this.Btn_Cadastrar = new System.Windows.Forms.Button();
            this.Panel_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Superior
            // 
            this.Panel_Superior.Controls.Add(this.Pb_Fechar);
            this.Panel_Superior.Controls.Add(this.label9);
            this.Panel_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Superior.Location = new System.Drawing.Point(0, 0);
            this.Panel_Superior.Name = "Panel_Superior";
            this.Panel_Superior.Size = new System.Drawing.Size(619, 58);
            this.Panel_Superior.TabIndex = 0;
            // 
            // Pb_Fechar
            // 
            this.Pb_Fechar.Image = global::EnigmaSystem.Properties.Resources.x;
            this.Pb_Fechar.Location = new System.Drawing.Point(564, 4);
            this.Pb_Fechar.Name = "Pb_Fechar";
            this.Pb_Fechar.Size = new System.Drawing.Size(50, 50);
            this.Pb_Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_Fechar.TabIndex = 19;
            this.Pb_Fechar.TabStop = false;
            this.Pb_Fechar.Click += new System.EventHandler(this.Pb_Fechar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(223, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 37);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cadastrar";
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.BackColor = System.Drawing.Color.White;
            this.Txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nome.Location = new System.Drawing.Point(12, 97);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(594, 22);
            this.Txt_Nome.TabIndex = 1;
            // 
            // Txt_Email
            // 
            this.Txt_Email.BackColor = System.Drawing.Color.White;
            this.Txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Email.Location = new System.Drawing.Point(12, 154);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(594, 22);
            this.Txt_Email.TabIndex = 2;
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.BackColor = System.Drawing.Color.White;
            this.Txt_Senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Senha.Location = new System.Drawing.Point(12, 210);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PasswordChar = '*';
            this.Txt_Senha.Size = new System.Drawing.Size(289, 22);
            this.Txt_Senha.TabIndex = 3;
            // 
            // Txt_Confirmar
            // 
            this.Txt_Confirmar.BackColor = System.Drawing.Color.White;
            this.Txt_Confirmar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Confirmar.Location = new System.Drawing.Point(319, 210);
            this.Txt_Confirmar.Name = "Txt_Confirmar";
            this.Txt_Confirmar.PasswordChar = '*';
            this.Txt_Confirmar.Size = new System.Drawing.Size(289, 22);
            this.Txt_Confirmar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(315, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Confirmar Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(610, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "____________________________________________________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(610, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "____________________________________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "_____________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(315, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(300, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "_____________________________";
            // 
            // Lbl_ErroNome
            // 
            this.Lbl_ErroNome.AutoSize = true;
            this.Lbl_ErroNome.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_ErroNome.ForeColor = System.Drawing.Color.Red;
            this.Lbl_ErroNome.Location = new System.Drawing.Point(76, 81);
            this.Lbl_ErroNome.Name = "Lbl_ErroNome";
            this.Lbl_ErroNome.Size = new System.Drawing.Size(72, 13);
            this.Lbl_ErroNome.TabIndex = 15;
            this.Lbl_ErroNome.Text = "Digite o nome";
            this.Lbl_ErroNome.Visible = false;
            // 
            // Lbl_ErroEmail
            // 
            this.Lbl_ErroEmail.AutoSize = true;
            this.Lbl_ErroEmail.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_ErroEmail.ForeColor = System.Drawing.Color.Red;
            this.Lbl_ErroEmail.Location = new System.Drawing.Point(76, 135);
            this.Lbl_ErroEmail.Name = "Lbl_ErroEmail";
            this.Lbl_ErroEmail.Size = new System.Drawing.Size(70, 13);
            this.Lbl_ErroEmail.TabIndex = 16;
            this.Lbl_ErroEmail.Text = "Digite o email";
            this.Lbl_ErroEmail.Visible = false;
            // 
            // Lbl_ErroSenha
            // 
            this.Lbl_ErroSenha.AutoSize = true;
            this.Lbl_ErroSenha.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_ErroSenha.ForeColor = System.Drawing.Color.Red;
            this.Lbl_ErroSenha.Location = new System.Drawing.Point(76, 191);
            this.Lbl_ErroSenha.Name = "Lbl_ErroSenha";
            this.Lbl_ErroSenha.Size = new System.Drawing.Size(75, 13);
            this.Lbl_ErroSenha.TabIndex = 17;
            this.Lbl_ErroSenha.Text = "Digite a senha";
            this.Lbl_ErroSenha.Visible = false;
            // 
            // Lbl_ErroConfirmar
            // 
            this.Lbl_ErroConfirmar.AutoSize = true;
            this.Lbl_ErroConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_ErroConfirmar.ForeColor = System.Drawing.Color.Red;
            this.Lbl_ErroConfirmar.Location = new System.Drawing.Point(472, 191);
            this.Lbl_ErroConfirmar.Name = "Lbl_ErroConfirmar";
            this.Lbl_ErroConfirmar.Size = new System.Drawing.Size(115, 13);
            this.Lbl_ErroConfirmar.TabIndex = 18;
            this.Lbl_ErroConfirmar.Text = "Senhas não combinam";
            this.Lbl_ErroConfirmar.Visible = false;
            // 
            // Btn_Cadastrar
            // 
            this.Btn_Cadastrar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cadastrar.ForeColor = System.Drawing.Color.White;
            this.Btn_Cadastrar.Location = new System.Drawing.Point(428, 260);
            this.Btn_Cadastrar.Name = "Btn_Cadastrar";
            this.Btn_Cadastrar.Size = new System.Drawing.Size(180, 82);
            this.Btn_Cadastrar.TabIndex = 19;
            this.Btn_Cadastrar.Text = "Cadastrar-se";
            this.Btn_Cadastrar.UseVisualStyleBackColor = false;
            this.Btn_Cadastrar.Click += new System.EventHandler(this.Btn_Cadastrar_Click);
            this.Btn_Cadastrar.MouseEnter += new System.EventHandler(this.Btn_Cadastrar_MouseEnter);
            this.Btn_Cadastrar.MouseLeave += new System.EventHandler(this.Btn_Cadastrar_MouseLeave);
            // 
            // Form_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 354);
            this.Controls.Add(this.Btn_Cadastrar);
            this.Controls.Add(this.Lbl_ErroConfirmar);
            this.Controls.Add(this.Lbl_ErroSenha);
            this.Controls.Add(this.Lbl_ErroEmail);
            this.Controls.Add(this.Lbl_ErroNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Confirmar);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.Panel_Superior);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Cadastro";
            this.Load += new System.EventHandler(this.Form_Cadastro_Load);
            this.Panel_Superior.ResumeLayout(false);
            this.Panel_Superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Fechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Superior;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.TextBox Txt_Confirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Lbl_ErroNome;
        private System.Windows.Forms.Label Lbl_ErroEmail;
        private System.Windows.Forms.Label Lbl_ErroSenha;
        private System.Windows.Forms.Label Lbl_ErroConfirmar;
        private System.Windows.Forms.PictureBox Pb_Fechar;
        private System.Windows.Forms.Button Btn_Cadastrar;
    }
}