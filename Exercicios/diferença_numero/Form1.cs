using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diferença_numero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {

            if (txtNumero1.Text != "" && txtNumero2.Text != "")
            {
                int numero1 = Convert.ToInt32(txtNumero1.Text);
                int numero2 = Convert.ToInt32(txtNumero2.Text);


                if (numero1 > numero2)
                {
                    int resultado = numero1 - numero2;
                    lbDiferença.Text = resultado.ToString();
                }
                else
                {
                    int resultado = numero2 - numero1;
                    lbDiferença.Text = resultado.ToString();
                }
            }
            else
            {
                MessageBox.Show("Preencher os campos corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
   
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
