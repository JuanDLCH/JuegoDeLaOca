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
            ((System.ComponentModel.ISupportInitialize)(this.imgJug1)).BeginInit();
            this.SuspendLayout();
            // 
            // imgJug1
            // 
            this.imgJug1.Image = global::JuegoDeLaOca.Resource1.Tablero;
            this.imgJug1.Location = new System.Drawing.Point(407, 423);
            this.imgJug1.Name = "imgJug1";
            this.imgJug1.Size = new System.Drawing.Size(43, 79);
            this.imgJug1.TabIndex = 0;
            this.imgJug1.TabStop = false;
            // 
            // timerDado
            // 
            this.timerDado.Interval = 4000;
            this.timerDado.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Tablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoDeLaOca.Resource1.Tablero;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.imgJug1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Tablero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tablero";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tablero_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgJug1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgJug1;
        private System.Windows.Forms.Timer timerDado;
    }
}