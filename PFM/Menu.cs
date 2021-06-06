using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PFM.telas;

namespace PFM
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Tela7 tela7 = new Tela7();
            if (panel1.Contains(tela7) == false)
            {
                panel1.Controls.Add(tela7);
                tela7.Dock = DockStyle.Fill;
                tela7.BringToFront();
            }
            else
            {
                tela7.BringToFront();
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Tela1 tela1 = new Tela1();
            if (panel1.Contains(tela1) == false)
            {
                panel1.Controls.Add(tela1);
                tela1.Dock = DockStyle.Fill;
                tela1.BringToFront();
            }
            else
            {
                tela1.BringToFront();
            }

        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Tela2 tela2 = new Tela2();
            if (panel1.Contains(tela2) == false)
            {
                panel1.Controls.Add(tela2);
                tela2.Dock = DockStyle.Fill;
                tela2.BringToFront();
            }
            else
            {
                tela2.BringToFront();
            }

        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Tela3 tela3 = new Tela3();
            if (panel1.Contains(tela3) == false)
            {
                panel1.Controls.Add(tela3);
                tela3.Dock = DockStyle.Fill;
                tela3.BringToFront();
            }
            else
            {
                tela3.BringToFront();
            }

        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Tela4 tela4 = new Tela4();
            if (panel1.Contains(tela4) == false)
            {
                panel1.Controls.Add(tela4);
                tela4.Dock = DockStyle.Fill;
                tela4.BringToFront();
            }
            else
            {
                tela4.BringToFront();
            }

        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            Tela5 tela5 = new Tela5();
            if (panel1.Contains(tela5) == false)
            {
                panel1.Controls.Add(tela5);
                tela5.Dock = DockStyle.Fill;
                tela5.BringToFront();
            }
            else
            {
                tela5.BringToFront();
            }

        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            Tela6 tela6 = new Tela6();
            if (panel1.Contains(tela6) == false)
            {
                panel1.Controls.Add(tela6);
                tela6.Dock = DockStyle.Fill;
                tela6.BringToFront();
            }
            else
            {
                tela6.BringToFront();
            }

        }

        private void TableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
