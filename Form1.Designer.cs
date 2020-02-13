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
            this.components = new System.ComponentModel.Container();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.opt4 = new System.Windows.Forms.RadioButton();
            this.opt3 = new System.Windows.Forms.RadioButton();
            this.opt2 = new System.Windows.Forms.RadioButton();
            this.opt1 = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(83, 266);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(139, 44);
            this.btnComenzar.TabIndex = 0;
            this.btnComenzar.Text = "COMENZAR";
            this.toolTip1.SetToolTip(this.btnComenzar, "Perra :v");
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "JUEGO DE LA OCA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opt4);
            this.groupBox1.Controls.Add(this.opt3);
            this.groupBox1.Controls.Add(this.opt2);
            this.groupBox1.Controls.Add(this.opt1);
            this.groupBox1.Location = new System.Drawing.Point(68, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 152);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Número de jugadores";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // opt4
            // 
            this.opt4.AutoSize = true;
            this.opt4.Location = new System.Drawing.Point(26, 112);
            this.opt4.Name = "opt4";
            this.opt4.Size = new System.Drawing.Size(37, 21);
            this.opt4.TabIndex = 3;
            this.opt4.TabStop = true;
            this.opt4.Text = "4";
            this.opt4.UseVisualStyleBackColor = true;
            // 
            // opt3
            // 
            this.opt3.AutoSize = true;
            this.opt3.Location = new System.Drawing.Point(26, 85);
            this.opt3.Name = "opt3";
            this.opt3.Size = new System.Drawing.Size(37, 21);
            this.opt3.TabIndex = 2;
            this.opt3.TabStop = true;
            this.opt3.Text = "3";
            this.opt3.UseVisualStyleBackColor = true;
            // 
            // opt2
            // 
            this.opt2.AutoSize = true;
            this.opt2.Location = new System.Drawing.Point(26, 58);
            this.opt2.Name = "opt2";
            this.opt2.Size = new System.Drawing.Size(37, 21);
            this.opt2.TabIndex = 1;
            this.opt2.TabStop = true;
            this.opt2.Text = "2";
            this.opt2.UseVisualStyleBackColor = true;
            // 
            // opt1
            // 
            this.opt1.AutoSize = true;
            this.opt1.Location = new System.Drawing.Point(26, 31);
            this.opt1.Name = "opt1";
            this.opt1.Size = new System.Drawing.Size(37, 21);
            this.opt1.TabIndex = 0;
            this.opt1.TabStop = true;
            this.opt1.Text = "1";
            this.opt1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 343);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComenzar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton opt4;
        private System.Windows.Forms.RadioButton opt3;
        private System.Windows.Forms.RadioButton opt2;
        private System.Windows.Forms.RadioButton opt1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

