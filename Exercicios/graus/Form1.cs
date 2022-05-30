using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcularF_Click(object sender, EventArgs e)
        {
            

            //PREENCHIMENTO CORRETO DA CAIXA
            
            if (txtC.Text != "")
            {


                decimal C = Convert.ToDecimal(txtC.Text);
                
                //CALCULO PRA CONVERTER CELSIUS PARA FAHRENHEIT

                decimal F = (9 * C + 160) / 5;
                
                //HABILITAR A LABEL E MOSTRAR O RESULTADO
               
                lbF.Visible = true;
                lbF.Text = F.ToString("n2")+ "F°";
                
                //MUDAR A COR DEPENDENDO DA TEMPERATURA

                if (C > 20)
                
                {
                    lbF.ForeColor = Color.Orange;
                    
                }
                
                else
                
                {
                    lbF.ForeColor = Color.Aqua;
                    
                    
                }
            }
            
            else
            
            {
                MessageBox.Show("Preencher o campo corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
       
        
        
        
        }

        private void btCalcularC_Click(object sender, EventArgs e)
        {
           
            //PREENCHIMENTO CORRETO DA CAIXA

            if (txtF.Text != "")
            {
                

                decimal F = Convert.ToDecimal(txtF.Text);

                //CALCULO PRA CONVERTER CELSIUS PARA FAHRENHEIT

                decimal C = (F - 32) * 5/9;

                //HABILITAR A LABEL E MOSTRAR O RESULTADO

                lbC.Visible = true;
                lbC.Text = C.ToString("n2")+ "C°";

                //MUDAR A COR DEPENDENDO DA TEMPERATURA

                if (F > 68)
                {
                    lbC.ForeColor = Color.Orange;
                    
                }

                else

                {
                    lbC.ForeColor = Color.Aqua;
                    

                }

                
            }

            else

            {
                MessageBox.Show("Preencher o campo corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
   
    
    
    
    
    }
}
