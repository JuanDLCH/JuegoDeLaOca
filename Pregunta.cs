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
    public partial class Pregunta : Form
    {
        String correcta;
        public Pregunta(Question pregunta)
        {
            InitializeComponent();
            lbPregunta.Text = pregunta.Pregunta;
            btnOpcA.Text = pregunta.OpcionA;
            btnOpcB.Text = pregunta.OpcionB;
            btnOpcC.Text = pregunta.OpcionC;
            btnOpcD.Text = pregunta.OpcionD;
            correcta = pregunta.Correcta;
            asignarCorrecta();
        }

        void asignarCorrecta()
        {
            if (correcta.Equals(btnOpcA.Text))
            {
                btnOpcA.DialogResult = DialogResult.Yes;
                btnOpcB.DialogResult = DialogResult.No;
                btnOpcC.DialogResult = DialogResult.No;
                btnOpcD.DialogResult = DialogResult.No;
            }
            else if (correcta.Equals(btnOpcB.Text))
            {
                btnOpcA.DialogResult = DialogResult.No;
                btnOpcB.DialogResult = DialogResult.Yes;
                btnOpcC.DialogResult = DialogResult.No;
                btnOpcD.DialogResult = DialogResult.No;
            }
            else if (correcta.Equals(btnOpcC.Text))
            {
                btnOpcA.DialogResult = DialogResult.No;
                btnOpcB.DialogResult = DialogResult.No;
                btnOpcC.DialogResult = DialogResult.Yes;
                btnOpcD.DialogResult = DialogResult.No;
            }
            else
            {
                btnOpcA.DialogResult = DialogResult.No;
                btnOpcB.DialogResult = DialogResult.No;
                btnOpcC.DialogResult = DialogResult.No;
                btnOpcD.DialogResult = DialogResult.Yes;
            }
        }

        private void btnOpcA_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOpcB_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOpcC_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOpcD_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
