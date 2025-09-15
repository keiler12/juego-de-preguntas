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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        
            
            //Título
            lblbienvenido.Font = new Font("Century Gothic", 28, FontStyle.Bold);
            lblbienvenido.ForeColor = Color.Black;
            lblbienvenido.BackColor = Color.Transparent;
            lblbienvenido.TextAlign = ContentAlignment.MiddleCenter;
            
            //Nombre
            lblnombre.Font = new Font("Century Gothic", 15, FontStyle.Bold);
            lblnombre.ForeColor = Color.Black;
            lblnombre.BackColor = Color.Transparent;
            lblnombre.TextAlign = ContentAlignment.MiddleCenter;

            //nombre de los integrantes
            lblkeiler.Font = new Font("Century Gothic", 8, FontStyle.Bold);
            lblkeiler.ForeColor = Color.Black;
            lblkeiler.BackColor = Color.Transparent;
            lblkeiler.TextAlign = ContentAlignment.MiddleCenter;

            lblandres.Font = new Font("Century Gothic", 8, FontStyle.Bold);
            lblandres.ForeColor = Color.Black;
            lblandres.BackColor = Color.Transparent;
            lblandres.TextAlign = ContentAlignment.MiddleCenter;


            //Botón Start
            btnjugar.BackColor = Color.FromArgb(52, 152, 219); 
            btnjugar.FlatStyle = FlatStyle.Flat;
            btnjugar.FlatAppearance.BorderSize = 0;
            btnjugar.ForeColor = Color.White;
            btnjugar.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            btnjugar.Cursor = Cursors.Hand;

            //Botón Tutorial
            btntutorial.BackColor = Color.FromArgb(231, 76, 60); 
            btntutorial.FlatStyle = FlatStyle.Flat;
            btntutorial.FlatAppearance.BorderSize = 0;
            btntutorial.ForeColor = Color.White;
            btntutorial.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            btntutorial.Cursor = Cursors.Hand;

            // 🪟 Panel central 
            panel1.BackColor = Color.FromArgb(180, 255, 255, 255); // semi-transparente
        }

        

        private void lblbienvenido_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void lblandres_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void btnjugar_Click(object sender, EventArgs e)
        {
            Form2 start = new Form2();
            start.Show();
            this.Hide();

        }

        private void btntutorial_Click(object sender, EventArgs e)
        {
           
        }
    }
}
