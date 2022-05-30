using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int idade = int.Parse(txtIdade.Text);
            double altura = double.Parse(txtAltura.Text);
            double peso = double.Parse(txtPeso.Text);
            double IMC = peso / (altura * altura);
             
            
            richChat.Text = IMC.ToString("n1");


            if (IMC < 18.5)
            {
                richChat.Text = nome +  " seu atual estado , Abaixo do peso";
           
            }
            
            else if (IMC > 18.6 && IMC < 24.9)
            
            {
                richChat.Text = nome + " seu atual estado , Saudável, Parabéns!";

            }

            else if (IMC > 25.0 && IMC < 29.9)
            
            {
                richChat.Text = nome + " seu atual estado , Peso em excesso";

            }

            else if (IMC > 30.0 && IMC < 34.9)
            {
                richChat.Text = nome + " seu atual estado , Obesidade Grau I";


            }
            
            else if (IMC > 35.0 && IMC < 39.9)

            {
                richChat.Text = nome + " seu atual estado , Obesidade Grau II";

            }
            
            else

            {
                richChat.Text = nome + " seu atual estado , Obesidade Grau III";

            }

            
        
       
        
        }
    
    
    
    
    
    
    
    
    }
}
