namespace JuegoDeLaOca
{
    partial class Pregunta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpcA = new System.Windows.Forms.Button();
            this.btnOpcB = new System.Windows.Forms.Button();
            this.btnOpcC = new System.Windows.Forms.Button();
            this.btnOpcD = new System.Windows.Forms.Button();
            this.lbPregunta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpcA
            // 
            this.btnOpcA.Location = new System.Drawing.Point(41, 83);
            this.btnOpcA.Name = "btnOpcA";
            this.btnOpcA.Size = new System.Drawing.Size(187, 23);
            this.btnOpcA.TabIndex = 0;
            this.btnOpcA.Text = "button1";
            this.btnOpcA.UseVisualStyleBackColor = true;
            this.btnOpcA.Click += new System.EventHandler(this.btnOpcA_Click);
            // 
            // btnOpcB
            // 
            this.btnOpcB.Location = new System.Drawing.Point(41, 123);
            this.btnOpcB.Name = "btnOpcB";
            this.btnOpcB.Size = new System.Drawing.Size(187, 23);
            this.btnOpcB.TabIndex = 1;
            this.btnOpcB.Text = "button2";
            this.btnOpcB.UseVisualStyleBackColor = true;
            this.btnOpcB.Click += new System.EventHandler(this.btnOpcB_Click);
            // 
            // btnOpcC
            // 
            this.btnOpcC.Location = new System.Drawing.Point(41, 162);
            this.btnOpcC.Name = "btnOpcC";
            this.btnOpcC.Size = new System.Drawing.Size(187, 23);
            this.btnOpcC.TabIndex = 2;
            this.btnOpcC.Text = "button3";
            this.btnOpcC.UseVisualStyleBackColor = true;
            this.btnOpcC.Click += new System.EventHandler(this.btnOpcC_Click);
            // 
            // btnOpcD
            // 
            this.btnOpcD.Location = new System.Drawing.Point(41, 200);
            this.btnOpcD.Name = "btnOpcD";
            this.btnOpcD.Size = new System.Drawing.Size(187, 23);
            this.btnOpcD.TabIndex = 3;
            this.btnOpcD.Text = "button4";
            this.btnOpcD.UseVisualStyleBackColor = true;
            this.btnOpcD.Click += new System.EventHandler(this.btnOpcD_Click);
            // 
            // lbPregunta
            // 
            this.lbPregunta.AutoSize = true;
            this.lbPregunta.Location = new System.Drawing.Point(102, 33);
            this.lbPregunta.Name = "lbPregunta";
            this.lbPregunta.Size = new System.Drawing.Size(66, 17);
            this.lbPregunta.TabIndex = 4;
            this.lbPregunta.Text = "Pregunta";
            // 
            // Pregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 306);
            this.Controls.Add(this.lbPregunta);
            this.Controls.Add(this.btnOpcD);
            this.Controls.Add(this.btnOpcC);
            this.Controls.Add(this.btnOpcB);
            this.Controls.Add(this.btnOpcA);
            this.Name = "Pregunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregunta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pregunta_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpcA;
        private System.Windows.Forms.Button btnOpcB;
        private System.Windows.Forms.Button btnOpcC;
        private System.Windows.Forms.Button btnOpcD;
        private System.Windows.Forms.Label lbPregunta;
    }
}