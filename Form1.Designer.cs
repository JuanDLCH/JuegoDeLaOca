namespace JuegoDeLaOca
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnComenzar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.opt1 = new System.Windows.Forms.RadioButton();
            this.opt2 = new System.Windows.Forms.RadioButton();
            this.opt3 = new System.Windows.Forms.RadioButton();
            this.opt4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnComenzar
            // 
            this.btnComenzar.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnComenzar.Location = new System.Drawing.Point(53, 199);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(139, 44);
            this.btnComenzar.TabIndex = 0;
            this.btnComenzar.Text = "COMENZAR";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(92, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "JUEGO DE LA OCA";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Location = new System.Drawing.Point(264, 199);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(139, 44);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // opt1
            // 
            this.opt1.AutoSize = true;
            this.opt1.BackColor = System.Drawing.Color.White;
            this.opt1.Location = new System.Drawing.Point(18, 31);
            this.opt1.Name = "opt1";
            this.opt1.Size = new System.Drawing.Size(36, 22);
            this.opt1.TabIndex = 0;
            this.opt1.TabStop = true;
            this.opt1.Text = "1";
            this.opt1.UseVisualStyleBackColor = false;
            // 
            // opt2
            // 
            this.opt2.AutoSize = true;
            this.opt2.BackColor = System.Drawing.Color.White;
            this.opt2.Location = new System.Drawing.Point(18, 70);
            this.opt2.Name = "opt2";
            this.opt2.Size = new System.Drawing.Size(36, 22);
            this.opt2.TabIndex = 1;
            this.opt2.TabStop = true;
            this.opt2.Text = "2";
            this.opt2.UseVisualStyleBackColor = false;
            // 
            // opt3
            // 
            this.opt3.AutoSize = true;
            this.opt3.BackColor = System.Drawing.Color.White;
            this.opt3.Location = new System.Drawing.Point(189, 31);
            this.opt3.Name = "opt3";
            this.opt3.Size = new System.Drawing.Size(37, 22);
            this.opt3.TabIndex = 2;
            this.opt3.TabStop = true;
            this.opt3.Text = "3";
            this.opt3.UseVisualStyleBackColor = false;
            // 
            // opt4
            // 
            this.opt4.AutoSize = true;
            this.opt4.BackColor = System.Drawing.Color.White;
            this.opt4.Location = new System.Drawing.Point(189, 70);
            this.opt4.Name = "opt4";
            this.opt4.Size = new System.Drawing.Size(38, 22);
            this.opt4.TabIndex = 3;
            this.opt4.TabStop = true;
            this.opt4.Text = "4";
            this.opt4.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.opt4);
            this.groupBox1.Controls.Add(this.opt3);
            this.groupBox1.Controls.Add(this.opt2);
            this.groupBox1.Controls.Add(this.opt1);
            this.groupBox1.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(102, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 107);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Número de jugadores";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Juan Diego Londoño Ch\r\nSantiago Cano Duque";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoDeLaOca.Resource1.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(471, 310);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComenzar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego de la Oca";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RadioButton opt1;
        private System.Windows.Forms.RadioButton opt2;
        private System.Windows.Forms.RadioButton opt3;
        private System.Windows.Forms.RadioButton opt4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}

