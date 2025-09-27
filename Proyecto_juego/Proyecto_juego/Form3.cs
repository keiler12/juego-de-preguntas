using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_juego
{
    public partial class Form3 : Form
    {
        int contador = 3;
        string modo_juego;
        private SoundPlayer player;

        public Form3(string modo_juego)
        {
            InitializeComponent();
           this.modo_juego = modo_juego;
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

        private void Form3_Load(object sender, EventArgs e)
        {
            lblconteo.Text = contador.ToString();
            lblconteo.Font = new Font("Century Gothic", 48, FontStyle.Bold);
            lblconteo.ForeColor = Color.Aqua;
            lblconteo.TextAlign = ContentAlignment.MiddleCenter;
            lblconteo.BackColor = Color.Transparent;

            timer1.Interval = 1000;
            timer1.Start();


            string tempFile = Path.Combine(Path.GetTempPath(), "musica-conteo.wav");
            using (var resourceStream = Properties.Resources.musica_conteo)
            using (var fileStream = File.Create(tempFile))
            {
                resourceStream.CopyTo(fileStream);
            }

            //Inicializar SoundPlayer
            player = new SoundPlayer(tempFile);
            player.PlayLooping(); // Reproduce en bucle




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador--;

            if (contador > 0)
            {
                lblconteo.Text = contador.ToString();

                if (contador == 2) lblconteo.ForeColor = Color.Aqua;

                if (contador == 1) lblconteo.ForeColor = Color.Aqua;

              


                lblconteo.Font = new Font("centrry Gothic", 60, FontStyle.Bold);

            }
            else if (contador == 0)
            {
                lblconteo.Text = "Go!";
                lblconteo.ForeColor = Color.Aqua;
                lblconteo.Font = new Font("centrry Gothic", 60, FontStyle.Bold);
            }
            else 
            {
                timer1.Stop();

                if (modo_juego == "facil")
                {
                    Form4 facil = new Form4();
                    facil.Show();
                    this.Hide();
                }

                else if (modo_juego == "intermedio")
                {
                    Form5 intermedio = new Form5();
                    intermedio.Show();
                    this.Hide();
                }
                else  if (modo_juego == "dificil")
                {
                    Form6 dificil = new Form6();
                    dificil.Show();
                    this.Hide();
                }
                
            }
        }
    }
}
