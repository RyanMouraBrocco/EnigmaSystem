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
    public partial class Form_Notas : Form
    {
        MateriaDAL dalmateria = new MateriaDAL();
        List<Materia> materias = new List<Materia>();
        List<Conteudo> conteudos = new List<Conteudo>();
        List<Exercicio> exercicios = new List<Exercicio>();
        List<Nota> notas = new List<Nota>();

        public Form_Notas()
        {
            InitializeComponent();
            try
            {
                materias = dalmateria.ConsultarTodos();
            }
            catch 
            {
                this.Close();
            }
           
        }

        void CarregarMaterias()
        {
            Grid_Materias.Rows.Clear();
            int linha = 0;
            foreach (var item in materias)
            {
                Grid_Materias.Rows.Add();
                Grid_Materias.Rows[linha].Cells[0].Value = item.Nome;
                linha += 1;
            }
        }
        void CarregarConteudos()
        {
            Grid_Conteudos.Rows.Clear();
            Grid_Exercicios.Rows.Clear();
            Grid_Notas.Rows.Clear();
            int linha = 0;
            foreach (var item in conteudos)
            {
                Grid_Conteudos.Rows.Add();
                Grid_Conteudos.Rows[linha].Cells[0].Value = item.Nome;
                Grid_Conteudos.Rows[linha].Cells[1].Value = item.ID;
                linha += 1;
            }
        }

        void CarregarExercicios()
        {
            Grid_Exercicios.Rows.Clear();
            Grid_Notas.Rows.Clear();
            int linha = 0;
            foreach (var item in exercicios)
            {
                Grid_Exercicios.Rows.Add();
                Grid_Exercicios.Rows[linha].Cells[0].Value = item.Descricao;
                Grid_Exercicios.Rows[linha].Cells[1].Value = item.ID;
                linha += 1;
            }
        }
        

        void CarregarNotas()
        {
            Grid_Notas.Rows.Clear();
            int linha = 0;
            foreach (var item in notas)
            {
                Grid_Notas.Rows.Add();
                Grid_Notas.Rows[linha].Cells[0].Value = item.Tentativa;
                Grid_Notas.Rows[linha].Cells[1].Value = item._Nota;
                linha += 1;
            }
        }

        private void Form_Notas_Load(object sender, EventArgs e)
        {
            Color cor = ColorTranslator.FromHtml("#000449");
            Grid_Materias.RowTemplate.DefaultCellStyle.BackColor = cor;
            Grid_Materias.RowTemplate.DefaultCellStyle.SelectionBackColor = cor;
            Grid_Conteudos.RowTemplate.DefaultCellStyle.BackColor = cor;
            Grid_Conteudos.RowTemplate.DefaultCellStyle.SelectionBackColor = cor;
            Grid_Exercicios.RowTemplate.DefaultCellStyle.BackColor = cor;
            Grid_Exercicios.RowTemplate.DefaultCellStyle.SelectionBackColor = cor;
            Grid_Notas.RowTemplate.DefaultCellStyle.BackColor = cor;
            Grid_Notas.RowTemplate.DefaultCellStyle.SelectionBackColor = cor;
            CarregarMaterias();
        }

        private void Grid_Materias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid_Materias.Rows.Count>0)
            {
                foreach (var item in materias.Where(x=>x.Nome == Grid_Materias.CurrentRow.Cells[0].Value.ToString()))
                {
                    try
                    {
                        Program.PanelCarregando.Visible = true;
                        Program.PanelCarregando.Refresh();
                        ConteudoDAL dal = new ConteudoDAL();
                        conteudos = dal.ConsultarPorMateria(item.ID);
                        CarregarConteudos();
                        Program.PanelCarregando.Visible = false;
                    }
                    catch 
                    {
                        MessageBox.Show("Erro de Conexão, tente novamente", "Enigma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Program.PanelCarregando.Visible = false;
                    }
                    
                }
            }
        }

        private void Grid_Conteudos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid_Conteudos.Rows.Count > 0)
            {
                foreach (var item in conteudos.Where(x => x.ID == Convert.ToInt32(Grid_Conteudos.CurrentRow.Cells[1].Value)))
                {
                    try
                    {
                        Program.PanelCarregando.Visible = true;
                        Program.PanelCarregando.Refresh();
                        ExercicioDAL dal = new ExercicioDAL();
                        exercicios = dal.ConsultarTodos(item.ID);
                        CarregarExercicios();
                        Program.PanelCarregando.Visible = false;
                    }
                    catch
                    {
                        MessageBox.Show("Erro de Conexão, tente novamente", "Enigma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Program.PanelCarregando.Visible = false;
                    }
                    
                }
            }
        }

        private void Grid_Exercicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid_Exercicios.Rows.Count > 0)
            {
                foreach (var item in exercicios.Where(x => x.ID == Convert.ToInt32(Grid_Exercicios.CurrentRow.Cells[1].Value)))
                {
                    try
                    {
                        Program.PanelCarregando.Visible = true;
                        Program.PanelCarregando.Refresh();
                        NotaDAL dal = new NotaDAL();
                        notas = dal.Consultar(UsuarioAtual.ID, item.ID);
                        CarregarNotas();
                        Program.PanelCarregando.Visible = false;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro de Conexão, tente novamente", "Enigma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Program.PanelCarregando.Visible = false;
                    }
                    
                }
            }
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Program.PanelMaterias.Visible = false;
            Program.PanelUsuario.Visible = false;
        }
    }
}
