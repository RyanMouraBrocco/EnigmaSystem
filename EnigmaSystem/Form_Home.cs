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
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }

        private void Form_Home_MouseEnter(object sender, EventArgs e)
        {
            Program.PanelUsuario.Visible = false;
            Program.PanelMaterias.Visible = false;
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {
            Lbl_introducao.Text = "O melhor sistema para apredizagem de especialização em informática, \nabrangendo todos os temas desde a manipulação de dados até sua exibição \nVenha Descobrir esse Enigma !!!!!!";
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Program.PanelUsuario.Visible = false;
            Program.PanelMaterias.Visible = false;
        }
    }
}
