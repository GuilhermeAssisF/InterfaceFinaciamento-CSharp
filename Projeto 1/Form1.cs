using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void principal_TextChanged(object sender, EventArgs e)
        {

        }

        private void taxaDeJurosMensal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numeroDeParcelas_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculoJuros_Click(object sender, EventArgs e)
        {
            //((Convert.ToDouble(taxaDeJurosAnual.Text) / 12) / 100);
            double valorDaParcela = Convert.ToDouble(principal.Text) *
                ((Convert.ToDouble(taxaDeJurosAnual.Text) / 12 / 100) / (1 - Math.Pow(1 + (Convert.ToDouble(taxaDeJurosAnual.Text) / 12 / 100), - Convert.ToDouble(numeroDeParcelas.Text))));
            valorPago.Text = "Valor da Parcela: " + valorDaParcela.ToString("N2");
            double resultadoFinanciamento = valorDaParcela * Convert.ToDouble(numeroDeParcelas.Text);
            totalJuros.Text = "Total de Juros: " + (resultadoFinanciamento - Convert.ToDouble(principal.Text)).ToString("N2");
            resultadoFinal.Text = "Total Final: " + resultadoFinanciamento.ToString("N2");
        }
    }
}
