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
    public partial class Form3 : Form
    {
        int contador = 3;

        public Form3()
        {
            InitializeComponent();
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

                Form4 form = new Form4();
                form.Show();
                this.Hide();
            }
        }
    }
}
