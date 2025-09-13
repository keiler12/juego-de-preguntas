namespace Proyecto_juego
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
            this.btnjugar = new System.Windows.Forms.Button();
            this.lblandres = new System.Windows.Forms.Label();
            this.lblkeiler = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnjugar
            // 
            this.btnjugar.Location = new System.Drawing.Point(343, 264);
            this.btnjugar.Name = "btnjugar";
            this.btnjugar.Size = new System.Drawing.Size(75, 23);
            this.btnjugar.TabIndex = 0;
            this.btnjugar.Text = "Jugar";
            this.btnjugar.UseVisualStyleBackColor = true;
            // 
            // lblandres
            // 
            this.lblandres.AutoSize = true;
            this.lblandres.Location = new System.Drawing.Point(466, 152);
            this.lblandres.Name = "lblandres";
            this.lblandres.Size = new System.Drawing.Size(40, 13);
            this.lblandres.TabIndex = 1;
            this.lblandres.Text = "Andres";
            // 
            // lblkeiler
            // 
            this.lblkeiler.AutoSize = true;
            this.lblkeiler.Location = new System.Drawing.Point(569, 102);
            this.lblkeiler.Name = "lblkeiler";
            this.lblkeiler.Size = new System.Drawing.Size(33, 13);
            this.lblkeiler.TabIndex = 2;
            this.lblkeiler.Text = "Keiler";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblkeiler);
            this.Controls.Add(this.lblandres);
            this.Controls.Add(this.btnjugar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnjugar;
        private System.Windows.Forms.Label lblandres;
        private System.Windows.Forms.Label lblkeiler;
        private System.Windows.Forms.Button button1;
    }
}

