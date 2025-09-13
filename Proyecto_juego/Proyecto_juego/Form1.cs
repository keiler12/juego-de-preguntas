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

        }

        private void lblbienvenido_Click(object sender, EventArgs e)
        {
            lblbienvenido.Font = new Font(lblbienvenido.Font.FontFamily, 60); // cambiamos el tamaño de la letra a 60
            lblbienvenido.AutoSize = false; // Desactiva AutoSize
            lblbienvenido.Font = new Font("Arial", 20, FontStyle.Regular); // Fija fuente, tamaño y estilo
            lblbienvenido.Size = new Size(250, 60); // Ajusta el espacio para el texto
            lblbienvenido.Text = "bienvenido"; // Asegura que tenga 
        }
    }
}
