namespace EnigmaSystem
{
    partial class Form_Conteudo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Grid_Conteudo = new System.Windows.Forms.DataGridView();
            this.Conteudos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_View = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Grid_Resumos = new System.Windows.Forms.DataGridView();
            this.Resumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Exercicios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Conteudo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Resumos)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_Conteudo
            // 
            this.Grid_Conteudo.AllowUserToAddRows = false;
            this.Grid_Conteudo.AllowUserToDeleteRows = false;
            this.Grid_Conteudo.AllowUserToResizeColumns = false;
            this.Grid_Conteudo.AllowUserToResizeRows = false;
            this.Grid_Conteudo.BackgroundColor = System.Drawing.Color.White;
            this.Grid_Conteudo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_Conteudo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Conteudo.ColumnHeadersVisible = false;
            this.Grid_Conteudo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Conteudos,
            this.ID});
            this.Grid_Conteudo.Location = new System.Drawing.Point(12, 65);
            this.Grid_Conteudo.MultiSelect = false;
            this.Grid_Conteudo.Name = "Grid_Conteudo";
            this.Grid_Conteudo.ReadOnly = true;
            this.Grid_Conteudo.RowHeadersVisible = false;
            this.Grid_Conteudo.RowTemplate.Height = 80;
            this.Grid_Conteudo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid_Conteudo.Size = new System.Drawing.Size(246, 427);
            this.Grid_Conteudo.TabIndex = 0;
            this.Grid_Conteudo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Conteudo_CellClick);
            this.Grid_Conteudo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Conteudo_CellContentClick);
            this.Grid_Conteudo.MouseEnter += new System.EventHandler(this.Grid_Conteudo_MouseEnter);
            // 
            // Conteudos
            // 
            this.Conteudos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            this.Conteudos.DefaultCellStyle = dataGridViewCellStyle1;
            this.Conteudos.HeaderText = "conteudos";
            this.Conteudos.Name = "Conteudos";
            this.Conteudos.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conteúdos";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // Panel_View
            // 
            this.Panel_View.AutoScroll = true;
            this.Panel_View.Location = new System.Drawing.Point(264, 33);
            this.Panel_View.Name = "Panel_View";
            this.Panel_View.Size = new System.Drawing.Size(634, 459);
            this.Panel_View.TabIndex = 2;
            this.Panel_View.MouseEnter += new System.EventHandler(this.Panel_View_MouseEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(936, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resumos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Grid_Resumos);
            this.groupBox1.Location = new System.Drawing.Point(904, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 339);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // Grid_Resumos
            // 
            this.Grid_Resumos.AllowUserToAddRows = false;
            this.Grid_Resumos.AllowUserToDeleteRows = false;
            this.Grid_Resumos.AllowUserToResizeColumns = false;
            this.Grid_Resumos.AllowUserToResizeRows = false;
            this.Grid_Resumos.BackgroundColor = System.Drawing.Color.White;
            this.Grid_Resumos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_Resumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Resumos.ColumnHeadersVisible = false;
            this.Grid_Resumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Resumo,
            this.Codigo});
            this.Grid_Resumos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_Resumos.Location = new System.Drawing.Point(3, 16);
            this.Grid_Resumos.MultiSelect = false;
            this.Grid_Resumos.Name = "Grid_Resumos";
            this.Grid_Resumos.ReadOnly = true;
            this.Grid_Resumos.RowHeadersVisible = false;
            this.Grid_Resumos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Grid_Resumos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid_Resumos.RowTemplate.Height = 32;
            this.Grid_Resumos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid_Resumos.Size = new System.Drawing.Size(179, 320);
            this.Grid_Resumos.TabIndex = 0;
            this.Grid_Resumos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Resumos_CellClick);
            // 
            // Resumo
            // 
            this.Resumo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.Resumo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Resumo.HeaderText = "Resumo";
            this.Resumo.Name = "Resumo";
            this.Resumo.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // Btn_Exercicios
            // 
            this.Btn_Exercicios.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Exercicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exercicios.ForeColor = System.Drawing.Color.White;
            this.Btn_Exercicios.Location = new System.Drawing.Point(909, 410);
            this.Btn_Exercicios.Name = "Btn_Exercicios";
            this.Btn_Exercicios.Size = new System.Drawing.Size(180, 82);
            this.Btn_Exercicios.TabIndex = 20;
            this.Btn_Exercicios.Text = "Exercícios";
            this.Btn_Exercicios.UseVisualStyleBackColor = false;
            this.Btn_Exercicios.Click += new System.EventHandler(this.Btn_Exercicios_Click);
            this.Btn_Exercicios.MouseEnter += new System.EventHandler(this.Btn_Exercicios_MouseEnter);
            this.Btn_Exercicios.MouseLeave += new System.EventHandler(this.Btn_Exercicios_MouseLeave);
            // 
            // Form_Conteudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 504);
            this.Controls.Add(this.Btn_Exercicios);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Panel_View);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grid_Conteudo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Conteudo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Conteudo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Conteudo_FormClosed);
            this.Load += new System.EventHandler(this.Form_Conteudo_Load);
            this.MouseEnter += new System.EventHandler(this.Form_Conteudo_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Conteudo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Resumos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_Conteudo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conteudos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Panel Panel_View;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Grid_Resumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.Button Btn_Exercicios;
    }
}