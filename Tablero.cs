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
        int turno = 1;
        int resultadoDado;
        public static bool puedeJugar = true;
        List<Jugador> jugadores;
        Random rnd = new Random();
        PictureBox[] imgJugador = new PictureBox[4];
        int[] Ocas = new int[4] { 1, 7, 13, 25 };
        int[] Verdes = new int[6] { 3, 6, 12, 16, 24, 30 };
        int[] Naranjas = new int[6] { 1, 9, 14, 19, 23, 27 };
        int[] Amarillos = new int[6] { 2, 7, 13, 20, 25, 29 };
        int[] Morados = new int[6] { 4, 10, 15, 17, 22, 26 };
        int[] Azules = new int[6] { 5, 8, 11, 18, 21, 28 };

        public Tablero(List<Jugador> jugadores)
        {
            InitializeComponent();
            numPlayers = jugadores.Count();
            this.jugadores = jugadores;
            imgJugador[0] = imgJug1;
            imgJugador[1] = imgJug2;
            imgJugador[2] = imgJug3;
            imgJugador[3] = imgJug4;
            for(int i=0; i< 4; i++)
            {
                imgJugador[i].Visible = false;
            }

            //jug1.Pos = 15;
            //jug1.mover();
            //imgJug1.Location = new Point(jug1.PosX, jug1.PosY);
        }

        void siguienteTurno()
        {
            turno++;
            if (turno > numPlayers) turno = 1;
            if (jugadores[turno - 1].PierdeTurno)
            {
                jugadores[turno - 1].PierdeTurno = false;
            }
            if (jugadores[turno - 1].Penalizado)
            {
                jugadores[turno - 1].Penalizado = false;
            }
            else
            {
                puedeJugar = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerDado.Stop();
            jugadores[turno - 1].Pos += resultadoDado;
            mover(turno);
        }

        void penalizar(int pos)
        {
            if (Verdes.Contains(jugadores[turno - 1].Pos))
            {
                puente(turno);
            }
            else if (Naranjas.Contains(jugadores[turno - 1].Pos))
            {
                posada(turno);
            }
            else if (Amarillos.Contains(jugadores[turno - 1].Pos))
            {
                dado(turno);
            }
            else if (Morados.Contains(jugadores[turno - 1].Pos))
            {
                resbalon(turno);
            }
            else //Azules
            {
                calavera(turno);
            }
            puedeJugar = true;
        }

        void puente(int turno)
        {
            MessageBox.Show("Retrocedes 3 casillas", "Puente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            jugadores[turno - 1].Pos -= 3;
            jugadores[turno - 1].Penalizado = true;
            mover(turno);
        }

        void posada(int turno)
        {
            MessageBox.Show("Pierdes un turno", "Posada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            jugadores[turno - 1].PierdeTurno = true;
            jugadores[turno - 1].Penalizado = true;
        }

        void dado(int turno)
        {
            resultadoDado = rnd.Next(1, 7);
            frmDice dado = new frmDice(resultadoDado);
            dado.Show();
            timerDadoMalo.Start();
        }

        void resbalon(int turno)
        {
            MessageBox.Show("Retrocedes 2 casillas", "Resbalón", MessageBoxButtons.OK, MessageBoxIcon.Information);
            jugadores[turno - 1].Pos -= 2;
            jugadores[turno - 1].Penalizado = true;
            mover(turno);
        }

        void calavera(int turno)
        {
            MessageBox.Show("Aiooooos", "CALAVERA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            jugadores[turno - 1].Pos = 1;
            jugadores[turno - 1].Penalizado = true;
            mover(turno);
        }

        void mover(int turno)
        {
            if (jugadores[turno - 1].Pos < 1)
            {
                imgJugador[turno - 1].Visible = false;
                jugadores[turno - 1].Pos = 0;
            }
            else
            {
                imgJugador[turno - 1].Visible = true;
            }
            if(jugadores[turno - 1].Pos >= 30)
            {
                endgame();
            }
            jugadores[turno - 1].mover();
            imgJugador[turno - 1].Location = new Point(jugadores[turno - 1].PosX, jugadores[turno - 1].PosY);
            if (jugadores[turno-1].Penalizado)
            {
                jugadores[turno - 1].Penalizado = false;
            }
            else if(jugadores[turno - 1].Oca)
            {
                jugadores[turno - 1].Oca = false;
            }
            else
            {
                mostrarPregunta();
            }
        }

        void endgame()
        {
            DialogResult result;
            result = MessageBox.Show("Ha ganado el " + jugadores[turno - 1].Nombre, "Fin del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(result == DialogResult.OK)
            {
                Application.ExitThread();
            }
        }
        private void Tablero_KeyDown(object sender, KeyEventArgs e)
        
        {
            if (e.KeyData.Equals(Keys.D))
            {
                if (puedeJugar)
                {
                    label1.Text = "Turno de: " + jugadores[turno - 1].Nombre;
                    puedeJugar = false;
                    resultadoDado = rnd.Next(1, 7);
                    frmDice Dado = new frmDice(resultadoDado);
                    timerDado.Start();
                    Dado.Show();
                }
            }
        }

        void mostrarPregunta()
        {
            BancoPreguntas.Add(new Question("¿Cuál es la correcta?", "Esta no", "Esta tampoco", "Esta sí", "Esta menos", "Esta no"));
            Pregunta pregunta = new Pregunta(BancoPreguntas[0]);
            pregunta.ShowDialog();
            if (pregunta.DialogResult == DialogResult.Yes)
            {
                if (Ocas.Contains(jugadores[turno - 1].Pos))
                {
                    if(jugadores[turno - 1].Oca)
                    {
                        jugadores[turno - 1].Oca = false;

                    }
                    else
                    {
                        if(siguienteOca() != 0)
                        {
                            MessageBox.Show("¡OCA!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            jugadores[turno - 1].Oca = true;
                            jugadores[turno - 1].Pos = siguienteOca();
                        }
                        mover(turno);
                    }
                }
                else
                {
                    MessageBox.Show("Bien hecho");
                }
                puedeJugar = true;
                siguienteTurno();
            }
            else
            {
                MessageBox.Show("Berga wey");
                penalizar(jugadores[turno - 1].Pos);
                jugadores[turno - 1].Penalizado = true;
                siguienteTurno();
                puedeJugar = true;
            }
        }

        int siguienteOca()
        {
            for(int i = 0; i < Ocas.Length; i++)
            {
                if(Ocas[i] > jugadores[turno - 1].Pos)
                {
                    return Ocas[i];
                }
            }
            return 0;
        }

        private void timerDadoMalo_Tick(object sender, EventArgs e)
        {
            timerDadoMalo.Stop();
            MessageBox.Show("Retrocede "+resultadoDado+" espacios", "Dado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            jugadores[turno - 1].Penalizado = true;
            jugadores[turno - 1].Pos -= resultadoDado;
            mover(turno);
        }
    }
}
