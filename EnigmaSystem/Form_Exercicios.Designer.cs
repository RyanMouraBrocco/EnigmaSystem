namespace EnigmaSystem
{
    partial class Form_Exercicios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Grid_Exercicios = new System.Windows.Forms.DataGridView();
            this.exercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel_Pergunta = new System.Windows.Forms.Panel();
            this.Panel_Respostas = new System.Windows.Forms.Panel();
            this.Lbl_Respostas = new System.Windows.Forms.Label();
            this.Btn_Proximo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Exercicios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exercícios";
            this.label1.MouseEnter += new System.EventHandler(this.Grid_Exercicios_MouseEnter);
            // 
            // Grid_Exercicios
            // 
            this.Grid_Exercicios.AllowUserToAddRows = false;
            this.Grid_Exercicios.AllowUserToDeleteRows = false;
            this.Grid_Exercicios.AllowUserToResizeColumns = false;
            this.Grid_Exercicios.AllowUserToResizeRows = false;
            this.Grid_Exercicios.BackgroundColor = System.Drawing.Color.White;
            this.Grid_Exercicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Exercicios.ColumnHeadersVisible = false;
            this.Grid_Exercicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exercicio,
            this.id});
            this.Grid_Exercicios.Location = new System.Drawing.Point(12, 76);
            this.Grid_Exercicios.MultiSelect = false;
            this.Grid_Exercicios.Name = "Grid_Exercicios";
            this.Grid_Exercicios.ReadOnly = true;
            this.Grid_Exercicios.RowHeadersVisible = false;
            this.Grid_Exercicios.RowTemplate.Height = 35;
            this.Grid_Exercicios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid_Exercicios.Size = new System.Drawing.Size(232, 416);
            this.Grid_Exercicios.TabIndex = 1;
            this.Grid_Exercicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Exercicios_CellClick);
            this.Grid_Exercicios.MouseEnter += new System.EventHandler(this.Grid_Exercicios_MouseEnter);
            // 
            // exercicio
            // 
            this.exercicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.exercicio.DefaultCellStyle = dataGridViewCellStyle2;
            this.exercicio.HeaderText = "exercicio";
            this.exercicio.Name = "exercicio";
            this.exercicio.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "Column1";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Panel_Pergunta
            // 
            this.Panel_Pergunta.AutoScroll = true;
            this.Panel_Pergunta.Location = new System.Drawing.Point(259, 44);
            this.Panel_Pergunta.Name = "Panel_Pergunta";
            this.Panel_Pergunta.Size = new System.Drawing.Size(830, 243);
            this.Panel_Pergunta.TabIndex = 2;
            this.Panel_Pergunta.MouseEnter += new System.EventHandler(this.Grid_Exercicios_MouseEnter);
            // 
            // Panel_Respostas
            // 
            this.Panel_Respostas.AutoScroll = true;
            this.Panel_Respostas.Location = new System.Drawing.Point(259, 318);
            this.Panel_Respostas.Name = "Panel_Respostas";
            this.Panel_Respostas.Size = new System.Drawing.Size(582, 174);
            this.Panel_Respostas.TabIndex = 3;
            this.Panel_Respostas.MouseEnter += new System.EventHandler(this.Grid_Exercicios_MouseEnter);
            // 
            // Lbl_Respostas
            // 
            this.Lbl_Respostas.AutoSize = true;
            this.Lbl_Respostas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Respostas.Location = new System.Drawing.Point(254, 290);
            this.Lbl_Respostas.Name = "Lbl_Respostas";
            this.Lbl_Respostas.Size = new System.Drawing.Size(114, 25);
            this.Lbl_Respostas.TabIndex = 0;
            this.Lbl_Respostas.Text = "Respostas";
            this.Lbl_Respostas.Visible = false;
            this.Lbl_Respostas.MouseEnter += new System.EventHandler(this.Grid_Exercicios_MouseEnter);
            // 
            // Btn_Proximo
            // 
            this.Btn_Proximo.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Proximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Proximo.ForeColor = System.Drawing.Color.White;
            this.Btn_Proximo.Location = new System.Drawing.Point(847, 374);
            this.Btn_Proximo.Name = "Btn_Proximo";
            this.Btn_Proximo.Size = new System.Drawing.Size(242, 118);
            this.Btn_Proximo.TabIndex = 20;
            this.Btn_Proximo.Text = "Próxima";
            this.Btn_Proximo.UseVisualStyleBackColor = false;
            this.Btn_Proximo.Visible = false;
            this.Btn_Proximo.Click += new System.EventHandler(this.Btn_Proximo_Click);
            this.Btn_Proximo.MouseEnter += new System.EventHandler(this.Btn_Proximo_MouseEnter);
            this.Btn_Proximo.MouseLeave += new System.EventHandler(this.Btn_Proximo_MouseLeave);
            // 
            // Form_Exercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 504);
            this.Controls.Add(this.Btn_Proximo);
            this.Controls.Add(this.Lbl_Respostas);
            this.Controls.Add(this.Panel_Respostas);
            this.Controls.Add(this.Panel_Pergunta);
            this.Controls.Add(this.Grid_Exercicios);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Exercicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Exercicios";
            this.Load += new System.EventHandler(this.Form_Exercicios_Load);
            this.MouseEnter += new System.EventHandler(this.Form_Exercicios_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Exercicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Grid_Exercicios;
        private System.Windows.Forms.Panel Panel_Pergunta;
        private System.Windows.Forms.Panel Panel_Respostas;
        private System.Windows.Forms.Label Lbl_Respostas;
        private System.Windows.Forms.DataGridViewTextBoxColumn exercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Button Btn_Proximo;
    }
}