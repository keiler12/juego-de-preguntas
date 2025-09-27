using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_juego
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        // Mueve el método fuera del constructor
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter || keyData == Keys.Space)
            {
                return true; // bloquea Enter y Space
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            lblinstrucciones.BackColor = Color.Transparent;
            lblinstrucciones.Font = new Font("Century Gothic", 15, FontStyle.Bold);
            lblinstrucciones.ForeColor = Color.Black;
            lblinstrucciones.TextAlign = ContentAlignment.MiddleCenter;

            lblniveles.BackColor = Color.Transparent;
            lblniveles.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            lblniveles.ForeColor = Color.DarkViolet;
           
            lbltextoniveles.BackColor = Color.Transparent;
            lbltextoniveles.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            lbltextoniveles.ForeColor = Color.Black;
            

            lblcomodines.BackColor = Color.Transparent;
            lblcomodines.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            lblcomodines.ForeColor = Color.DarkViolet;
            

            lbltextocomodines.BackColor = Color.Transparent;
            lbltextocomodines.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            lbltextocomodines.ForeColor = Color.Black;
       

            lblcontador.BackColor = Color.Transparent;
            lblcontador.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            lblcontador.ForeColor = Color.DarkViolet;
     

            lbltextocontador.BackColor = Color.Transparent;
            lbltextocontador.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            lbltextocontador.ForeColor = Color.Black;
       
            lblpuntaje.BackColor = Color.Transparent;
            lblpuntaje.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            lblpuntaje.ForeColor = Color.DarkViolet;
          

            lbltextopuntaje.BackColor = Color.Transparent;
            lbltextopuntaje.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            lbltextopuntaje.ForeColor = Color.Black;
          

            panel1.BackColor = Color.FromArgb(180, 255, 255, 255); // semi-transparente
            panel2.BackColor = Color.FromArgb(180, 255, 255, 255); // semi-transparente
            panel3.BackColor = Color.FromArgb(180, 255, 255, 255); // semi-transparente
            panel4.BackColor = Color.FromArgb(180, 255, 255, 255); // semi-transparente

            btnatras.BackColor = Color.FromArgb(203, 46, 10);
            btnatras.FlatStyle = FlatStyle.Flat;
            btnatras.FlatAppearance.BorderSize = 0;
            btnatras.ForeColor = Color.White;
            btnatras.Font = new Font("Century", 10, FontStyle.Bold);

        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            Form1 atras = new Form1();
            atras.Show();
            this.Hide();
        }
    }
}
