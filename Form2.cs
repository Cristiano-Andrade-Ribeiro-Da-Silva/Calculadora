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
    public partial class Calculadora : Form
    {
        float valor_01 = 0;
        string operacao = "";

        public Calculadora()
        {
            InitializeComponent();
        }

        private void calculadora_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calculadora_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void celsius_para_fahrenheit_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();

        }

        private void botao_00_Click(object sender, EventArgs e)
        {
            resultado.Text += "0";
        }

        private void botao_01_Click(object sender, EventArgs e)
        {
            resultado.Text += "1";
        }

        private void botao_02_Click(object sender, EventArgs e)
        {
            resultado.Text += "2";
        }

        private void botao_03_Click(object sender, EventArgs e)
        {
            resultado.Text += "3";
        }

        private void botao_04_Click(object sender, EventArgs e)
        {
            resultado.Text += "4";
        }

        private void botao_05_Click(object sender, EventArgs e)
        {
            resultado.Text += "5";
        }

        private void botao_06_Click(object sender, EventArgs e)
        {
            resultado.Text += "6";
        }

        private void botao_07_Click(object sender, EventArgs e)
        {
            resultado.Text += "7";
        }

        private void botao_08_Click(object sender, EventArgs e)
        {
            resultado.Text += "8";
        }

        private void botao_09_Click(object sender, EventArgs e)
        {
            resultado.Text += "9";
        }

        private void botao_soma_Click(object sender, EventArgs e)
        {
            valor_01 = Convert.ToSingle(resultado.Text);
            operacao = "+";
            resultado.Text = "";

        }

        private void botao_subtração_Click(object sender, EventArgs e)
        {
            valor_01 = Convert.ToSingle(resultado.Text);
            operacao = "-";
            resultado.Text = "";
        }

        private void botao_multiplicação_Click(object sender, EventArgs e)
        {
            valor_01 = Convert.ToSingle(resultado.Text);
            operacao = "x";
            resultado.Text = "";
        }

        private void botao_divisão_Click(object sender, EventArgs e)
        {
            valor_01 = Convert.ToSingle(resultado.Text);
            operacao = "-:-";
            resultado.Text = "";
        }

        private void botao_igual_Click(object sender, EventArgs e)
        {
            if (this.operacao == "+")
            {
                float total = valor_01 + Convert.ToSingle(resultado.Text);
                resultado.Text = total.ToString();

            }
            if (this.operacao == "-")
            {
                float total = valor_01 - Convert.ToSingle(resultado.Text);
                resultado.Text = total.ToString();

            }
            if (this.operacao == "x")
            {
                float total = valor_01 * Convert.ToSingle(resultado.Text);
                resultado.Text = total.ToString();

            }
            if (this.operacao == "-:-")
            {
                float total = valor_01 / Convert.ToSingle(resultado.Text);
                resultado.Text = total.ToString();

            }
        }

        private void botao_delete_Click(object sender, EventArgs e)
        {
            valor_01 = 0;
            resultado.Text = "";
        }
    }
}

