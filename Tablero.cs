﻿using System;
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
    //Presentado por Juan Diego Londoño Chavarría y Santiago Cano Duque
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
        int[] puentes = new int[6];
        int[] resbalones = new int[6];
        int[] calaveras = new int[6];
        int[] posadas = new int[6];
        int[] dados = new int[6];
        int[] penalizaciones = new int[5] {8,8,8,8,8};
        int it = 0;

        public Tablero(List<Jugador> jugadores)
        {
            InitializeComponent();
            asignarPenalizaciones();
            anadirPreguntas();
            numPlayers = jugadores.Count();
            this.jugadores = jugadores;
            imgJugador[0] = imgJug1;
            imgJugador[1] = imgJug2;
            imgJugador[2] = imgJug3;
            imgJugador[3] = imgJug4;
            for (int i = 0; i < 4; i++)
            {
                imgJugador[i].Visible = false;
            }

            //jug1.Pos = 15;
            //jug1.mover();
            //imgJug1.Location = new Point(jug1.PosX, jug1.PosY);
        }
        void compararPenas(int[] vec, int n)
        {
            switch (n)
            {
                case 1:
                    puentes = vec;
                    break;
                case 2:
                    resbalones = vec;
                    break;
                case 3:
                    calaveras = vec;
                    break;
                case 4:
                    posadas = vec;
                    break;
                case 5:
                    dados = vec;
                    break;
            }
        }
        void asignarPenalizaciones()
        {
            int n = rnd.Next(0, 5);
            while (penalizaciones.Contains(n)) //Verdes
            {
                n = rnd.Next(0, 5);
            }
            penalizaciones[0] = n;
            compararPenas(Verdes, n);
            n = rnd.Next(0, 5);
            while (penalizaciones.Contains(n)) //Naranjas
            {
                n = rnd.Next(0, 5);
            }
            penalizaciones[1] = n;
            compararPenas(Naranjas, n);
            n = rnd.Next(0, 5);
            while (penalizaciones.Contains(n)) //Amarillos
            {
                n = rnd.Next(0, 5);
            }
            penalizaciones[2] = n;
            compararPenas(Amarillos, n);
            n = rnd.Next(0, 5);
            while (penalizaciones.Contains(n)) //Morados
            {
                n = rnd.Next(0, 5);
            }
            penalizaciones[3] = n;
            compararPenas(Morados, n);
            n = rnd.Next(0, 5);
            while (penalizaciones.Contains(n)) //Azules
            {
                n = rnd.Next(0, 5);
            }
            penalizaciones[4] = n;
            compararPenas(Azules, n);
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
                timer1.Start();
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
            if (puentes.Contains(jugadores[turno - 1].Pos))
            {
                puente(turno);
            }
            else if (posadas.Contains(jugadores[turno - 1].Pos))
            {
                posada(turno);
            }
            else if (dados.Contains(jugadores[turno - 1].Pos))
            {
                dado(turno);
            }
            else if (resbalones.Contains(jugadores[turno - 1].Pos))
            {
                resbalon(turno);
            }
            else //Calaveras
            {
                calavera(turno);
            }
            timer1.Start();
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
            jugadores[turno - 1].Pos = 0;
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
                    label2.Visible = false;
                    timer1.Stop();
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
            Pregunta pregunta = new Pregunta(new Question("","","","","",""));
            int num = rnd.Next(0, BancoPreguntas.Count);
            if (BancoPreguntas.Count > 0)
            {
                pregunta = new Pregunta(BancoPreguntas[num]);
            }
            else
            {
                DialogResult result;
                result = MessageBox.Show("Banco de preguntas vacío, nadie gana", "Fin del juego", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                if (result == DialogResult.OK)
                {
                    Application.ExitThread();
                }
            }
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
                    MessageBox.Show("Bien hecho", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                BancoPreguntas.RemoveAt(num);
                timer1.Start();
                puedeJugar = true;
                siguienteTurno();
            }
            else
            {
                MessageBox.Show("Incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if(it % 2 == 0)
            {
                label2.Visible = false;
            }
            else
            {
                label2.Visible = true;
            }
            it++;
        }
        void anadirPreguntas()
        {
            BancoPreguntas.Add(new Question("¿Quién era el dios romano de la guerra?", "Ares", "Júpiter", "Marte", "Belerofonte", "Ares"));
            BancoPreguntas.Add(new Question("Según la leyenda, ¿cómo murió el Papa Adriano IV en 1159?", "Tragándose una mosca", "Cayéndose de un balcón", "Chocándose contra una puerta", "Cayéndose de un caballo", "Tragándose una mosca"));
            BancoPreguntas.Add(new Question("¿Cuántos tentáculos tiene un calamar?", "4", "8", "10", "20", "8"));
            BancoPreguntas.Add(new Question("Aproximadamente, ¿qué porcentaje de la superficie de la Tierra es agua?", "50%", "70%", "90%", "10%", "70%"));
            BancoPreguntas.Add(new Question("¿Cuál es el idioma oficial de Brasil?", "Brasileño", "Francés", "Inglés", "Portugués", "Portugués"));
            BancoPreguntas.Add(new Question("¿Qué significa “palimpsesto”?", "Un personaje que carece de seriedad", "Razonamiento por el que la verdad de una proposición se prueba demostrando la imposibilidad o absurdo de la proposición contraria",
                "Algo que sirve como ayuda auxiliar", "Manuscrito cuya escritura ha sido eliminada con objeto de escribir otro texto encima", "Manuscrito cuya escritura ha sido eliminada con objeto de escribir otro texto encima"));
            BancoPreguntas.Add(new Question("¿En qué año murió Bob Marley?", "1981", "1986", "1991", "2003", "1981"));
            BancoPreguntas.Add(new Question("Deberíamos tomar antibióticos...", "Para combatir los virus", "Contra las infecciones bacterianas", "Siempre que nos sintamos enfermos", "¡Nunca!", "Contra las infecciones bacterianas"));
            BancoPreguntas.Add(new Question("¿Cuál es el nombre de la 'herramienta' necesaria para jugar al billar?", "Palo", "Snooker", "Bubingo", "Taco", "Taco"));
            BancoPreguntas.Add(new Question("¿Por qué es reconocido Serguéi Rajmáninov?", "Por sus contribuciones al mundo de la física cuántica", "Por sus contribuciones al mundo de la música", "Por sus contribuciones al mundo de la pintura", "Por sus contribuciones al mundo de la literatura", "Por sus contribuciones al mundo de la música"));
            BancoPreguntas.Add(new Question("¿Cuál es el estado estadounidense más cercano a la antigua Unión Soviética?", "Alaska", "Florida", "California", "Texas", "Alaska"));
            BancoPreguntas.Add(new Question("¿Por qué se llaman lenguas romances el francés, el español y el italiano?", "Porque suenan muy románticas", "Porque fueron difundidas por los trovadores ambulantes", "Porque encuentran sus raíces en el latín, hablado por los romanos", "Porque inicialmente eran habladas solo por los romaníes", "Porque encuentran sus raíces en el latín, hablado por los romanos"));
            BancoPreguntas.Add(new Question("¿Qué parte del cuerpo produce insulina?", "El páncreas", "El hígado", "El bazo", "El timo", "El páncreas"));
            BancoPreguntas.Add(new Question("¿Qué animal es la drosophila?", "Una rata", "Una mosca", "Un conejillo de Indias", "Una cabra", "Una mosca"));
            BancoPreguntas.Add(new Question("¿Cuántas sílabas forman un haiku?", "14", "15", "16", "17", "17"));
            BancoPreguntas.Add(new Question("¿Qué objeto se convirtió en el símbolo de la película de animación “Akira”?", "Un coche azul", "Una ametralladora", "Una motocicleta roja", "Una espada dorada", "Una motocicleta roja"));
            BancoPreguntas.Add(new Question("Última letra del alfabeto griego", "Omega", "Alpha", "Zeta", "Beta", "Omega"));
            BancoPreguntas.Add(new Question(" Reptil cuya piel cambia de color", "Cobra", "Iguana", " Camaleón", "Lagarto", " Camaleón"));
            BancoPreguntas.Add(new Question("Ciudad italiana conocida como La Novia del Mar", "Roma", "Venecia", "Florencia", "Marselle", "Venecia "));
            BancoPreguntas.Add(new Question("Número de años que debes tener de casado para festejar tus bodas de oro", "25", "50", "60", "80", "50"));
            BancoPreguntas.Add(new Question("Horas que, en promedio, duerme al día un gato", "12", "13", "14", "15", "14"));
            BancoPreguntas.Add(new Question("Órgano del cuerpo que produce la bilis", "Hígado", "Páncreas", "Riñón", "Corazón", "Hígado"));
            BancoPreguntas.Add(new Question("Década en que se terminó de construir el Empire State de Nueva York", "Cincuenta", "Cuarenta", "Treinta", "Veinte", "Treinta"));
            BancoPreguntas.Add(new Question("Es la bebida alcohólica más importante de Japón, destilada del arroz", "Umeshu", "Sake", "Awamori", "Isinori", "Sake"));
            BancoPreguntas.Add(new Question("¿En qué país se encuentra la Torre de Pissa?", "Gran Bretaña", "España", "Francía", "Italia", "Italia"));
        }

    }
}
