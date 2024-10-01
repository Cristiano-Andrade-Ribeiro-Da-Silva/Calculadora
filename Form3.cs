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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void converter_Click(object sender, EventArgs e)
        {
            double celsius = Convert.ToDouble(convert_celsius.Text);
            double resultado = celsius * 1.8 + 32;
            Fahrenheit.Text = resultado.ToString();

        }
    }
}
