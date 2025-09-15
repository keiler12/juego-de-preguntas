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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnjugar = new System.Windows.Forms.Button();
            this.lblandres = new System.Windows.Forms.Label();
            this.lblkeiler = new System.Windows.Forms.Label();
            this.btntutorial = new System.Windows.Forms.Button();
            this.lblbienvenido = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnjugar
            // 
            this.btnjugar.Location = new System.Drawing.Point(100, 103);
            this.btnjugar.Name = "btnjugar";
            this.btnjugar.Size = new System.Drawing.Size(152, 29);
            this.btnjugar.TabIndex = 0;
            this.btnjugar.Text = "Start game";
            this.btnjugar.UseVisualStyleBackColor = true;
            this.btnjugar.Click += new System.EventHandler(this.btnjugar_Click);
            // 
            // lblandres
            // 
            this.lblandres.AutoSize = true;
            this.lblandres.Location = new System.Drawing.Point(30, 48);
            this.lblandres.Name = "lblandres";
            this.lblandres.Size = new System.Drawing.Size(121, 13);
            this.lblandres.TabIndex = 1;
            this.lblandres.Text = "Andres Martinez Medina";
            this.lblandres.Click += new System.EventHandler(this.lblandres_Click);
            // 
            // lblkeiler
            // 
            this.lblkeiler.AutoSize = true;
            this.lblkeiler.Location = new System.Drawing.Point(30, 9);
            this.lblkeiler.Name = "lblkeiler";
            this.lblkeiler.Size = new System.Drawing.Size(109, 13);
            this.lblkeiler.TabIndex = 2;
            this.lblkeiler.Text = "Keiler Medina Herrera";
            // 
            // btntutorial
            // 
            this.btntutorial.Location = new System.Drawing.Point(100, 155);
            this.btntutorial.Name = "btntutorial";
            this.btntutorial.Size = new System.Drawing.Size(152, 26);
            this.btntutorial.TabIndex = 3;
            this.btntutorial.Text = "Tutorial";
            this.btntutorial.UseVisualStyleBackColor = true;
            this.btntutorial.Click += new System.EventHandler(this.btntutorial_Click);
            // 
            // lblbienvenido
            // 
            this.lblbienvenido.AutoSize = true;
            this.lblbienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbienvenido.Location = new System.Drawing.Point(58, 12);
            this.lblbienvenido.Name = "lblbienvenido";
            this.lblbienvenido.Size = new System.Drawing.Size(216, 39);
            this.lblbienvenido.TabIndex = 4;
            this.lblbienvenido.Text = "Bienvenido a";
            this.lblbienvenido.Click += new System.EventHandler(this.lblbienvenido_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(117, 60);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(110, 24);
            this.lblnombre.TabIndex = 5;
            this.lblnombre.Text = "Quiz Master";
            this.lblnombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btntutorial);
            this.panel1.Controls.Add(this.lblbienvenido);
            this.panel1.Controls.Add(this.lblnombre);
            this.panel1.Controls.Add(this.btnjugar);
            this.panel1.Location = new System.Drawing.Point(278, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 212);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(730, 217);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(139, 50);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_juego.Properties.Resources.istockphoto_1342416557_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(893, 563);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblkeiler);
            this.Controls.Add(this.lblandres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnjugar;
        private System.Windows.Forms.Label lblandres;
        private System.Windows.Forms.Label lblkeiler;
        private System.Windows.Forms.Button btntutorial;
        private System.Windows.Forms.Label lblbienvenido;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

