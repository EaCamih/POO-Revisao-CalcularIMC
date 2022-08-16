using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularIMC_33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Instanciando classe (TEM QUE FAZER!! XD )
        Imc objImc = new Imc();

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Adicionando as exceções
            try
            {
                if (txtAltura.Text.Length <= 0 || txtPeso.Text.Length <= 0)
                {
                    throw new Exception("Campo obrigatório Vázio.");
                }
                else
                {
                    objImc.Peso = double.Parse(txtPeso.Text);
                    objImc.Altura = double.Parse(txtAltura.Text);

                    MessageBox.Show(objImc.CalcularIMC());
                }
            }
            //Retornando erro caso usuário não digitar apenas números
            catch (FormatException)
            {
                MessageBox.Show("Erro: Digite apenas números!");
            }
            //Retornando outros erros
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
