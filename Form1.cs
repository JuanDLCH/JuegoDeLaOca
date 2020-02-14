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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            List<Jugador> jugadores = new List<Jugador>();
            if (opt1.Checked)
            {
                jugadores.Add(new Jugador("Jugador 1"));
            }
            else if(opt2.Checked)
            {
                jugadores.Add(new Jugador("Jugador 1"));
                jugadores.Add(new Jugador("Jugador 2"));
            }
            else if (opt3.Checked)
            {
                jugadores.Add(new Jugador("Jugador 1"));
                jugadores.Add(new Jugador("Jugador 2"));
                jugadores.Add(new Jugador("Jugador 3"));
            }
            else if (opt4.Checked)
            {
                jugadores.Add(new Jugador("Jugador 1"));
                jugadores.Add(new Jugador("Jugador 2"));
                jugadores.Add(new Jugador("Jugador 3"));
                jugadores.Add(new Jugador("Jugador 4"));
            }
            else
            {
                MessageBox.Show("Selecciona un número de jugadores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(jugadores.Count() > 0)
            {
                Tablero tablero = new Tablero(jugadores);
                this.Hide();
                tablero.Show();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
