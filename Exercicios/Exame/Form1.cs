using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exame
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

                //VALIDAR PREENCHIMENTO DA CAIXA

                if (txtNota1.Text != "" && txtNota2.Text != "" && txtNota3.Text != "" && txtNota4.Text != "")
                {
                    decimal nota01 = Convert.ToDecimal(txtNota1.Text);
                    decimal nota02 = Convert.ToDecimal(txtNota2.Text);
                    decimal nota03 = Convert.ToDecimal(txtNota3.Text);
                    decimal nota04 = Convert.ToDecimal(txtNota4.Text);


                    //MÉDIA
                    decimal media = (nota01 + nota02 + nota03 + nota04) / 4;


                    txtMedia.Text = media.ToString();
                    //NOTA MAIS ALTA E BAIXA
                    decimal alta = nota01;
                    decimal baixa = nota01;

                    //MAIS ALTAS
                    if (nota02 > alta)
                    {
                        alta = nota02;
                    }
                    if (nota03 > alta)
                    {
                        alta = nota03;
                    }
                    if (nota04 > alta)
                    {
                        alta = nota04;
                    }
                    //NOTAS MAIS BAIXAS
                    if (nota02 < baixa)
                    {
                        baixa = nota02;
                    }
                    if (nota03 < baixa)
                    {
                        baixa = nota03;
                    }
                    if (nota04 < baixa)
                    {
                        baixa = nota04;
                    }

                    txtBaixa.Text = baixa.ToString();
                    txtAlta.Text = alta.ToString();

                    //APROVADO

                    if (media >= 7)
                    {
                        txtNotafinal.Text = media.ToString();
                        lbStatus.Text = "Aprovado!";
                        lbStatus.ForeColor = Color.Green;

                    }
                    //SOLICITAR EXAME PRA APROVADO OU REPROVADO :D:

                    else
                    {

                        lbStatus.Text = "Reprovado";
                        lbStatus.ForeColor = Color.Red;
                        txtExame.Enabled = true;

                        //CAIXA EXAME COM VALOR = NULO PRA NÃO CRASHAR

                        if (txtExame.Text != "")
                        {
                            decimal nota05 = Convert.ToDecimal(txtExame.Text);
                            decimal novamedia = (nota01 + nota02 + nota03 + nota04 + nota05) / 5;
                            txtExamefinal.Text = novamedia.ToString();

                            //REPROVAÇÃO COM A NOTA DO EXAME :(

                            if (novamedia >= 5)
                            {
                                lbStatusexame.Text = "Aprovado!";
                                lbStatusexame.ForeColor = Color.Green;
                            }
                            else
                            {
                                lbStatusexame.Text = "Reprovado!";
                                lbStatusexame.ForeColor = Color.Red;
                            }




                        }



                    }
                }

                //MOSTRAR A MENSAGEM CASO O PREENCHIMENTO NÃO ESTEJA CORRETO
                else 
                {
                    MessageBox.Show("Preencher os campos corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              

















            }

        }
    }

}






























