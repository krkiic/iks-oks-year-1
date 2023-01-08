using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



// od ovde
namespace iks_oks_finalni
{
    public partial class Form1 : Form
    {
        bool koigra = true;

        public Form1()
        {
            InitializeComponent();
        }
        //klik
        private void klik(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (koigra)
                B.Text = "X";
            else
                B.Text = "O";

            koigra = !koigra; // negira
            //pozvane
            dugmestop();
            ceker();

        }
        private void ceker()
        {
            //horizontalno


            bool pobednik = false;
            if (((a1.Text == "X") && (a2.Text == "X")) && (a3.Text == "X"))
            {
                pobednik = true;
                a1.BackColor = Color.Red;
                a2.BackColor = Color.Red;
                a3.BackColor = Color.Red;
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                c1.Enabled = false;
                c2.Enabled = false;
                c3.Enabled = false;



            }

            if (((a1.Text == "O") && (a2.Text == "O")) && (a3.Text == "O"))
            {
                pobednik = true;
                a1.BackColor = Color.Blue;
                a2.BackColor = Color.Blue;
                a3.BackColor = Color.Blue;
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                c1.Enabled = false;
                c2.Enabled = false;
                c3.Enabled = false;

            }
            if (((b1.Text == "X") && (b2.Text == "X")) && (b3.Text == "X"))
            {
                pobednik = true;
                b1.BackColor = Color.Red;
                b2.BackColor = Color.Red;
                b3.BackColor = Color.Red;
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                c1.Enabled = false;
                c2.Enabled = false;
                c3.Enabled = false;

            }

            if (((b1.Text == "O") && (b2.Text == "O")) && (b3.Text == "O"))
            {
                pobednik = true;
                b1.BackColor = Color.Blue;
                b2.BackColor = Color.Blue;
                b3.BackColor = Color.Blue;
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                c1.Enabled = false;
                c2.Enabled = false;
                c3.Enabled = false;

            }
            if (((c1.Text == "X") && (c2.Text == "X")) && (c3.Text == "X"))
            {
                pobednik = true;
                c1.BackColor = Color.Red;
                c2.BackColor = Color.Red;
                c3.BackColor = Color.Red;
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                c1.Enabled = false;
                c2.Enabled = false;
                c3.Enabled = false;

            }

            if (((c1.Text == "O") && (c2.Text == "O")) && (c3.Text == "O"))
            {
                pobednik = true;
                c1.BackColor = Color.Blue;
                c2.BackColor = Color.Blue;
                c3.BackColor = Color.Blue;
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                c1.Enabled = false;
                c2.Enabled = false;
                c3.Enabled = false;

            }

            //vertikalni
            if (((a1.Text == "X") && (b1.Text == "X")) && (c1.Text == "X"))
            {
                pobednik = true;
                a1.BackColor = Color.Red;
                b1.BackColor = Color.Red;
                c1.BackColor = Color.Red;
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                c1.Enabled = false;
                c2.Enabled = false;
                c3.Enabled = false;

            }

            if (((a1.Text == "O") && (b1.Text == "O")) && (c1.Text == "O"))
            {
                pobednik = true;
                a1.BackColor = Color.Blue;
                b1.BackColor = Color.Blue;
                c1.BackColor = Color.Blue;
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                c1.Enabled = false;
                c2.Enabled = false;
                c3.Enabled = false;


            }


            if (((a2.Text == "X") && (b2.Text == "X")) && (c2.Text == "X"))
            {
                pobednik = true;
                a2.BackColor = Color.Red;
                b2.BackColor = Color.Red;
                c2.BackColor = Color.Red;
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                c1.Enabled = false;
                c2.Enabled = false;
                c3.Enabled = false;

            }

            if (((a2.Text == "O") && (b2.Text == "O")) && (c2.Text == "O"))
            {
                pobednik = true;
                a2.BackColor = Color.Blue;
                b2.BackColor = Color.Blue;
                c2.BackColor = Color.Blue;
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                c1.Enabled = false;
                c2.Enabled = false;
                c3.Enabled = false;


            }

            if (((a3.Text == "X") && (b3.Text == "X")) && (c3.Text == "X"))
            {
                pobednik = true;
                a3.BackColor = Color.Red;
                b3.BackColor = Color.Red;
                c3.BackColor = Color.Red;
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                c1.Enabled = false;
                c2.Enabled = false;
                c3.Enabled = false;

            }

            if (((a3.Text == "O") && (b3.Text == "O")) && (c3.Text == "O"))
            {
                pobednik = true;
                a3.BackColor = Color.Blue;
                b3.BackColor = Color.Blue;
                c3.BackColor = Color.Blue;
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                c1.Enabled = false;
                c2.Enabled = false;
                c3.Enabled = false;


            }
            //ukoso
            if (((a1.Text == "X") && (b2.Text == "X")) && (c3.Text == "X"))
            {
                pobednik = true;
                a1.BackColor = Color.Red;
                b2.BackColor = Color.Red;
                c3.BackColor = Color.Red;
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                c1.Enabled = false;
                c2.Enabled = false;
                c3.Enabled = false;

            }

            if (((a1.Text == "O") && (b2.Text == "O")) && (c3.Text == "O"))
            {
                pobednik = true;
                a1.BackColor = Color.Blue;
                b2.BackColor = Color.Blue;
                c3.BackColor = Color.Blue;
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                c1.Enabled = false;
                c2.Enabled = false;
                c3.Enabled = false;


            }


            if (((a3.Text == "X") && (b2.Text == "X")) && (c1.Text == "X"))
            {
                pobednik = true;
                a3.BackColor = Color.Red;
                b2.BackColor = Color.Red;
                c1.BackColor = Color.Red;
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                c1.Enabled = false;
                c2.Enabled = false;
                c3.Enabled = false;

            }

            if (((a3.Text == "O") && (b2.Text == "O")) && (c1.Text == "O"))
            {
                pobednik = true;
                a3.BackColor = Color.Blue;
                b2.BackColor = Color.Blue;
                c1.BackColor = Color.Blue;
                a1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                c1.Enabled = false;
                c2.Enabled = false;
                c3.Enabled = false;


            }

        }
        private void dugmestop()
        {
            if (a1.Text == "X" || a1.Text == "O")
            {
                a1.Enabled = false;
            }
            if (a2.Text == "X" || a2.Text == "O")
            {
                a2.Enabled = false;
            }
            if (a3.Text == "X" || a3.Text == "O")
            {
                a3.Enabled = false;
            }
            if (b1.Text == "X" || b1.Text == "O")
            {
                b1.Enabled = false;
            }
            if (b2.Text == "X" || b2.Text == "O")
            {
                b2.Enabled = false;
            }
            if (b3.Text == "X" || b3.Text == "O")
            {
                b3.Enabled = false;
            }
            if (c1.Text == "X" || c1.Text == "O")
            {
                c1.Enabled = false;
            }
            if (c2.Text == "X" || c2.Text == "O")
            {
                c2.Enabled = false;
            }
            if (c3.Text == "X" || c3.Text == "O")
            {
                c3.Enabled = false;
            }

        }


        //restart dugme

        private void restartDugme(object sender, EventArgs e)
        {
            restart.BackColor = Color.Gold;
            Application.Restart();

        }

      
    }
}


