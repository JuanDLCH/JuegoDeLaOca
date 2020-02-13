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
    public partial class Tablero : Form
    {
        List<Question> BancoPreguntas = new List<Question>();
        int numPlayers;
        int turno;
        bool puedeJugar = true;
        List<Jugador> jugadores;
        Random rnd = new Random();
        int[] Verdes = new int[6] { 3, 6, 12, 16, 24, 30 };
        int[] Naranjas = new int[6] { 1, 9, 14, 19, 23, 27 };
        int[] Amarillo = new int[6] { 2, 7, 13, 20, 25, 29 };
        int[] Morado = new int[6] { 4, 10, 15, 17, 22, 26 };
        int[] Azul = new int[6] { 5, 8, 11, 18, 21, 28 };
        public Tablero(List<Jugador> jugadores)
        {
            InitializeComponent();
            numPlayers = jugadores.Count();
            this.jugadores = jugadores;
            //jug1.Pos = 15;
            //jug1.mover();
            //imgJug1.Location = new Point(jug1.PosX, jug1.PosY);
        }

        void siguienteTurno()
        {
            turno++;
            if (turno > numPlayers) turno = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerDado.Stop();
            jugadores[turno].mover();
            imgJug1.Location = new Point(jugadores[turno].PosX, jugadores[turno].PosY);
            BancoPreguntas.Add(new Question("¿Cuál es la correcta?", "Esta no", "Esta tampoco", "Esta sí", "Esta menos", "Esta no"));
            Pregunta pregunta = new Pregunta(BancoPreguntas[0]);
            pregunta.ShowDialog();
            if (pregunta.DialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Bien hecho");
                puedeJugar = true;
            }
            else
            {
                MessageBox.Show("Berga wey");
                penalizacion(jugadores[turno].Pos);
                //puedeJugar = true;
            }
        }

        void penalizacion(int pos)
        {

        }

        private void Tablero_KeyDown(object sender, KeyEventArgs e)
        {
            int resultadoDado;
            if (e.KeyData.Equals(Keys.D))
            {
                if (puedeJugar)
                {
                    puedeJugar = false;
                    resultadoDado = rnd.Next(1, 6);
                    frmDice Dado = new frmDice(resultadoDado);
                    Dado.Show();
                    jugadores[turno].Pos += resultadoDado;
                    jugadores[turno].mover();
                    timerDado.Enabled = true;
                }
            }
        }
    }
}
