using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoDeLaOca
{
    public partial class frmDice : Form
    {
        int resultado;
        int ticks = 0;
        public frmDice(int num)
        {
            InitializeComponent();
            resultado = num;
        }

        void setImage(int num)
        {
            switch (num)
            {
                case 1:
                    pictureBox1.Image = Resource1.one;
                    break;
                case 2:
                    pictureBox1.Image = Resource1.two;
                    break;
                case 3:
                    pictureBox1.Image = Resource1.three;
                    break;
                case 4:
                    pictureBox1.Image = Resource1.four;
                    break;
                case 5:
                    pictureBox1.Image = Resource1.five;
                    break;
                case 6:
                    pictureBox1.Image = Resource1.six;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            setImage(rnd.Next(1,7));
            if(ticks <= 40)
            {
                ticks++;
            }
            else
            {
                timer1.Stop();
                setImage(resultado);
                timer2.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            this.Close();
        }

        private void frmDice_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
