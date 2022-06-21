using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            txtAltura.Text = "";
            txtPeso.Text = "";
            txtIndice.Text = "";
            txtResultado.Text = ""; 
        }

        private void btnSair_Click(object sender, EventArgs e) {
            Close(); 
        }

        private void btnCalcular_Click(object sender, EventArgs e) {
            try { 
                double peso = Convert.ToDouble(txtPeso.Text);
                double altura = Convert.ToDouble(txtAltura.Text);
                double indice = Math.Round(Imc.calcularImc(peso, altura), 2);
                string resultado = Imc.informarImc(indice);
                txtIndice.Text = indice.ToString();
                txtResultado.Text = resultado.ToString();
            }
            catch (FormatException ex) {
                MessageBox.Show(ex.Message, "Formato incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
