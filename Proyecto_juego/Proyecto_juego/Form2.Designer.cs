namespace Proyecto_juego
{
    partial class Form2
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
            this.btnfacil = new System.Windows.Forms.Button();
            this.lbldificultad = new System.Windows.Forms.Label();
            this.btnintermedio = new System.Windows.Forms.Button();
            this.btndificil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnatras = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnfacil
            // 
            this.btnfacil.Location = new System.Drawing.Point(84, 67);
            this.btnfacil.Name = "btnfacil";
            this.btnfacil.Size = new System.Drawing.Size(148, 28);
            this.btnfacil.TabIndex = 0;
            this.btnfacil.Text = "Easy";
            this.btnfacil.UseVisualStyleBackColor = true;
            this.btnfacil.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbldificultad
            // 
            this.lbldificultad.AutoSize = true;
            this.lbldificultad.Location = new System.Drawing.Point(54, 11);
            this.lbldificultad.Name = "lbldificultad";
            this.lbldificultad.Size = new System.Drawing.Size(108, 13);
            this.lbldificultad.TabIndex = 1;
            this.lbldificultad.Text = "Seleccionar dificultad";
            this.lbldificultad.Click += new System.EventHandler(this.lbldificultad_Click);
            // 
            // btnintermedio
            // 
            this.btnintermedio.Location = new System.Drawing.Point(84, 121);
            this.btnintermedio.Name = "btnintermedio";
            this.btnintermedio.Size = new System.Drawing.Size(148, 28);
            this.btnintermedio.TabIndex = 2;
            this.btnintermedio.Text = "Intermediate";
            this.btnintermedio.UseVisualStyleBackColor = true;
            this.btnintermedio.Click += new System.EventHandler(this.btnintermedio_Click);
            // 
            // btndificil
            // 
            this.btndificil.Location = new System.Drawing.Point(84, 171);
            this.btndificil.Name = "btndificil";
            this.btndificil.Size = new System.Drawing.Size(148, 28);
            this.btndificil.TabIndex = 3;
            this.btndificil.Text = "Hard";
            this.btndificil.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbldificultad);
            this.panel1.Controls.Add(this.btndificil);
            this.panel1.Controls.Add(this.btnfacil);
            this.panel1.Controls.Add(this.btnintermedio);
            this.panel1.Location = new System.Drawing.Point(227, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 242);
            this.panel1.TabIndex = 4;
            // 
            // btnatras
            // 
            this.btnatras.Location = new System.Drawing.Point(12, 12);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(81, 31);
            this.btnatras.TabIndex = 5;
            this.btnatras.Text = "< Atras";
            this.btnatras.UseVisualStyleBackColor = true;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_juego.Properties.Resources.istockphoto_1342416557_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfacil;
        private System.Windows.Forms.Label lbldificultad;
        private System.Windows.Forms.Button btnintermedio;
        private System.Windows.Forms.Button btndificil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnatras;
    }
}