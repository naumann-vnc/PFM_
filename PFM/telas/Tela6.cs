using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFM.telas
{
    public partial class Tela6 : UserControl
    {
        public Tela6()
        {
            InitializeComponent();
            mudarConfig();
        }
        static decimal[,] matriz1 = new decimal[3, 3];
        static decimal[,] matriz2 = new decimal[3, 3];
        private void Btn_calcular_Click(object sender, EventArgs e)
        {
            matriz1[0, 0] = nA_a11.Value;
            matriz1[0, 1] = nA_a12.Value;
            matriz1[0, 2] = nA_a13.Value;

            matriz1[1, 0] = nA_a21.Value;
            matriz1[1, 1] = nA_a22.Value;
            matriz1[1, 2] = nA_a23.Value;

            matriz1[2, 0] = nA_a31.Value;
            matriz1[2, 1] = nA_a32.Value;
            matriz1[2, 2] = nA_a33.Value;

            //

            matriz2[0, 0] = nB_b11.Value;
            matriz2[0, 1] = nB_b12.Value;
            matriz2[0, 2] = nB_b13.Value;

            matriz2[1, 0] = nB_b21.Value;
            matriz2[1, 1] = nB_b22.Value;
            matriz2[1, 2] = nB_b23.Value;

            matriz2[2, 0] = nB_b31.Value;
            matriz2[2, 1] = nB_b32.Value;
            matriz2[2, 2] = nB_b33.Value;

            //

            lbl_c11.Text = Convert.ToString((matriz1[0, 0] * matriz2[0, 0]) + (matriz1[0, 1] * matriz2[1, 0]) + (matriz1[0, 2] * matriz2[2, 0]));
            lbl_c12.Text = Convert.ToString((matriz1[0, 0] * matriz2[0, 1]) + (matriz1[0, 1] * matriz2[1, 1]) + (matriz1[0, 2] * matriz2[2, 1]));
            lbl_c13.Text = Convert.ToString((matriz1[0, 0] * matriz2[0, 2]) + (matriz1[0, 1] * matriz2[1, 2]) + (matriz1[0, 2] * matriz2[2, 2]));
            //
            lbl_c21.Text = Convert.ToString((matriz1[1, 0] * matriz2[0, 0]) + (matriz1[1, 1] * matriz2[1, 0]) + (matriz1[1, 2] * matriz2[2, 0]));
            lbl_c22.Text = Convert.ToString((matriz1[1, 0] * matriz2[0, 1]) + (matriz1[1, 1] * matriz2[1, 1]) + (matriz1[1, 2] * matriz2[2, 1]));
            lbl_c23.Text = Convert.ToString((matriz1[1, 0] * matriz2[0, 2]) + (matriz1[1, 1] * matriz2[1, 2]) + (matriz1[1, 2] * matriz2[2, 2]));

            //
            lbl_c31.Text = Convert.ToString((matriz1[2, 0] * matriz2[0, 0]) + (matriz1[2, 1] * matriz2[1, 0]) + (matriz1[2, 2] * matriz2[2, 0]));
            lbl_c32.Text = Convert.ToString((matriz1[2, 0] * matriz2[0, 1]) + (matriz1[2, 1] * matriz2[1, 1]) + (matriz1[2, 2] * matriz2[2, 1]));
            lbl_c33.Text = Convert.ToString((matriz1[2, 0] * matriz2[0, 2]) + (matriz1[2, 1] * matriz2[1, 2]) + (matriz1[2, 2] * matriz2[2, 2]));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nA_a11.DecimalPlaces >= 1)
            {
                nB_b11.DecimalPlaces--;
                nB_b12.DecimalPlaces--;
                nB_b13.DecimalPlaces--;

                nB_b21.DecimalPlaces--;
                nB_b22.DecimalPlaces--;
                nB_b23.DecimalPlaces--;

                nB_b31.DecimalPlaces--;
                nB_b32.DecimalPlaces--;
                nB_b33.DecimalPlaces--;
                //
                nA_a11.DecimalPlaces--;
                nA_a12.DecimalPlaces--;
                nA_a13.DecimalPlaces--;

                nA_a21.DecimalPlaces--;
                nA_a22.DecimalPlaces--;
                nA_a23.DecimalPlaces--;

                nA_a31.DecimalPlaces--;
                nA_a32.DecimalPlaces--;
                nA_a33.DecimalPlaces--;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nB_b11.DecimalPlaces++;
            nB_b12.DecimalPlaces++;
            nB_b13.DecimalPlaces++;

            nB_b21.DecimalPlaces++;
            nB_b22.DecimalPlaces++;
            nB_b23.DecimalPlaces++;

            nB_b31.DecimalPlaces++;
            nB_b32.DecimalPlaces++;
            nB_b33.DecimalPlaces++;
            //
            nA_a11.DecimalPlaces++;
            nA_a12.DecimalPlaces++;
            nA_a13.DecimalPlaces++;

            nA_a21.DecimalPlaces++;
            nA_a22.DecimalPlaces++;
            nA_a23.DecimalPlaces++;

            nA_a31.DecimalPlaces++;
            nA_a32.DecimalPlaces++;
            nA_a33.DecimalPlaces++;
        }
        private void mudarConfig()
        {
            if (Properties.Settings.Default.ModoAvancado == true)
            {
                tableLayoutPanel5.Visible = true;
            }
        }
    }
}
