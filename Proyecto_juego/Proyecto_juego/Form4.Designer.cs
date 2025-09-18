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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnvenus = new System.Windows.Forms.Button();
            this.btntierra = new System.Windows.Forms.Button();
            this.btnmercurio = new System.Windows.Forms.Button();
            this.btnmarte = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Proyecto_juego.Properties.Resources.WhatsApp_Image_2025_09_16_at_4_47_04_PM;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(219, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 212);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(230, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 47);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cual es el planeta mas cercano al sol?";
            // 
            // btnvenus
            // 
            this.btnvenus.Location = new System.Drawing.Point(230, 336);
            this.btnvenus.Name = "btnvenus";
            this.btnvenus.Size = new System.Drawing.Size(75, 23);
            this.btnvenus.TabIndex = 6;
            this.btnvenus.Text = "Venus";
            this.btnvenus.UseVisualStyleBackColor = true;
            // 
            // btntierra
            // 
            this.btntierra.Location = new System.Drawing.Point(495, 336);
            this.btntierra.Name = "btntierra";
            this.btntierra.Size = new System.Drawing.Size(75, 23);
            this.btntierra.TabIndex = 7;
            this.btntierra.Text = "Tierra";
            this.btntierra.UseVisualStyleBackColor = true;
            // 
            // btnmercurio
            // 
            this.btnmercurio.Location = new System.Drawing.Point(230, 398);
            this.btnmercurio.Name = "btnmercurio";
            this.btnmercurio.Size = new System.Drawing.Size(75, 23);
            this.btnmercurio.TabIndex = 8;
            this.btnmercurio.Text = "Mercurio";
            this.btnmercurio.UseVisualStyleBackColor = true;
            // 
            // btnmarte
            // 
            this.btnmarte.Location = new System.Drawing.Point(495, 398);
            this.btnmarte.Name = "btnmarte";
            this.btnmarte.Size = new System.Drawing.Size(75, 23);
            this.btnmarte.TabIndex = 9;
            this.btnmarte.Text = "Marte";
            this.btnmarte.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_juego.Properties.Resources.WhatsApp_Image_2025_09_16_at_2_28_30_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnmarte);
            this.Controls.Add(this.btnmercurio);
            this.Controls.Add(this.btntierra);
            this.Controls.Add(this.btnvenus);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvenus;
        private System.Windows.Forms.Button btntierra;
        private System.Windows.Forms.Button btnmercurio;
        private System.Windows.Forms.Button btnmarte;
    }
}