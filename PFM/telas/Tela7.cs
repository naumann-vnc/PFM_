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
    public partial class Tela7 : UserControl
    {
        public Tela7()
        {
            InitializeComponent();
            checar();
        }

        private void check_avancado_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checar()
        {
            if (Properties.Settings.Default.ModoAvancado == true)
            {
                check_avancado.Checked = true;
            }
            else
            {
                check_avancado.Checked = false;
            }
        }

        private void btn_aplicar_Click(object sender, EventArgs e)
        {
            if (check_avancado.Checked)
            {
                Properties.Settings.Default.ModoAvancado = true;
            }
            else
            {
                Properties.Settings.Default.ModoAvancado = false;
            }
        }
    }
}
