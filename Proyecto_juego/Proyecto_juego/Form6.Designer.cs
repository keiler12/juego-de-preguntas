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
            this.lblpuntaje3 = new System.Windows.Forms.Label();
            this.lblTiempoPregunta = new System.Windows.Forms.Label();
            this.timerPreguntas = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelpreguntas
            // 
            this.labelpreguntas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelpreguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpreguntas.Location = new System.Drawing.Point(0, 0);
            this.labelpreguntas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelpreguntas.MaximumSize = new System.Drawing.Size(0, 74);
            this.labelpreguntas.Name = "labelpreguntas";
            this.labelpreguntas.Size = new System.Drawing.Size(1067, 74);
            this.labelpreguntas.TabIndex = 2;
            this.labelpreguntas.Text = "Preguntas";
            this.labelpreguntas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelpreguntas.Click += new System.EventHandler(this.labelpreguntas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(239, 78);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(617, 290);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnopcion4
            // 
            this.btnopcion4.Location = new System.Drawing.Point(636, 484);
            this.btnopcion4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnopcion4.Name = "btnopcion4";
            this.btnopcion4.Size = new System.Drawing.Size(220, 55);
            this.btnopcion4.TabIndex = 19;
            this.btnopcion4.Text = "Opcion 4";
            this.btnopcion4.UseVisualStyleBackColor = true;
            this.btnopcion4.Click += new System.EventHandler(this.btnopcion4_Click);
            // 
            // btnopcion3
            // 
            this.btnopcion3.Location = new System.Drawing.Point(636, 391);
            this.btnopcion3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnopcion3.Name = "btnopcion3";
            this.btnopcion3.Size = new System.Drawing.Size(220, 53);
            this.btnopcion3.TabIndex = 18;
            this.btnopcion3.Text = "Opcion 3";
            this.btnopcion3.UseVisualStyleBackColor = true;
            this.btnopcion3.Click += new System.EventHandler(this.btnopcion3_Click);
            // 
            // btnopcion2
            // 
            this.btnopcion2.Location = new System.Drawing.Point(231, 484);
            this.btnopcion2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnopcion2.Name = "btnopcion2";
            this.btnopcion2.Size = new System.Drawing.Size(220, 55);
            this.btnopcion2.TabIndex = 17;
            this.btnopcion2.Text = "Opcion 2";
            this.btnopcion2.UseVisualStyleBackColor = true;
            this.btnopcion2.Click += new System.EventHandler(this.btnopcion2_Click);
            // 
            // btnopcion1
            // 
            this.btnopcion1.Location = new System.Drawing.Point(231, 391);
            this.btnopcion1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnopcion1.Name = "btnopcion1";
            this.btnopcion1.Size = new System.Drawing.Size(220, 55);
            this.btnopcion1.TabIndex = 16;
            this.btnopcion1.Text = "Opcion 1";
            this.btnopcion1.UseVisualStyleBackColor = true;
            this.btnopcion1.Click += new System.EventHandler(this.btnopcion1_Click);
            // 
            // lblpuntaje3
            // 
            this.lblpuntaje3.AutoSize = true;
            this.lblpuntaje3.Location = new System.Drawing.Point(38, 206);
            this.lblpuntaje3.Name = "lblpuntaje3";
            this.lblpuntaje3.Size = new System.Drawing.Size(62, 16);
            this.lblpuntaje3.TabIndex = 20;
            this.lblpuntaje3.Text = "Puntaje:0";
            // 
            // lblTiempoPregunta
            // 
            this.lblTiempoPregunta.AutoSize = true;
            this.lblTiempoPregunta.Location = new System.Drawing.Point(965, 78);
            this.lblTiempoPregunta.Name = "lblTiempoPregunta";
            this.lblTiempoPregunta.Size = new System.Drawing.Size(21, 16);
            this.lblTiempoPregunta.TabIndex = 21;
            this.lblTiempoPregunta.Text = "lbl";
            // 
            // timerPreguntas
            // 
            this.timerPreguntas.Tick += new System.EventHandler(this.timerPreguntas_Tick);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_juego.Properties.Resources.WhatsApp_Image_2025_09_16_at_2_28_30_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblTiempoPregunta);
            this.Controls.Add(this.lblpuntaje3);
            this.Controls.Add(this.btnopcion4);
            this.Controls.Add(this.btnopcion3);
            this.Controls.Add(this.btnopcion2);
            this.Controls.Add(this.btnopcion1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelpreguntas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelpreguntas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnopcion4;
        private System.Windows.Forms.Button btnopcion3;
        private System.Windows.Forms.Button btnopcion2;
        private System.Windows.Forms.Button btnopcion1;
        private System.Windows.Forms.Label lblpuntaje3;
        private System.Windows.Forms.Label lblTiempoPregunta;
        private System.Windows.Forms.Timer timerPreguntas;
    }
}