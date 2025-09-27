namespace Proyecto_juego
{
    partial class Form5
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
            this.labelpreguntas = new System.Windows.Forms.Label();
            this.btnopcion4 = new System.Windows.Forms.Button();
            this.btnopcion3 = new System.Windows.Forms.Button();
            this.btnopcion2 = new System.Windows.Forms.Button();
            this.btnopcion1 = new System.Windows.Forms.Button();
            this.lblpuntaje = new System.Windows.Forms.Label();
            this.timerPreguntas = new System.Windows.Forms.Timer(this.components);
            this.panelpuntaje = new System.Windows.Forms.Panel();
            this.lblpuntaje2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelconteo = new System.Windows.Forms.Panel();
            this.lblTiempoPregunta = new System.Windows.Forms.Label();
            this.panelpuntaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelconteo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelpreguntas
            // 
            this.labelpreguntas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelpreguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpreguntas.Location = new System.Drawing.Point(0, 0);
            this.labelpreguntas.MaximumSize = new System.Drawing.Size(0, 60);
            this.labelpreguntas.Name = "labelpreguntas";
            this.labelpreguntas.Size = new System.Drawing.Size(800, 60);
            this.labelpreguntas.TabIndex = 1;
            this.labelpreguntas.Text = "Preguntas";
            this.labelpreguntas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelpreguntas.Click += new System.EventHandler(this.labelpreguntas_Click);
            // 
            // btnopcion4
            // 
            this.btnopcion4.Location = new System.Drawing.Point(499, 393);
            this.btnopcion4.Name = "btnopcion4";
            this.btnopcion4.Size = new System.Drawing.Size(165, 45);
            this.btnopcion4.TabIndex = 15;
            this.btnopcion4.Text = "Opcion 4";
            this.btnopcion4.UseVisualStyleBackColor = true;
            this.btnopcion4.Click += new System.EventHandler(this.btnopcion4_Click);
            // 
            // btnopcion3
            // 
            this.btnopcion3.Location = new System.Drawing.Point(499, 333);
            this.btnopcion3.Name = "btnopcion3";
            this.btnopcion3.Size = new System.Drawing.Size(165, 43);
            this.btnopcion3.TabIndex = 14;
            this.btnopcion3.Text = "Opcion 3";
            this.btnopcion3.UseVisualStyleBackColor = true;
            this.btnopcion3.Click += new System.EventHandler(this.btnopcion3_Click);
            // 
            // btnopcion2
            // 
            this.btnopcion2.Location = new System.Drawing.Point(154, 393);
            this.btnopcion2.Name = "btnopcion2";
            this.btnopcion2.Size = new System.Drawing.Size(165, 45);
            this.btnopcion2.TabIndex = 13;
            this.btnopcion2.Text = "Opcion 2";
            this.btnopcion2.UseVisualStyleBackColor = true;
            this.btnopcion2.Click += new System.EventHandler(this.btnopcion2_Click);
            // 
            // btnopcion1
            // 
            this.btnopcion1.Location = new System.Drawing.Point(154, 331);
            this.btnopcion1.Name = "btnopcion1";
            this.btnopcion1.Size = new System.Drawing.Size(165, 45);
            this.btnopcion1.TabIndex = 12;
            this.btnopcion1.Text = "Opcion 1";
            this.btnopcion1.UseVisualStyleBackColor = true;
            this.btnopcion1.Click += new System.EventHandler(this.btnopcion1_Click);
            // 
            // lblpuntaje
            // 
            this.lblpuntaje.AutoSize = true;
            this.lblpuntaje.Location = new System.Drawing.Point(65, 129);
            this.lblpuntaje.Name = "lblpuntaje";
            this.lblpuntaje.Size = new System.Drawing.Size(0, 13);
            this.lblpuntaje.TabIndex = 16;
            // 
            // timerPreguntas
            // 
            this.timerPreguntas.Tick += new System.EventHandler(this.timerPreguntas_Tick);
            // 
            // panelpuntaje
            // 
            this.panelpuntaje.Controls.Add(this.lblpuntaje2);
            this.panelpuntaje.Location = new System.Drawing.Point(12, 81);
            this.panelpuntaje.Name = "panelpuntaje";
            this.panelpuntaje.Size = new System.Drawing.Size(158, 40);
            this.panelpuntaje.TabIndex = 19;
            // 
            // lblpuntaje2
            // 
            this.lblpuntaje2.AutoSize = true;
            this.lblpuntaje2.Location = new System.Drawing.Point(26, 11);
            this.lblpuntaje2.Name = "lblpuntaje2";
            this.lblpuntaje2.Size = new System.Drawing.Size(55, 13);
            this.lblpuntaje2.TabIndex = 12;
            this.lblpuntaje2.Text = "Puntaje: 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(194, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 247);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panelconteo
            // 
            this.panelconteo.Controls.Add(this.lblTiempoPregunta);
            this.panelconteo.Location = new System.Drawing.Point(656, 81);
            this.panelconteo.Name = "panelconteo";
            this.panelconteo.Size = new System.Drawing.Size(125, 40);
            this.panelconteo.TabIndex = 20;
            // 
            // lblTiempoPregunta
            // 
            this.lblTiempoPregunta.AutoSize = true;
            this.lblTiempoPregunta.Location = new System.Drawing.Point(33, 6);
            this.lblTiempoPregunta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiempoPregunta.Name = "lblTiempoPregunta";
            this.lblTiempoPregunta.Size = new System.Drawing.Size(40, 13);
            this.lblTiempoPregunta.TabIndex = 13;
            this.lblTiempoPregunta.Text = "conteo";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_juego.Properties.Resources.WhatsApp_Image_2025_09_16_at_2_28_30_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelconteo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelpuntaje);
            this.Controls.Add(this.lblpuntaje);
            this.Controls.Add(this.btnopcion4);
            this.Controls.Add(this.btnopcion3);
            this.Controls.Add(this.btnopcion2);
            this.Controls.Add(this.btnopcion1);
            this.Controls.Add(this.labelpreguntas);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panelpuntaje.ResumeLayout(false);
            this.panelpuntaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelconteo.ResumeLayout(false);
            this.panelconteo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelpreguntas;
        private System.Windows.Forms.Button btnopcion4;
        private System.Windows.Forms.Button btnopcion3;
        private System.Windows.Forms.Button btnopcion2;
        private System.Windows.Forms.Button btnopcion1;
        private System.Windows.Forms.Label lblpuntaje;
        private System.Windows.Forms.Timer timerPreguntas;
        private System.Windows.Forms.Panel panelpuntaje;
        private System.Windows.Forms.Label lblpuntaje2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelconteo;
        private System.Windows.Forms.Label lblTiempoPregunta;
    }
}