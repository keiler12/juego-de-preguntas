using System;
using System.Windows.Forms;
using System.Drawing; 
using System.Linq; 

namespace Proyecto_juego
{
    public partial class Form4 : Form
    {
        int indicePregunta = 0;

        // Matriz: [pregunta, opción1, opción2, opción3, opción4]
        string[,] preguntasOpciones = new string[,]
        {
            {"¿Cuál es el planeta más cercano al sol?", "Venus", "Tierra", "Mercurio", "Marte"},
            {"¿Cuál es la capital de Francia?", "Bordeaux", "París", "Marsella", "Monaco"},
            {"¿Cuántos lados tiene un pentágono?", "4", "5", "6", "8"},
            {"¿En qué continente está Egipto?", "Asia", "África", "Europa", "Oceanía"},
            {"¿Qué animal es el rey de la selva?", "Tigre", "Elefante", "León", "Gorila"},
            {"¿Quién es el protagonista de Dragon Ball?", "Vegeta", "Son Goku", "Piccolo", "Gohan"},
            {"¿Cuál es el océano más grande del mundo?", "Atlántico", "Índico", "Ártico", "Pacífico"},
            {"¿Quién traicionó a Jesús?", "Pedro", "Judas", "Juan", "Tomás"},
            {"¿En el anime Naruto, cuál es el amor platónico de Naruto?", "Sakura", "Hinata", "Sasuke", "Ino"},
            {"¿Cuál es la mitad de uno?", "El ombligo", "Cero", "Medio", "Uno"}
        };

        // Índice de la respuesta correcta para cada pregunta (0 a 3)
        int[] respuestasCorrectas = new int[]
        {
            2, // Mercurio
            1, // París
            1, // 5
            1, // África
            2, // León
            1, // Son Goku
            3, // Pacífico
            1, // Judas
            2, // Sasuke
            0  // El ombligo
        };

        
        readonly Image[] imagenesPreguntas = new Image[]
        {
            Properties.Resources.pregunta1,   // Para la pregunta 1
            Properties.Resources.pregunta2,   // Para la pregunta 2
            Properties.Resources.pregunta3,   // Para la pregunta 3
            Properties.Resources.pregunta4,   // Para la pregunta 4
            Properties.Resources.pregunta5,   // Para la pregunta 5
            Properties.Resources.pregunta6,   // Para la pregunta 6
            Properties.Resources.pregunta7,   // Para la pregunta 7
            Properties.Resources.pregunta8,   // Para la pregunta 8
            Properties.Resources.pregunta9,   // Para la pregunta 9
            Properties.Resources.pregunta10   // Para la pregunta 10
        };
        
        // Nueva estructura para mezclar preguntas, respuestas e imágenes
        private int[] ordenPreguntas;


        public Form4()
        {
            InitializeComponent();
            // Inicializa el orden aleatorio de las preguntas
            Random rnd = new Random();
            ordenPreguntas = Enumerable.Range(0, preguntasOpciones.GetLength(0)).OrderBy(x => rnd.Next()).ToArray();

        }


        private void Form4_Load(object sender, EventArgs e)
        {
            MostrarPregunta();
        }

        private void MostrarPregunta()
        {
            if (indicePregunta < preguntasOpciones.GetLength(0))
            {
                int idx = ordenPreguntas[indicePregunta];
                label1.Text = preguntasOpciones[idx, 0];
                btnvenus.Text = preguntasOpciones[idx, 1];
                btntierra.Text = preguntasOpciones[idx, 2];
                btnmercurio.Text = preguntasOpciones[idx, 3];
                btnmarte.Text = preguntasOpciones[idx, 4];

                // Mostrar imagen correspondiente a la pregunta y ajustar el modo de visualización
                pictureBox1.Image = imagenesPreguntas[idx];
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                label1.BackColor = Color.Transparent;
            }
            else
            {
                MessageBox.Show("¡Has terminado todas las preguntas!");
                this.Close();
            }
        }

        private void btnvenus_Click(object sender, EventArgs e)
        {

            // Método único para todos los botones de opción


            Button btn = sender as Button;
            int opcionSeleccionada = 0;

            // Determina qué botón fue presionado
            if (btn == btnvenus) opcionSeleccionada = 0;
            else if (btn == btntierra) opcionSeleccionada = 1;
            else if (btn == btnmercurio) opcionSeleccionada = 2;
            else if (btn == btnmarte) opcionSeleccionada = 3;

            int idx = ordenPreguntas[indicePregunta];
            if (opcionSeleccionada == respuestasCorrectas[idx])
            {
                MessageBox.Show("¡Respuesta correcta!");
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta. La respuesta correcta es: " +
                    preguntasOpciones[idx, respuestasCorrectas[idx] + 1]);
            }

            indicePregunta++;
            MostrarPregunta();

        }

        private void btnmercurio_Click(object sender, EventArgs e)
        { 

        // Método único para todos los botones de opción
            Button btn = sender as Button;
            int opcionSeleccionada = 0;

            // Determina qué botón fue presionado
            if (btn == btnvenus) opcionSeleccionada = 0;
            else if (btn == btntierra) opcionSeleccionada = 1;
            else if (btn == btnmercurio) opcionSeleccionada = 2;
            else if (btn == btnmarte) opcionSeleccionada = 3;

            int idx = ordenPreguntas[indicePregunta];
            if (opcionSeleccionada == respuestasCorrectas[idx])
            {
                MessageBox.Show("¡Respuesta correcta!");
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta. La respuesta correcta es: " +
                    preguntasOpciones[idx, respuestasCorrectas[idx] + 1]);
            }

            indicePregunta++;
            MostrarPregunta();
        }

        private void btntierra_Click_1(object sender, EventArgs e)
        {

        // Método único para todos los botones de opción
        
            Button btn = sender as Button;
            int opcionSeleccionada = 0;

            // Determina qué botón fue presionado
            if (btn == btnvenus) opcionSeleccionada = 0;
            else if (btn == btntierra) opcionSeleccionada = 1;
            else if (btn == btnmercurio) opcionSeleccionada = 2;
            else if (btn == btnmarte) opcionSeleccionada = 3;

            int idx = ordenPreguntas[indicePregunta];
            if (opcionSeleccionada == respuestasCorrectas[idx])
            {
                MessageBox.Show("¡Respuesta correcta!");
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta. La respuesta correcta es: " +
                    preguntasOpciones[idx, respuestasCorrectas[idx] + 1]);
            }

            indicePregunta++;
            MostrarPregunta();
        }

        private void btnmarte_Click(object sender, EventArgs e)
        {

            // Método único para todos los botones de opción

            Button btn = sender as Button;
            int opcionSeleccionada = 0;

            // Determina qué botón fue presionado
            if (btn == btnvenus) opcionSeleccionada = 0;
            else if (btn == btntierra) opcionSeleccionada = 1;
            else if (btn == btnmercurio) opcionSeleccionada = 2;
            else if (btn == btnmarte) opcionSeleccionada = 3;

            int idx = ordenPreguntas[indicePregunta];
            if (opcionSeleccionada == respuestasCorrectas[idx])
            {
                MessageBox.Show("¡Respuesta correcta!");
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta. La respuesta correcta es: " +
                    preguntasOpciones[idx, respuestasCorrectas[idx] + 1]);
            }

            indicePregunta++;
            MostrarPregunta();
        }
    }
}
