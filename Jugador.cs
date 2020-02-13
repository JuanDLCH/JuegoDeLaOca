using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeLaOca
{
    public class Jugador
    {
        int[] VecposX = new int[] { 120, 270, 418, 562, 726 };
        int[] VecposY = new int[] { 412, 345, 275, 205, 138, 70 };
        public int[,] Tablero = new int[,] { { 30, 29, 28, 27, 26 },
                                             { 21, 22, 23, 24, 25 }, 
                                             { 20, 19, 18, 17, 16 }, 
                                             { 11, 12, 13, 14, 15 }, 
                                             { 10, 9, 8, 7, 6 }, 
                                             { 1, 2, 3, 4, 5 } };
        bool oca = false;
        bool penalizado = false;
        int posX;
        int posY;
        bool pierdeTurno = false;
        String nombre;
        int pos = 0;
        public Jugador(String nombre)
        {
            this.Nombre = nombre;
        }

        public void mover()
        {
            if (this.pos > 0 && this.pos < 6)
            {
                posX = VecposX[contar(Tablero, this.pos, 5)];
                posY = VecposY[0];
            }
            else if (this.pos < 11)
            {
                posX = VecposX[contar(Tablero, this.pos, 4)];
                posY = VecposY[1];
            }
            else if (this.pos < 16)
            {
                posX = VecposX[contar(Tablero, this.pos, 3)];
                posY = VecposY[2];
            }
            else if (this.pos < 21)
            {
                posX = VecposX[contar(Tablero, this.pos, 2)];
                posY = VecposY[3];
            }
            else if (this.pos < 26)
            {
                posX = VecposX[contar(Tablero, this.pos, 1)];
                posY = VecposY[4];
            }
            else
            {
                posX = VecposX[contar(Tablero, this.pos, 0)];
                posY = VecposY[5];
            }
        }

        //Cuenta cuántas columnas hay de izquierda a derecha hasta el número que se busca
        int contar(int[,] matriz, int num, int fil)
        {
            int valor = 0;
            for (int i = 0; i < 5; i++)
            {
                if (num == matriz[fil, i])
                {
                    valor = i;
                }
            }
            return valor;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Pos { get => pos; set => pos = value; }
        public int PosX { get => posX; set => posX = value; }
        public int PosY { get => posY; set => posY = value; }
        public bool PierdeTurno { get => pierdeTurno; set => pierdeTurno = value; }
        public bool Oca { get => oca; set => oca = value; }
        public bool Penalizado { get => penalizado; set => penalizado = value; }
    }
}
