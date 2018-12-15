namespace EnigmaSystem
{
    partial class Form_MinhasPerguntasRespostas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MinhasPerguntasRespostas));
            this.Grid_Perguntas = new System.Windows.Forms.DataGridView();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpergunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_PerguntaResposta = new System.Windows.Forms.Label();
            this.Lbl_Numeros_Denucias = new System.Windows.Forms.Label();
            this.Lbl_Numeros_Dislikes = new System.Windows.Forms.Label();
            this.Lbl_Likes = new System.Windows.Forms.Label();
            this.CB_Visivel = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Panel_Superior = new System.Windows.Forms.Panel();
            this.Pb_fechar = new System.Windows.Forms.PictureBox();
            this.Grid_Respostas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Perguntas)).BeginInit();
            this.panel1.SuspendLayout();
            this.Panel_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Respostas)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_Perguntas
            // 
            this.Grid_Perguntas.AllowUserToAddRows = false;
            this.Grid_Perguntas.AllowUserToDeleteRows = false;
            this.Grid_Perguntas.AllowUserToResizeColumns = false;
            this.Grid_Perguntas.AllowUserToResizeRows = false;
            this.Grid_Perguntas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Grid_Perguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Perguntas.ColumnHeadersVisible = false;
            this.Grid_Perguntas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P,
            this.idpergunta});
            this.Grid_Perguntas.Location = new System.Drawing.Point(12, 81);
            this.Grid_Perguntas.MultiSelect = false;
            this.Grid_Perguntas.Name = "Grid_Perguntas";
            this.Grid_Perguntas.ReadOnly = true;
            this.Grid_Perguntas.RowHeadersVisible = false;
            this.Grid_Perguntas.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Grid_Perguntas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid_Perguntas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Transparent;
            this.Grid_Perguntas.RowTemplate.Height = 30;
            this.Grid_Perguntas.RowTemplate.ReadOnly = true;
            this.Grid_Perguntas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid_Perguntas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Perguntas.Size = new System.Drawing.Size(240, 90);
            this.Grid_Perguntas.TabIndex = 0;
            this.Grid_Perguntas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Perguntas_CellClick);
            // 
            // P
            // 
            this.P.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.P.DefaultCellStyle = dataGridViewCellStyle1;
            this.P.HeaderText = "Perguntas";
            this.P.Name = "P";
            this.P.ReadOnly = true;
            // 
            // idpergunta
            // 
            this.idpergunta.HeaderText = "id";
            this.idpergunta.Name = "idpergunta";
            this.idpergunta.ReadOnly = true;
            this.idpergunta.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Perguntas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Respostas";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Lbl_PerguntaResposta);
            this.panel1.Controls.Add(this.Lbl_Numeros_Denucias);
            this.panel1.Controls.Add(this.Lbl_Numeros_Dislikes);
            this.panel1.Controls.Add(this.Lbl_Likes);
            this.panel1.Controls.Add(this.CB_Visivel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(258, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 210);
            this.panel1.TabIndex = 4;
            // 
            // Lbl_PerguntaResposta
            // 
            this.Lbl_PerguntaResposta.AutoSize = true;
            this.Lbl_PerguntaResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PerguntaResposta.Location = new System.Drawing.Point(17, 11);
            this.Lbl_PerguntaResposta.MaximumSize = new System.Drawing.Size(300, 0);
            this.Lbl_PerguntaResposta.Name = "Lbl_PerguntaResposta";
            this.Lbl_PerguntaResposta.Size = new System.Drawing.Size(0, 20);
            this.Lbl_PerguntaResposta.TabIndex = 7;
            // 
            // Lbl_Numeros_Denucias
            // 
            this.Lbl_Numeros_Denucias.AutoSize = true;
            this.Lbl_Numeros_Denucias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Numeros_Denucias.Location = new System.Drawing.Point(106, 152);
            this.Lbl_Numeros_Denucias.Name = "Lbl_Numeros_Denucias";
            this.Lbl_Numeros_Denucias.Size = new System.Drawing.Size(20, 24);
            this.Lbl_Numeros_Denucias.TabIndex = 6;
            this.Lbl_Numeros_Denucias.Text = "0";
            // 
            // Lbl_Numeros_Dislikes
            // 
            this.Lbl_Numeros_Dislikes.AutoSize = true;
            this.Lbl_Numeros_Dislikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Numeros_Dislikes.Location = new System.Drawing.Point(89, 106);
            this.Lbl_Numeros_Dislikes.Name = "Lbl_Numeros_Dislikes";
            this.Lbl_Numeros_Dislikes.Size = new System.Drawing.Size(20, 24);
            this.Lbl_Numeros_Dislikes.TabIndex = 5;
            this.Lbl_Numeros_Dislikes.Text = "0";
            // 
            // Lbl_Likes
            // 
            this.Lbl_Likes.AutoSize = true;
            this.Lbl_Likes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Likes.Location = new System.Drawing.Point(73, 64);
            this.Lbl_Likes.Name = "Lbl_Likes";
            this.Lbl_Likes.Size = new System.Drawing.Size(20, 24);
            this.Lbl_Likes.TabIndex = 4;
            this.Lbl_Likes.Text = "0";
            // 
            // CB_Visivel
            // 
            this.CB_Visivel.AutoSize = true;
            this.CB_Visivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Visivel.Location = new System.Drawing.Point(292, 169);
            this.CB_Visivel.Name = "CB_Visivel";
            this.CB_Visivel.Size = new System.Drawing.Size(83, 28);
            this.CB_Visivel.TabIndex = 3;
            this.CB_Visivel.Text = "Visível";
            this.CB_Visivel.UseVisualStyleBackColor = true;
            this.CB_Visivel.Visible = false;
            this.CB_Visivel.CheckedChanged += new System.EventHandler(this.CB_Visivel_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Denúcias:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dislikes:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Likes:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-37, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(590, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "__________________________________________________________";
            // 
            // Panel_Superior
            // 
            this.Panel_Superior.Controls.Add(this.Pb_fechar);
            this.Panel_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Superior.Location = new System.Drawing.Point(0, 0);
            this.Panel_Superior.Name = "Panel_Superior";
            this.Panel_Superior.Size = new System.Drawing.Size(661, 51);
            this.Panel_Superior.TabIndex = 5;
            this.Panel_Superior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Superior_MouseDown_1);
            this.Panel_Superior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Superior_MouseMove);
            // 
            // Pb_fechar
            // 
            this.Pb_fechar.Image = global::EnigmaSystem.Properties.Resources.x;
            this.Pb_fechar.Location = new System.Drawing.Point(616, 5);
            this.Pb_fechar.Name = "Pb_fechar";
            this.Pb_fechar.Size = new System.Drawing.Size(38, 42);
            this.Pb_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_fechar.TabIndex = 0;
            this.Pb_fechar.TabStop = false;
            this.Pb_fechar.Click += new System.EventHandler(this.Pb_fechar_Click);
            // 
            // Grid_Respostas
            // 
            this.Grid_Respostas.AllowUserToAddRows = false;
            this.Grid_Respostas.AllowUserToDeleteRows = false;
            this.Grid_Respostas.AllowUserToResizeColumns = false;
            this.Grid_Respostas.AllowUserToResizeRows = false;
            this.Grid_Respostas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Grid_Respostas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Respostas.ColumnHeadersVisible = false;
            this.Grid_Respostas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.Grid_Respostas.Location = new System.Drawing.Point(12, 201);
            this.Grid_Respostas.MultiSelect = false;
            this.Grid_Respostas.Name = "Grid_Respostas";
            this.Grid_Respostas.ReadOnly = true;
            this.Grid_Respostas.RowHeadersVisible = false;
            this.Grid_Respostas.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Grid_Respostas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid_Respostas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Transparent;
            this.Grid_Respostas.RowTemplate.Height = 30;
            this.Grid_Respostas.RowTemplate.ReadOnly = true;
            this.Grid_Respostas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid_Respostas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Respostas.Size = new System.Drawing.Size(240, 90);
            this.Grid_Respostas.TabIndex = 6;
            this.Grid_Respostas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Respostas_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "Perguntas";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // Form_MinhasPerguntasRespostas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(661, 303);
            this.Controls.Add(this.Grid_Respostas);
            this.Controls.Add(this.Panel_Superior);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grid_Perguntas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_MinhasPerguntasRespostas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_MinhasPerguntasRespostas";
            this.Load += new System.EventHandler(this.Form_MinhasPerguntasRespostas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Perguntas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Panel_Superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Respostas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_Perguntas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Panel_Superior;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CB_Visivel;
        private System.Windows.Forms.Label Lbl_Numeros_Denucias;
        private System.Windows.Forms.Label Lbl_Numeros_Dislikes;
        private System.Windows.Forms.Label Lbl_Likes;
        private System.Windows.Forms.DataGridView Grid_Respostas;
        private System.Windows.Forms.DataGridViewTextBoxColumn P;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpergunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label Lbl_PerguntaResposta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox Pb_fechar;
    }
}