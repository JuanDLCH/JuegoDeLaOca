namespace JuegoDeLaOca
{
    partial class Tablero
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
            this.components = new System.ComponentModel.Container();
            this.imgJug1 = new System.Windows.Forms.PictureBox();
            this.timerDado = new System.Windows.Forms.Timer(this.components);
            this.imgJug2 = new System.Windows.Forms.PictureBox();
            this.imgJug3 = new System.Windows.Forms.PictureBox();
            this.imgJug4 = new System.Windows.Forms.PictureBox();
            this.timerDadoMalo = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgJug1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJug2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJug3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJug4)).BeginInit();
            this.SuspendLayout();
            // 
            // imgJug1
            // 
            this.imgJug1.BackColor = System.Drawing.Color.Transparent;
            this.imgJug1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgJug1.Image = global::JuegoDeLaOca.Resource1.FIchaRoja;
            this.imgJug1.Location = new System.Drawing.Point(155, 507);
            this.imgJug1.Name = "imgJug1";
            this.imgJug1.Size = new System.Drawing.Size(119, 79);
            this.imgJug1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgJug1.TabIndex = 0;
            this.imgJug1.TabStop = false;
            // 
            // timerDado
            // 
            this.timerDado.Interval = 4000;
            this.timerDado.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imgJug2
            // 
            this.imgJug2.BackColor = System.Drawing.Color.Transparent;
            this.imgJug2.Image = global::JuegoDeLaOca.Resource1.FichaAzul1;
            this.imgJug2.Location = new System.Drawing.Point(155, 507);
            this.imgJug2.Name = "imgJug2";
            this.imgJug2.Size = new System.Drawing.Size(119, 79);
            this.imgJug2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgJug2.TabIndex = 1;
            this.imgJug2.TabStop = false;
            // 
            // imgJug3
            // 
            this.imgJug3.BackColor = System.Drawing.Color.Transparent;
            this.imgJug3.Image = global::JuegoDeLaOca.Resource1.FichaVerde;
            this.imgJug3.Location = new System.Drawing.Point(155, 507);
            this.imgJug3.Name = "imgJug3";
            this.imgJug3.Size = new System.Drawing.Size(119, 79);
            this.imgJug3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgJug3.TabIndex = 2;
            this.imgJug3.TabStop = false;
            // 
            // imgJug4
            // 
            this.imgJug4.BackColor = System.Drawing.Color.Transparent;
            this.imgJug4.Image = global::JuegoDeLaOca.Resource1.FichaNegra1;
            this.imgJug4.Location = new System.Drawing.Point(155, 507);
            this.imgJug4.Name = "imgJug4";
            this.imgJug4.Size = new System.Drawing.Size(119, 79);
            this.imgJug4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgJug4.TabIndex = 3;
            this.imgJug4.TabStop = false;
            // 
            // timerDadoMalo
            // 
            this.timerDadoMalo.Interval = 3500;
            this.timerDadoMalo.Tick += new System.EventHandler(this.timerDadoMalo_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Turno de: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 625);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usa la tecla \"D\" para lanzar el dado";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Tablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoDeLaOca.Resource1.Tablero1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgJug4);
            this.Controls.Add(this.imgJug3);
            this.Controls.Add(this.imgJug2);
            this.Controls.Add(this.imgJug1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Tablero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tablero";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tablero_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgJug1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJug2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJug3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJug4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgJug1;
        private System.Windows.Forms.Timer timerDado;
        private System.Windows.Forms.PictureBox imgJug2;
        private System.Windows.Forms.PictureBox imgJug3;
        private System.Windows.Forms.PictureBox imgJug4;
        private System.Windows.Forms.Timer timerDadoMalo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}