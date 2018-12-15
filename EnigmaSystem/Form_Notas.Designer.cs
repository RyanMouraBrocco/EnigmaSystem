namespace EnigmaSystem
{
    partial class Form_Notas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Grid_Materias = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Grid_Conteudos = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Exercicios = new System.Windows.Forms.DataGridView();
            this.grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Notas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Materias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Conteudos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Exercicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Notas)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_Materias
            // 
            this.Grid_Materias.AllowUserToAddRows = false;
            this.Grid_Materias.AllowUserToDeleteRows = false;
            this.Grid_Materias.AllowUserToResizeColumns = false;
            this.Grid_Materias.AllowUserToResizeRows = false;
            this.Grid_Materias.BackgroundColor = System.Drawing.Color.White;
            this.Grid_Materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Materias.ColumnHeadersVisible = false;
            this.Grid_Materias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3});
            this.Grid_Materias.Location = new System.Drawing.Point(12, 80);
            this.Grid_Materias.MultiSelect = false;
            this.Grid_Materias.Name = "Grid_Materias";
            this.Grid_Materias.ReadOnly = true;
            this.Grid_Materias.RowHeadersVisible = false;
            this.Grid_Materias.RowTemplate.Height = 38;
            this.Grid_Materias.Size = new System.Drawing.Size(221, 412);
            this.Grid_Materias.TabIndex = 0;
            this.Grid_Materias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Materias_CellClick);
            this.Grid_Materias.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matérias";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // Grid_Conteudos
            // 
            this.Grid_Conteudos.AllowUserToAddRows = false;
            this.Grid_Conteudos.AllowUserToDeleteRows = false;
            this.Grid_Conteudos.AllowUserToResizeColumns = false;
            this.Grid_Conteudos.AllowUserToResizeRows = false;
            this.Grid_Conteudos.BackgroundColor = System.Drawing.Color.White;
            this.Grid_Conteudos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Conteudos.ColumnHeadersVisible = false;
            this.Grid_Conteudos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5});
            this.Grid_Conteudos.Location = new System.Drawing.Point(294, 80);
            this.Grid_Conteudos.MultiSelect = false;
            this.Grid_Conteudos.Name = "Grid_Conteudos";
            this.Grid_Conteudos.ReadOnly = true;
            this.Grid_Conteudos.RowHeadersVisible = false;
            this.Grid_Conteudos.RowTemplate.Height = 38;
            this.Grid_Conteudos.Size = new System.Drawing.Size(221, 412);
            this.Grid_Conteudos.TabIndex = 2;
            this.Grid_Conteudos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Conteudos_CellClick);
            this.Grid_Conteudos.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
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
            this.grid,
            this.Column6});
            this.Grid_Exercicios.Location = new System.Drawing.Point(580, 80);
            this.Grid_Exercicios.MultiSelect = false;
            this.Grid_Exercicios.Name = "Grid_Exercicios";
            this.Grid_Exercicios.ReadOnly = true;
            this.Grid_Exercicios.RowHeadersVisible = false;
            this.Grid_Exercicios.RowTemplate.Height = 38;
            this.Grid_Exercicios.Size = new System.Drawing.Size(221, 412);
            this.Grid_Exercicios.TabIndex = 3;
            this.Grid_Exercicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Exercicios_CellClick);
            // 
            // grid
            // 
            this.grid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid.HeaderText = "exercicios";
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Grid_Notas
            // 
            this.Grid_Notas.AllowUserToAddRows = false;
            this.Grid_Notas.AllowUserToDeleteRows = false;
            this.Grid_Notas.AllowUserToResizeColumns = false;
            this.Grid_Notas.AllowUserToResizeRows = false;
            this.Grid_Notas.BackgroundColor = System.Drawing.Color.White;
            this.Grid_Notas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Notas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.Grid_Notas.Location = new System.Drawing.Point(868, 80);
            this.Grid_Notas.MultiSelect = false;
            this.Grid_Notas.Name = "Grid_Notas";
            this.Grid_Notas.ReadOnly = true;
            this.Grid_Notas.RowHeadersVisible = false;
            this.Grid_Notas.RowTemplate.Height = 38;
            this.Grid_Notas.Size = new System.Drawing.Size(221, 412);
            this.Grid_Notas.TabIndex = 4;
            // 
            // Column1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column1.HeaderText = "Tentativa";
            this.Column1.MinimumWidth = 60;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column2.HeaderText = "Nota";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Conteúdos";
            this.label2.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(617, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Exercícios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(935, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Notas";
            // 
            // Form_Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 504);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grid_Notas);
            this.Controls.Add(this.Grid_Exercicios);
            this.Controls.Add(this.Grid_Conteudos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grid_Materias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Notas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Notas";
            this.Load += new System.EventHandler(this.Form_Notas_Load);
            this.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Materias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Conteudos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Exercicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Notas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_Materias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Grid_Conteudos;
        private System.Windows.Forms.DataGridView Grid_Exercicios;
        private System.Windows.Forms.DataGridView Grid_Notas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}