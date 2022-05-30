using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversaodolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (txtDols.Text != "")
            {
                double dol = double.Parse(txtDols.Text);
                double real = dol * 4.73;
                lbResultado.Visible = true;
                lbResultado.Text = real.ToString("n2");
            }
            else
            {
                MessageBox.Show("Preencha o campo corretamente", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
                    
                    
                    
        
                    
                    
        
        
        
        
        
        
        
        
        
        
        }
    
    
    
    }
}
