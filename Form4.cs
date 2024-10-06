using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void converter_Click(object sender, EventArgs e)
        {
            double cemtimetros = Convert.ToDouble(centimetros.Text);
            double resultado_em_polegadas = cemtimetros / 2.54;
            polegadas.Text = resultado_em_polegadas.ToString();
        }
    }
}
