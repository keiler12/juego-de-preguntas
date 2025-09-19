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
            this.label1 = new System.Windows.Forms.Label();
            this.btnvenus = new System.Windows.Forms.Button();
            this.btntierra = new System.Windows.Forms.Button();
            this.btnmercurio = new System.Windows.Forms.Button();
            this.btnmarte = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.label1.Text = "Cual es el planeta mas cercano al sol?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Paint += new System.Windows.Forms.PaintEventHandler(this.label1_Paint);
            // 
            // btnvenus
            // 
            this.btnvenus.Location = new System.Drawing.Point(216, 333);
            this.btnvenus.Name = "btnvenus";
            this.btnvenus.Size = new System.Drawing.Size(101, 35);
            this.btnvenus.TabIndex = 6;
            this.btnvenus.Text = "Venus";
            this.btnvenus.UseVisualStyleBackColor = true;
            this.btnvenus.Click += new System.EventHandler(this.btnvenus_Click);
            // 
            // btntierra
            // 
            this.btntierra.Location = new System.Drawing.Point(486, 333);
            this.btntierra.Name = "btntierra";
            this.btntierra.Size = new System.Drawing.Size(102, 35);
            this.btntierra.TabIndex = 7;
            this.btntierra.Text = "Tierra";
            this.btntierra.UseVisualStyleBackColor = true;
            this.btntierra.Click += new System.EventHandler(this.btntierra_Click_1);
            // 
            // btnmercurio
            // 
            this.btnmercurio.Location = new System.Drawing.Point(218, 403);
            this.btnmercurio.Name = "btnmercurio";
            this.btnmercurio.Size = new System.Drawing.Size(99, 35);
            this.btnmercurio.TabIndex = 8;
            this.btnmercurio.Text = "Mercurio";
            this.btnmercurio.UseVisualStyleBackColor = true;
            this.btnmercurio.Click += new System.EventHandler(this.btnmercurio_Click);
            // 
            // btnmarte
            // 
            this.btnmarte.Location = new System.Drawing.Point(487, 403);
            this.btnmarte.Name = "btnmarte";
            this.btnmarte.Size = new System.Drawing.Size(101, 35);
            this.btnmarte.TabIndex = 9;
            this.btnmarte.Text = "Marte";
            this.btnmarte.UseVisualStyleBackColor = true;
            this.btnmarte.Click += new System.EventHandler(this.btnmarte_Click);
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
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_juego.Properties.Resources.WhatsApp_Image_2025_09_16_at_2_28_30_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnmarte);
            this.Controls.Add(this.btnmercurio);
            this.Controls.Add(this.btntierra);
            this.Controls.Add(this.btnvenus);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void btntierra_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvenus;
        private System.Windows.Forms.Button btntierra;
        private System.Windows.Forms.Button btnmercurio;
        private System.Windows.Forms.Button btnmarte;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}