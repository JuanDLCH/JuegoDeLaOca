using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeLaOca
{
    public class Question
    {
        String pregunta;
        String opcionA, opcionB, opcionC, opcionD;
        String correcta;
        public Question(String pregunta, String opcionA, String opcionB, String opcionC, String opcionD, String correcta)
        {
            this.pregunta = pregunta;
            this.opcionA = opcionA;
            this.opcionB = opcionB;
            this.opcionC = opcionC;
            this.opcionD = opcionD;
            this.correcta = correcta;
        }

        public string Pregunta { get => pregunta; set => pregunta = value; }
        public string OpcionA { get => opcionA; set => opcionA = value; }
        public string OpcionB { get => opcionB; set => opcionB = value; }
        public string OpcionC { get => opcionC; set => opcionC = value; }
        public string OpcionD { get => opcionD; set => opcionD = value; }
        public string Correcta { get => correcta; set => correcta = value; }
    }
}
