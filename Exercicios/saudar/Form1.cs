using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saudar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbSexo.Items.Add("Masculino");
            cbSexo.Items.Add("Feminino");
        }

        private void btOk_Click(object sender, EventArgs e)
        {

            if (txtNome.Text != "" && cbSexo.Text != "")
            {
                string nome = txtNome.Text;
                string sexo = cbSexo.Text;

                if (cbSexo.Text == "Feminino")
                {
                    rcMsg.Text = "Ilustríssima Sra." + nome + "\nSaudações, linda!";
                    pcGirl.Visible = true;
                    pcBoy.Visible = false;
                }
                else
                {
                    rcMsg.Text = "Ilustríssimo Sr." + nome + "\nSaudações, lindo!";
                    pcBoy.Visible = true;
                    pcGirl.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Valide todos os campos corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        
        
        
        
        
        
        
        
        }
   
    
    
    
    
    
    
    
    
    
    }
}
