using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mehroz;

namespace PFM.telas
{
    public partial class Tela3 : UserControl
    {
        public Tela3()
        {
            InitializeComponent();
            mudarConfig();
        }

        Fraction resultado = new Fraction();
        Fraction frac1 = new Fraction();
        Fraction frac2 = new Fraction();

        Fraction frac1_Av = new Fraction();
        Fraction frac2_Av = new Fraction();
        Fraction frac3_Av = new Fraction();
        Fraction frac4_Av = new Fraction();

        Fraction frac1_Aux = new Fraction();
        Fraction frac2_Aux = new Fraction();
        Fraction frac3_Aux = new Fraction();
        Fraction frac4_Aux = new Fraction();

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ModoAvancado == true)
            {
                if (fraInferior1A_Av.Value != 0 && fraInferior1B_Av.Value != 0 && fraInferior2.Value != 0 && fraInferior1.Value != 0 && fraInferior2A_Av.Value != 0 && fraInferior2B_Av.Value != 0)
                {
                    if (check_fraSup1.Checked && check_fraInf1.Checked == false)
                    {
                        frac1_Av = new Fraction(Convert.ToInt32(fraSuperior1A_Av.Value), Convert.ToInt32(fraInferior1A_Av.Value));
                        Fraction.ReduceFraction(frac1_Av);

                        frac1_Aux = new Fraction(Convert.ToInt32(fraInferior1.Value), 1);
                        Fraction.ReduceFraction(frac1_Aux);

                        frac1 = new Fraction(frac1_Av.Numerator * frac1_Aux.Denominator, frac1_Av.Denominator * frac1_Aux.Numerator);
                        Fraction.ReduceFraction(frac1);

                    }
                    else if (check_fraInf1.Checked && check_fraSup1.Checked == false)
                    {
                        frac2_Av = new Fraction(Convert.ToInt32(fraSuperior1B_Av.Value), Convert.ToInt32(fraInferior1B_Av.Value));
                        Fraction.ReduceFraction(frac2_Av);

                        frac2_Aux = new Fraction(Convert.ToInt32(fraSuperior1.Value), 1);
                        Fraction.ReduceFraction(frac2_Aux);

                        frac1 = new Fraction(frac2_Av.Numerator * frac2_Aux.Denominator, frac2_Av.Denominator * frac2_Aux.Numerator);
                        Fraction.ReduceFraction(frac1);

                    }
                    else if (check_fraInf1.Checked && check_fraSup1.Checked)
                    {
                        frac2_Av = new Fraction(Convert.ToInt32(fraSuperior1A_Av.Value), Convert.ToInt32(fraInferior1A_Av.Value));
                        Fraction.ReduceFraction(frac2_Av);

                        frac2_Aux = new Fraction(Convert.ToInt32(fraSuperior1B_Av.Value), Convert.ToInt32(fraInferior1B_Av.Value));
                        Fraction.ReduceFraction(frac2_Aux);

                        frac1 = new Fraction(frac2_Av.Numerator * frac2_Aux.Denominator, frac2_Av.Denominator * frac2_Aux.Numerator);
                        Fraction.ReduceFraction(frac1);
                    }
                    else
                    {
                        frac1 = new Fraction(Convert.ToInt32(fraSuperior1.Value), Convert.ToInt32(fraInferior1.Value));
                        Fraction.ReduceFraction(frac1);
                    }
                    //////////////////////////////////////////
                    if (check_fraSup2.Checked && check_fraInf2.Checked == false)
                    {
                        frac3_Av = new Fraction(Convert.ToInt32(fraSuperior2A_Av.Value), Convert.ToInt32(fraInferior2A_Av.Value));
                        Fraction.ReduceFraction(frac3_Av);

                        frac3_Aux = new Fraction(Convert.ToInt32(fraInferior2.Value), 1);
                        Fraction.ReduceFraction(frac3_Aux);

                        frac2 = new Fraction(frac3_Av.Numerator * frac3_Aux.Denominator, frac3_Av.Denominator * frac3_Aux.Numerator);
                        Fraction.ReduceFraction(frac2);

                    }
                    else if (check_fraInf2.Checked && check_fraSup2.Checked == false)
                    {
                        frac4_Av = new Fraction(Convert.ToInt32(fraSuperior2B_Av.Value), Convert.ToInt32(fraInferior2B_Av.Value));
                        Fraction.ReduceFraction(frac4_Av);

                        frac4_Aux = new Fraction(Convert.ToInt32(fraSuperior2.Value), 1);
                        Fraction.ReduceFraction(frac4_Aux);

                        frac2 = new Fraction(frac4_Av.Numerator * frac4_Aux.Denominator, frac4_Av.Denominator * frac4_Aux.Numerator);
                        Fraction.ReduceFraction(frac2);

                    }
                    else if (check_fraInf2.Checked && check_fraSup2.Checked)
                    {
                        frac4_Av = new Fraction(Convert.ToInt32(fraSuperior2A_Av.Value), Convert.ToInt32(fraInferior2A_Av.Value));
                        Fraction.ReduceFraction(frac4_Av);

                        frac4_Aux = new Fraction(Convert.ToInt32(fraSuperior2B_Av.Value), Convert.ToInt32(fraInferior2B_Av.Value));
                        Fraction.ReduceFraction(frac4_Aux);

                        frac2 = new Fraction(frac4_Av.Numerator * frac4_Aux.Denominator, frac4_Av.Denominator * frac4_Aux.Numerator);
                        Fraction.ReduceFraction(frac2);
                    }
                    else
                    {
                        frac2 = new Fraction(Convert.ToInt32(fraSuperior2.Value), Convert.ToInt32(fraInferior2.Value));
                        Fraction.ReduceFraction(frac2);
                    }
                }
                else
                {
                    btn_calcular.Enabled = false;
                }
                btn_calcular.Enabled = true;

                resultado = frac1 * frac2;
                Fraction.ReduceFraction(resultado);

                string resultadoS = Convert.ToString(resultado);

                if (resultadoS.Contains("/"))
                {
                    string numerador = resultadoS.Substring(0, resultadoS.IndexOf("/"));
                    string denominador = resultadoS.Substring(resultadoS.IndexOf("/") + 1);

                    lbl_denominador.Visible = true;
                    label4.Visible = true;

                    lbl_numerador.Text = numerador;
                    lbl_denominador.Text = denominador;
                }
                else
                {

                    label4.Visible = false;
                    lbl_denominador.Visible = false;

                    lbl_numerador.Text = resultado.ToString();
                }

            }
            else
            {

                if (fraInferior2.Value != 0 && fraInferior1.Value != 0)
                {

                    frac1 = new Fraction(Convert.ToInt32(fraSuperior1.Value), Convert.ToInt32(fraInferior1.Value));
                    frac2 = new Fraction(Convert.ToInt32(fraSuperior2.Value), Convert.ToInt32(fraInferior2.Value));

                    resultado = frac1 * frac2;

                    string resultadoS = Convert.ToString(resultado);

                    if (resultadoS.Contains("/"))
                    {
                        string numerador = resultadoS.Substring(0, resultadoS.IndexOf("/"));
                        string denominador = resultadoS.Substring(resultadoS.IndexOf("/") + 1);

                        lbl_denominador.Visible = true;
                        label4.Visible = true;

                        lbl_numerador.Text = numerador;
                        lbl_denominador.Text = denominador;


                    }
                    else
                    {

                        label4.Visible = false;
                        lbl_denominador.Visible = false;

                        lbl_numerador.Text = resultado.ToString();
                    }

                }
                else
                {
                    btn_calcular.Enabled = false;
                }

                btn_calcular.Enabled = true;
            }
        }

        private void check_fraSup1_CheckedChanged(object sender, EventArgs e)
        {
            trocarFracao1(tableLayoutPanel_fraSup1, check_fraSup1, fraSuperior1);
        }

        private void check_fraSup2_CheckedChanged(object sender, EventArgs e)
        {
            trocarFracao2(tableLayoutPanel_fraSup2, check_fraSup2, fraSuperior2);

        }

        private void check_fraInf1_CheckedChanged(object sender, EventArgs e)
        {
            trocarFracao1(tableLayoutPanel_fraInf1, check_fraInf1, fraInferior1);

        }

        private void check_fraInf2_CheckedChanged(object sender, EventArgs e)
        {
            trocarFracao2(tableLayoutPanel_fraInf2, check_fraInf2, fraInferior2);

        }
        private void trocarFracao1(TableLayoutPanel painel, CheckBox check, NumericUpDown NuDfracao)
        {
            if (check.Checked)
            {
                NuDfracao.Visible = false;
                painel.Visible = true;
                painel.SetColumn(painel, 1);
            }
            else
            {
                NuDfracao.Visible = true;
                painel.Visible = false;
            }

        }
        private void trocarFracao2(TableLayoutPanel painel, CheckBox check, NumericUpDown NuDfracao)
        {
            if (check.Checked)
            {
                NuDfracao.Visible = false;
                painel.Visible = true;
                painel.SetColumn(painel, 5);
            }
            else
            {
                NuDfracao.Visible = true;
                painel.Visible = false;
            }
        }
        private void mudarConfig()
        {
            if (Properties.Settings.Default.ModoAvancado == true)
            {
                check_fraInf1.Visible = true;
                check_fraSup1.Visible = true;

                check_fraInf2.Visible = true;
                check_fraSup2.Visible = true;
            }
        }
    }
}
