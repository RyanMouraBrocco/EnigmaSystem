using EnigmaClass;
using EnigmaClass.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaSystem
{
    public partial class Form_Desempenho : Form
    {
        List<Materia> materias = new List<Materia>();
        public Form_Desempenho()
        {
            InitializeComponent();
        }

        private void Form_Desempenho_Load(object sender, EventArgs e)
        {
            Color cor = ColorTranslator.FromHtml("#000449");
            Grid_Materais.RowTemplate.DefaultCellStyle.BackColor = cor;
            Grid_Materais.RowTemplate.DefaultCellStyle.SelectionBackColor = cor;
            Grid_Materais.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            Grid_Materais.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            Panel_Superior.BackColor = cor;
            try
            {
                CarregarMaterias();
            }
            catch 
            {
                this.Close();
            }
            

        }
        void CarregarMaterias()
        {
            MateriaDAL dal = new MateriaDAL();
            materias = dal.ConsultarTodos();
            int linha = 0;
            foreach (var item in materias)
            {
                Grid_Materais.Rows.Add();
                Grid_Materais.Rows[linha].Cells[0].Value = item.Nome;
                linha += 1;
            }
        }

        private void Grid_Materais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (var item in materias.Where(x=>x.Nome == Grid_Materais.CurrentRow.Cells[0].Value.ToString()))
            {
                try
                {
                    DesempenhoDAL dal = new DesempenhoDAL();
                    Desempenho desempenho = dal.Consultar(item.ID, UsuarioAtual.ID);
                    Txt_Porcentagem.Text = (desempenho.Porcentagem * 100).ToString();
                    if (desempenho.Porcentagem < (decimal)0.5)
                    {
                        Txt_Porcentagem.ForeColor = Color.Red;
                    }
                    else
                    {
                        if (desempenho.Porcentagem >= (decimal)0.5 && desempenho.Porcentagem < (decimal)0.7)
                        {
                            Txt_Porcentagem.ForeColor = Color.Yellow;
                        }
                        else
                        {
                            Txt_Porcentagem.ForeColor = Color.Green;
                        }
                    }
                    int horas = (int)desempenho.HorasEstudadas;
                    int minutos = (int)((desempenho.HorasEstudadas - horas) * 60);
                    Lbl_Horas.Text = "Horas Estudadas = \nHoras: " + horas + " \nMinutos: " + minutos;
                    Lbl_Materia.Text = item.Nome;
                }
                catch 
                {
                    MessageBox.Show("Erro de Conexão, tente novamente", "Enigma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        Point Ponto = new Point();
        int x, y;

        private void Panel_Superior_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Ponto = MousePosition;
                Ponto.X -= x;
                Ponto.Y -= y;
                this.Location = Ponto;
                Application.DoEvents();
            }
        }

        private void Pb_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel_Superior_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }
    }
}
