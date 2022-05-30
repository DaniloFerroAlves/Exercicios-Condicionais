using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ordemcrescente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            {
                

                
            }
            if (txtNumero1.Text != "" && txtNumero2.Text != "" && txtNumero3.Text != "")
            {
                int Num1 = Int32.Parse(txtNumero1.Text);

                int Num2 = Int32.Parse(txtNumero2.Text);

                int Num3 = Int32.Parse(txtNumero3.Text);
                int X;

                if (Num1 > Num2)
                {
                    X = Num1;
                    Num1 = Num2;
                    Num2 = X;
                }
                if (Num1 > Num3)
                {
                    X = Num1;
                    Num1 = Num3;
                    Num3 = X;
                }
                if (Num2 > Num3)
                {
                    X = Num2;
                    Num2 = Num3;
                    Num3 = X;
                }

                txtResultado1.Text = Num1.ToString();
                txtResultado2.Text = Num2.ToString();
                txtResultado3.Text = Num3.ToString();
            }
            else
            {
                MessageBox.Show("Preencher os campos corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





























        }







    }









    
}
