using EnigmaClass;
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
    public partial class Form_ExibirNota : Form
    {
        public Form_ExibirNota(Nota nota)
        {
            InitializeComponent();
            Txt_Nota.Text = nota._Nota.ToString();
            if (nota._Nota<5)
            {
                Txt_Nota.ForeColor = Color.Red;
                Txt_Texto.ForeColor = Color.Red;
                Txt_Texto.Text = "Continue estudando, você consegue !!";
            }
            else
            {
                if (nota._Nota>=5 && nota._Nota <7)
                {
                    Txt_Nota.ForeColor = Color.Yellow;
                    Txt_Texto.ForeColor = Color.Yellow;
                    Txt_Texto.Text = "Mais um pouco, vamos lá !!";
                }
                else
                {
                    Txt_Nota.ForeColor = Color.Green;
                    Txt_Texto.ForeColor = Color.Green;
                    Txt_Texto.Text = "Parabéns, bela nota !!";
                }
            }
            tempo.Enabled = true;
        }

        private void Form_ExibirNota_Load(object sender, EventArgs e)
        {
            Color cor = ColorTranslator.FromHtml("#00058d");
            panel1.BackColor = cor;
        }

        private void tempo_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
