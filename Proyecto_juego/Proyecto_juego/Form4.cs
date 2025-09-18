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
    public partial class Form4 : Form
    {
        // Variable para saber en qué pregunta estoy
        int indicePregunta = 0;

        // Matriz: [pregunta, respuesta correcta]
        string[,] banco_preguntas_facil = new string[,]

        {
              {"¿Cuál es el planeta más cercano al sol?", "Mercurio"},
              {"¿Cual es la capital de Francia?", "París"},
              {"¿Cuántos lados tiene un pentágono?", "5"},
              {"¿En qué continente está Egipto?", "África"},
              {"¿Qué animal es el rey de la selva?","Leon"},
              {"¿Quien es el protagonista de dragon ball?"," Son Goku"},
              {"¿cual es el océano mas grande del mundo?", "Pacifico" },
              {"¿Quien traicionó a Jesús?", "Judas"},
              {"¿En el anime Naruto, cual es el amor platónico de naruto?", "Sasuke"},
              {"cual es la mitad de uno","El ombligo"}

        };


        public Form4()
        {
            InitializeComponent();
        }

   

        private void Form4_Load(object sender, EventArgs e)
        {

        }

      
    }
}
