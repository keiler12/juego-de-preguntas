namespace Proyecto_juego
{
    partial class Form6
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnopcion4 = new System.Windows.Forms.Button();
            this.btnopcion3 = new System.Windows.Forms.Button();
            this.btnopcion2 = new System.Windows.Forms.Button();
            this.btnopcion1 = new System.Windows.Forms.Button();
            this.timerPreguntas = new System.Windows.Forms.Timer(this.components);
            this.panelconteo = new System.Windows.Forms.Panel();
            this.lblTiempoPregunta = new System.Windows.Forms.Label();
            this.panelpuntaje = new System.Windows.Forms.Panel();
            this.lblpuntaje3 = new System.Windows.Forms.Label();
            this.btnsaltar = new System.Windows.Forms.Button();
            this.btn5050 = new System.Windows.Forms.Button();
            this.btnpausa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelconteo.SuspendLayout();
            this.panelpuntaje.SuspendLayout();
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
            this.labelpreguntas.TabIndex = 2;
            this.labelpreguntas.Text = "Preguntas";
            this.labelpreguntas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelpreguntas.Click += new System.EventHandler(this.labelpreguntas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(179, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 236);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnopcion4
            // 
            this.btnopcion4.Location = new System.Drawing.Point(477, 393);
            this.btnopcion4.Name = "btnopcion4";
            this.btnopcion4.Size = new System.Drawing.Size(165, 45);
            this.btnopcion4.TabIndex = 19;
            this.btnopcion4.Text = "Opcion 4";
            this.btnopcion4.UseVisualStyleBackColor = true;
            this.btnopcion4.Click += new System.EventHandler(this.btnopcion4_Click);
            // 
            // btnopcion3
            // 
            this.btnopcion3.Location = new System.Drawing.Point(477, 318);
            this.btnopcion3.Name = "btnopcion3";
            this.btnopcion3.Size = new System.Drawing.Size(165, 43);
            this.btnopcion3.TabIndex = 18;
            this.btnopcion3.Text = "Opcion 3";
            this.btnopcion3.UseVisualStyleBackColor = true;
            this.btnopcion3.Click += new System.EventHandler(this.btnopcion3_Click);
            // 
            // btnopcion2
            // 
            this.btnopcion2.Location = new System.Drawing.Point(173, 393);
            this.btnopcion2.Name = "btnopcion2";
            this.btnopcion2.Size = new System.Drawing.Size(165, 45);
            this.btnopcion2.TabIndex = 17;
            this.btnopcion2.Text = "Opcion 2";
            this.btnopcion2.UseVisualStyleBackColor = true;
            this.btnopcion2.Click += new System.EventHandler(this.btnopcion2_Click);
            // 
            // btnopcion1
            // 
            this.btnopcion1.Location = new System.Drawing.Point(173, 318);
            this.btnopcion1.Name = "btnopcion1";
            this.btnopcion1.Size = new System.Drawing.Size(165, 45);
            this.btnopcion1.TabIndex = 16;
            this.btnopcion1.Text = "Opcion 1";
            this.btnopcion1.UseVisualStyleBackColor = true;
            this.btnopcion1.Click += new System.EventHandler(this.btnopcion1_Click);
            // 
            // timerPreguntas
            // 
            this.timerPreguntas.Tick += new System.EventHandler(this.timerPreguntas_Tick);
            // 
            // panelconteo
            // 
            this.panelconteo.Controls.Add(this.lblTiempoPregunta);
            this.panelconteo.Location = new System.Drawing.Point(663, 75);
            this.panelconteo.Name = "panelconteo";
            this.panelconteo.Size = new System.Drawing.Size(125, 40);
            this.panelconteo.TabIndex = 21;
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
            // panelpuntaje
            // 
            this.panelpuntaje.Controls.Add(this.lblpuntaje3);
            this.panelpuntaje.Location = new System.Drawing.Point(12, 75);
            this.panelpuntaje.Name = "panelpuntaje";
            this.panelpuntaje.Size = new System.Drawing.Size(158, 40);
            this.panelpuntaje.TabIndex = 22;
            // 
            // lblpuntaje3
            // 
            this.lblpuntaje3.AutoSize = true;
            this.lblpuntaje3.Location = new System.Drawing.Point(26, 11);
            this.lblpuntaje3.Name = "lblpuntaje3";
            this.lblpuntaje3.Size = new System.Drawing.Size(55, 13);
            this.lblpuntaje3.TabIndex = 12;
            this.lblpuntaje3.Text = "Puntaje: 0";
            // 
            // btnsaltar
            // 
            this.btnsaltar.Location = new System.Drawing.Point(670, 159);
            this.btnsaltar.Name = "btnsaltar";
            this.btnsaltar.Size = new System.Drawing.Size(92, 37);
            this.btnsaltar.TabIndex = 23;
            this.btnsaltar.Text = "Saltar";
            this.btnsaltar.UseVisualStyleBackColor = true;
            this.btnsaltar.Click += new System.EventHandler(this.btnsaltar_Click);
            // 
            // btn5050
            // 
            this.btn5050.Location = new System.Drawing.Point(670, 212);
            this.btn5050.Name = "btn5050";
            this.btn5050.Size = new System.Drawing.Size(92, 37);
            this.btn5050.TabIndex = 24;
            this.btn5050.Text = "50/50";
            this.btn5050.UseVisualStyleBackColor = true;
            this.btn5050.Click += new System.EventHandler(this.btn5050_Click);
            // 
            // btnpausa
            // 
            this.btnpausa.Location = new System.Drawing.Point(12, 159);
            this.btnpausa.Name = "btnpausa";
            this.btnpausa.Size = new System.Drawing.Size(54, 45);
            this.btnpausa.TabIndex = 25;
            this.btnpausa.Text = "| |";
            this.btnpausa.UseVisualStyleBackColor = true;
            this.btnpausa.Click += new System.EventHandler(this.btnpausa_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_juego.Properties.Resources.WhatsApp_Image_2025_09_16_at_2_28_30_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnpausa);
            this.Controls.Add(this.btn5050);
            this.Controls.Add(this.btnsaltar);
            this.Controls.Add(this.panelpuntaje);
            this.Controls.Add(this.panelconteo);
            this.Controls.Add(this.btnopcion4);
            this.Controls.Add(this.btnopcion3);
            this.Controls.Add(this.btnopcion2);
            this.Controls.Add(this.btnopcion1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelpreguntas);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelconteo.ResumeLayout(false);
            this.panelconteo.PerformLayout();
            this.panelpuntaje.ResumeLayout(false);
            this.panelpuntaje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelpreguntas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnopcion4;
        private System.Windows.Forms.Button btnopcion3;
        private System.Windows.Forms.Button btnopcion2;
        private System.Windows.Forms.Button btnopcion1;
        private System.Windows.Forms.Timer timerPreguntas;
        private System.Windows.Forms.Panel panelconteo;
        private System.Windows.Forms.Label lblTiempoPregunta;
        private System.Windows.Forms.Panel panelpuntaje;
        private System.Windows.Forms.Label lblpuntaje3;
        private System.Windows.Forms.Button btnsaltar;
        private System.Windows.Forms.Button btn5050;
        private System.Windows.Forms.Button btnpausa;
    }
}