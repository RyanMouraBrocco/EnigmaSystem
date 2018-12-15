namespace EnigmaSystem
{
    partial class Form_Forum
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Grid_Perguntas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Pesquisa = new System.Windows.Forms.TextBox();
            this.Panel_View = new System.Windows.Forms.Panel();
            this.Btn_NovaPergunta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Perguntas)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_Perguntas
            // 
            this.Grid_Perguntas.AllowUserToAddRows = false;
            this.Grid_Perguntas.AllowUserToDeleteRows = false;
            this.Grid_Perguntas.AllowUserToResizeColumns = false;
            this.Grid_Perguntas.AllowUserToResizeRows = false;
            this.Grid_Perguntas.BackgroundColor = System.Drawing.Color.White;
            this.Grid_Perguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Perguntas.ColumnHeadersVisible = false;
            this.Grid_Perguntas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.Grid_Perguntas.Location = new System.Drawing.Point(12, 104);
            this.Grid_Perguntas.MultiSelect = false;
            this.Grid_Perguntas.Name = "Grid_Perguntas";
            this.Grid_Perguntas.ReadOnly = true;
            this.Grid_Perguntas.RowHeadersVisible = false;
            this.Grid_Perguntas.RowTemplate.Height = 35;
            this.Grid_Perguntas.RowTemplate.ReadOnly = true;
            this.Grid_Perguntas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Perguntas.Size = new System.Drawing.Size(254, 345);
            this.Grid_Perguntas.TabIndex = 0;
            this.Grid_Perguntas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Perguntas_CellClick);
            this.Grid_Perguntas.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Perguntas";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // Txt_Pesquisa
            // 
            this.Txt_Pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Pesquisa.Location = new System.Drawing.Point(12, 74);
            this.Txt_Pesquisa.Name = "Txt_Pesquisa";
            this.Txt_Pesquisa.Size = new System.Drawing.Size(254, 24);
            this.Txt_Pesquisa.TabIndex = 2;
            this.Txt_Pesquisa.TextChanged += new System.EventHandler(this.Txt_Pesquisa_TextChanged);
            this.Txt_Pesquisa.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // Panel_View
            // 
            this.Panel_View.AutoScroll = true;
            this.Panel_View.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_View.Location = new System.Drawing.Point(272, 28);
            this.Panel_View.Name = "Panel_View";
            this.Panel_View.Size = new System.Drawing.Size(817, 464);
            this.Panel_View.TabIndex = 3;
            this.Panel_View.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // Btn_NovaPergunta
            // 
            this.Btn_NovaPergunta.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn_NovaPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NovaPergunta.ForeColor = System.Drawing.Color.White;
            this.Btn_NovaPergunta.Location = new System.Drawing.Point(12, 455);
            this.Btn_NovaPergunta.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_NovaPergunta.Name = "Btn_NovaPergunta";
            this.Btn_NovaPergunta.Size = new System.Drawing.Size(254, 37);
            this.Btn_NovaPergunta.TabIndex = 4;
            this.Btn_NovaPergunta.Text = "Nova Pergunta";
            this.Btn_NovaPergunta.UseVisualStyleBackColor = false;
            this.Btn_NovaPergunta.Click += new System.EventHandler(this.Btn_NovaPergunta_Click_1);
            this.Btn_NovaPergunta.MouseEnter += new System.EventHandler(this.Btn_NovaPergunta_MouseEnter);
            this.Btn_NovaPergunta.MouseLeave += new System.EventHandler(this.Btn_NovaPergunta_MouseLeave);
            // 
            // Form_Forum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 504);
            this.Controls.Add(this.Btn_NovaPergunta);
            this.Controls.Add(this.Panel_View);
            this.Controls.Add(this.Txt_Pesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grid_Perguntas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Forum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Forum";
            this.Load += new System.EventHandler(this.Form_Forum_Load);
            this.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Perguntas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_Perguntas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Pesquisa;
        private System.Windows.Forms.Panel Panel_View;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button Btn_NovaPergunta;
    }
}