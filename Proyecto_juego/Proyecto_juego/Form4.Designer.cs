using System;

namespace Proyecto_juego
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.btnopcion1 = new System.Windows.Forms.Button();
            this.btnopcion2 = new System.Windows.Forms.Button();
            this.btnopcion3 = new System.Windows.Forms.Button();
            this.btnopcion4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnpausa = new System.Windows.Forms.Button();
            this.lblpuntaje = new System.Windows.Forms.Label();
            this.lblTiempoPregunta = new System.Windows.Forms.Label();
            this.timerPreguntas = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panelconteo = new System.Windows.Forms.Panel();
            this.panelpuntaje = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelconteo.SuspendLayout();
            this.panelpuntaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.MaximumSize = new System.Drawing.Size(0, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preguntas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Paint += new System.Windows.Forms.PaintEventHandler(this.label1_Paint);
            // 
            // btnopcion1
            // 
            this.btnopcion1.Location = new System.Drawing.Point(216, 333);
            this.btnopcion1.Name = "btnopcion1";
            this.btnopcion1.Size = new System.Drawing.Size(101, 35);
            this.btnopcion1.TabIndex = 6;
            this.btnopcion1.Text = "Opcion 1";
            this.btnopcion1.UseVisualStyleBackColor = true;
            this.btnopcion1.Click += new System.EventHandler(this.btnvenus_Click);
            // 
            // btnopcion2
            // 
            this.btnopcion2.Location = new System.Drawing.Point(486, 333);
            this.btnopcion2.Name = "btnopcion2";
            this.btnopcion2.Size = new System.Drawing.Size(102, 35);
            this.btnopcion2.TabIndex = 7;
            this.btnopcion2.Text = "Opcion 2";
            this.btnopcion2.UseVisualStyleBackColor = true;
            this.btnopcion2.Click += new System.EventHandler(this.btntierra_Click_1);
            // 
            // btnopcion3
            // 
            this.btnopcion3.Location = new System.Drawing.Point(218, 403);
            this.btnopcion3.Name = "btnopcion3";
            this.btnopcion3.Size = new System.Drawing.Size(99, 35);
            this.btnopcion3.TabIndex = 8;
            this.btnopcion3.Text = "Opcion 3";
            this.btnopcion3.UseVisualStyleBackColor = true;
            this.btnopcion3.Click += new System.EventHandler(this.btnmercurio_Click);
            // 
            // btnopcion4
            // 
            this.btnopcion4.Location = new System.Drawing.Point(487, 403);
            this.btnopcion4.Name = "btnopcion4";
            this.btnopcion4.Size = new System.Drawing.Size(101, 35);
            this.btnopcion4.TabIndex = 9;
            this.btnopcion4.Text = "Opcion 4";
            this.btnopcion4.UseVisualStyleBackColor = true;
            this.btnopcion4.Click += new System.EventHandler(this.btnmarte_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(216, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 247);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnpausa
            // 
            this.btnpausa.Location = new System.Drawing.Point(12, 12);
            this.btnpausa.Name = "btnpausa";
            this.btnpausa.Size = new System.Drawing.Size(44, 35);
            this.btnpausa.TabIndex = 11;
            this.btnpausa.Text = "| |";
            this.btnpausa.UseVisualStyleBackColor = true;
            // 
            // lblpuntaje
            // 
            this.lblpuntaje.AutoSize = true;
            this.lblpuntaje.Location = new System.Drawing.Point(26, 11);
            this.lblpuntaje.Name = "lblpuntaje";
            this.lblpuntaje.Size = new System.Drawing.Size(55, 13);
            this.lblpuntaje.TabIndex = 12;
            this.lblpuntaje.Text = "Puntaje: 0";
            this.lblpuntaje.Click += new System.EventHandler(this.lblpuntaje_Click);
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
            this.lblTiempoPregunta.Click += new System.EventHandler(this.lblTiempoPregunta_Click);
            // 
            // timerPreguntas
            // 
            this.timerPreguntas.Tick += new System.EventHandler(this.timerPreguntas_Tick);
            // 
            // panelconteo
            // 
            this.panelconteo.Controls.Add(this.lblTiempoPregunta);
            this.panelconteo.Location = new System.Drawing.Point(635, 63);
            this.panelconteo.Name = "panelconteo";
            this.panelconteo.Size = new System.Drawing.Size(125, 40);
            this.panelconteo.TabIndex = 14;
            // 
            // panelpuntaje
            // 
            this.panelpuntaje.Controls.Add(this.lblpuntaje);
            this.panelpuntaje.Location = new System.Drawing.Point(22, 63);
            this.panelpuntaje.Name = "panelpuntaje";
            this.panelpuntaje.Size = new System.Drawing.Size(158, 40);
            this.panelpuntaje.TabIndex = 15;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_juego.Properties.Resources.WhatsApp_Image_2025_09_16_at_2_28_30_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelpuntaje);
            this.Controls.Add(this.panelconteo);
            this.Controls.Add(this.btnpausa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnopcion4);
            this.Controls.Add(this.btnopcion3);
            this.Controls.Add(this.btnopcion2);
            this.Controls.Add(this.btnopcion1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelconteo.ResumeLayout(false);
            this.panelconteo.PerformLayout();
            this.panelpuntaje.ResumeLayout(false);
            this.panelpuntaje.PerformLayout();
            this.ResumeLayout(false);

        }

        private void btntierra_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnopcion1;
        private System.Windows.Forms.Button btnopcion2;
        private System.Windows.Forms.Button btnopcion3;
        private System.Windows.Forms.Button btnopcion4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnpausa;
        private System.Windows.Forms.Label lblpuntaje;
        private System.Windows.Forms.Label lblTiempoPregunta;
        private System.Windows.Forms.Timer timerPreguntas;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panelconteo;
        private System.Windows.Forms.Panel panelpuntaje;
    }
}