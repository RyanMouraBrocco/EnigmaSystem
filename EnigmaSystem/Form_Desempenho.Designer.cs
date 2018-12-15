namespace EnigmaSystem
{
    partial class Form_Desempenho
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
            this.Panel_Superior = new System.Windows.Forms.Panel();
            this.Pb_Fechar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_Materia = new System.Windows.Forms.Label();
            this.Lbl_Horas = new System.Windows.Forms.Label();
            this.Txt_Porcentagem = new System.Windows.Forms.TextBox();
            this.Grid_Materais = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Fechar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Materais)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Superior
            // 
            this.Panel_Superior.Controls.Add(this.Pb_Fechar);
            this.Panel_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Superior.Location = new System.Drawing.Point(0, 0);
            this.Panel_Superior.Name = "Panel_Superior";
            this.Panel_Superior.Size = new System.Drawing.Size(485, 55);
            this.Panel_Superior.TabIndex = 0;
            this.Panel_Superior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Superior_MouseDown);
            this.Panel_Superior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Superior_MouseMove);
            // 
            // Pb_Fechar
            // 
            this.Pb_Fechar.Image = global::EnigmaSystem.Properties.Resources.x;
            this.Pb_Fechar.Location = new System.Drawing.Point(435, 8);
            this.Pb_Fechar.Name = "Pb_Fechar";
            this.Pb_Fechar.Size = new System.Drawing.Size(41, 41);
            this.Pb_Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_Fechar.TabIndex = 0;
            this.Pb_Fechar.TabStop = false;
            this.Pb_Fechar.Click += new System.EventHandler(this.Pb_Fechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desempenho";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Lbl_Materia);
            this.panel2.Controls.Add(this.Lbl_Horas);
            this.panel2.Controls.Add(this.Txt_Porcentagem);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(193, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 157);
            this.panel2.TabIndex = 2;
            // 
            // Lbl_Materia
            // 
            this.Lbl_Materia.AutoSize = true;
            this.Lbl_Materia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Materia.Location = new System.Drawing.Point(134, 9);
            this.Lbl_Materia.Name = "Lbl_Materia";
            this.Lbl_Materia.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Materia.TabIndex = 4;
            // 
            // Lbl_Horas
            // 
            this.Lbl_Horas.AutoSize = true;
            this.Lbl_Horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Horas.Location = new System.Drawing.Point(12, 86);
            this.Lbl_Horas.Name = "Lbl_Horas";
            this.Lbl_Horas.Size = new System.Drawing.Size(0, 16);
            this.Lbl_Horas.TabIndex = 3;
            // 
            // Txt_Porcentagem
            // 
            this.Txt_Porcentagem.BackColor = System.Drawing.Color.Gainsboro;
            this.Txt_Porcentagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Porcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Porcentagem.Location = new System.Drawing.Point(3, 28);
            this.Txt_Porcentagem.Name = "Txt_Porcentagem";
            this.Txt_Porcentagem.ReadOnly = true;
            this.Txt_Porcentagem.Size = new System.Drawing.Size(273, 55);
            this.Txt_Porcentagem.TabIndex = 99;
            this.Txt_Porcentagem.TabStop = false;
            this.Txt_Porcentagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Grid_Materais
            // 
            this.Grid_Materais.AllowUserToAddRows = false;
            this.Grid_Materais.AllowUserToDeleteRows = false;
            this.Grid_Materais.AllowUserToResizeColumns = false;
            this.Grid_Materais.AllowUserToResizeRows = false;
            this.Grid_Materais.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Grid_Materais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Materais.ColumnHeadersVisible = false;
            this.Grid_Materais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.Grid_Materais.Location = new System.Drawing.Point(12, 62);
            this.Grid_Materais.Name = "Grid_Materais";
            this.Grid_Materais.ReadOnly = true;
            this.Grid_Materais.RowHeadersVisible = false;
            this.Grid_Materais.RowTemplate.Height = 26;
            this.Grid_Materais.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid_Materais.Size = new System.Drawing.Size(175, 157);
            this.Grid_Materais.TabIndex = 3;
            this.Grid_Materais.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Materais_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Materias";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Form_Desempenho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(485, 231);
            this.Controls.Add(this.Grid_Materais);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel_Superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Desempenho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Desempenho";
            this.Load += new System.EventHandler(this.Form_Desempenho_Load);
            this.Panel_Superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Fechar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Materais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Superior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Grid_Materais;
        private System.Windows.Forms.Label Lbl_Horas;
        private System.Windows.Forms.TextBox Txt_Porcentagem;
        private System.Windows.Forms.Label Lbl_Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.PictureBox Pb_Fechar;
    }
}