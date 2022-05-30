using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace divisiveis2e3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            
            
            if (txtNum1.Text != "" && txtNum2.Text != "" && txtNum3.Text != "" && txtNum4.Text != "")
            {
                int num1 = Int32.Parse(txtNum1.Text);
                int num2 = Int32.Parse(txtNum2.Text);
                int num3 = Int32.Parse(txtNum3.Text);
                int num4 = Int32.Parse(txtNum4.Text);




                if (num1 % 2 == 0)
                {
                    txtDiv2_1.Text = num1.ToString();

                }

                if (num1 % 3 == 0)

                {

                    txtDiv3_1.Text = num1.ToString();

                }

                if (num2 % 2 == 0)

                {

                    txtDiv2_2.Text = num2.ToString();

                }

                if (num2 % 3 == 0)

                {

                    txtDiv3_2.Text = num2.ToString();

                }

                if (num3 % 2 == 0)
                {

                    txtDiv2_3.Text = num3.ToString();

                }

                if (num3 % 3 == 0)
                {

                    txtDiv3_3.Text = num3.ToString();

                }

                if (num4 % 2 == 0)
                {

                    txtDiv2_4.Text = num4.ToString();

                }

                if (num4 % 3 == 0)

                {

                    txtDiv3_4.Text = num4.ToString();

                }
            }

            else
            {
                MessageBox.Show("Preencher os campos corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
                




















        }
    }
}
