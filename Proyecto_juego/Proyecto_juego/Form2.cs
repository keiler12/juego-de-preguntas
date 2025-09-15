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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lbldificultad_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            //dificultad
            lbldificultad.Font = new Font("Century Gothic", 15, FontStyle.Bold);
            lbldificultad.ForeColor = Color.Black;
            lbldificultad.BackColor = Color.Transparent;
            lbldificultad.TextAlign = ContentAlignment.MiddleCenter;

            //Botón easy
            btnfacil.BackColor = Color.FromArgb(46, 204, 113);
            btnfacil.FlatStyle = FlatStyle.Flat;
            btnfacil.FlatAppearance.BorderSize = 0;
            btnfacil.ForeColor = Color.White;
            btnfacil.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            btnfacil.Cursor = Cursors.Hand;

            //Botón intermediate
            btnintermedio.BackColor = Color.FromArgb(241, 196, 15);
            btnintermedio.FlatStyle = FlatStyle.Flat;
            btnintermedio.FlatAppearance.BorderSize = 0;
            btnintermedio.ForeColor = Color.White;
            btnintermedio.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            btnintermedio.Cursor = Cursors.Hand;

            btndificil.BackColor = Color.FromArgb(231, 76, 60);
            btndificil.FlatStyle = FlatStyle.Flat;
            btndificil.FlatAppearance.BorderSize = 0;
            btndificil  .ForeColor = Color.White;
            btndificil.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            btndificil.Cursor = Cursors.Hand;

            panel1.BackColor = Color.FromArgb(180, 255, 255, 255); // semi-transparente

        }
    }
}
