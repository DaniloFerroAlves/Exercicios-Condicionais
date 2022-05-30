using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Positivão
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {

            if (txtNumero.Text != "")
            {
                int numero = Convert.ToInt32(txtNumero.Text);
                int resultado;


                if (numero < 0)
                {
                    resultado = numero * -1;
                    lbResultado.Text = resultado.ToString();
                }
                else
                {
                    resultado = numero;
                    lbResultado.Text = resultado.ToString();

                }
            }
            else
            {
                MessageBox.Show("Preencher os campos corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        
        
        }
    
    
    
    
    
    
    }
}
