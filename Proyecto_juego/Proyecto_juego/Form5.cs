using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_juego
{
    using System.IO;
    using System.Media;
    using System.Reflection.Emit;

    public partial class Form5 : Form
    {
        private SoundPlayer player;
        int indice_pregunta = 0;
        private int puntaje = 0;
        private const int TIEMPO_PREGUNTA_MAXIMO = 20;
        private int tiempoRestante;

        // Matriz: [pregunta, opción1, opción2, opción3, opción4]
        string[,] preguntas_opciones = new string[,]
        {
            {"¿En qué año cayó el muro de Berlín?", "1985", "1989", "1991", "1993"},
            {"En el anime 'Death Note',¿Cuál es el nombre del shinigami(Dios de la muerte) que deja care su libreta en el mundo humano siendo encontrada por Light Yagami?", "Rem", "Gelus", "Ryuk", "Sidoh"},
            {"¿Qué banda de rock británica lanzó el album 'The Dark Side of the Moon'en 1973?", "Led Zeppelin", "Queen", "The Beatles", "Pink Floyd"},
            {"¿Cual de los siguientes directores es conocido por sus películas de acción con estilo visual distintivo 'El origen', 'Inception', y 'El caballero de la noche'?", "Quentin Tarantino", "Christofer Nolan", "Martin Scorsese", "James Gunn"},
            {"¿Cual es la mejor instructor(a) de todo el SENA?", "Ronald", "Mara", "Luz", "Maristela"},
            {"¿En qué videojuego de 1980 se debe guiar a un personaje a través de un laberinto para comer puntos y evitar a los fantasma?", "Pac-man", "Donkey kong", "Space invaders", "Galaga"},
            {"¿Qué planeta del sistema solar es conocido por sus anillos los cuales están compuestos principalmente por partículas de hielo y roca?", "Marte", "Jupiter", "Saturno", "Urano"},
            {"¿Qué principio de la POO permite que un objeto tome multiples formas?", "Abstracción", "Herencia", "Encapsulamiento", "Polimorfismo"},
            {"¿Qué jugador ganó el balón de oro en el año 2006?", "Zidane", "Fabio Canavarro", "Buffon", "Kaká"},
            {"¿Cuál es la ciudad mas poblada del mundo?", "Nueva Dheli", "Pekin", "New York", "Tokio"}
        };

        // Índice de la respuesta correcta para cada pregunta (0 a 3)
        int[] respuestas_correctas = new int[]//usamos un array para guardar las respuestas correctas
        {
            1, // 1989
            2, // Ryuk
            3, // Pink floyd
            1, // Christofer Nolan
            3, // MAristela
            0, // Pac-man
            2, // Saturno
            3, // Polimorfismo
            1, // Canavarro
            3 // Tokio
        };

        readonly Image[] imagenesPreguntas = new Image[]// Array de imágenes para cada pregunta, sirve para mostrar la imagen correspondiente a cada pregunta
        {
            Properties.Resources.preguntaintermedio1,   // Para la pregunta 1
            Properties.Resources.preguntaintermedio2,   // Para la pregunta 2
            Properties.Resources.preguntaintermedio3,   // Para la pregunta 3
            Properties.Resources.preguntaintermedio4,   // Para la pregunta 4
            Properties.Resources.preguntaintermedio5,   // Para la pregunta 5
            Properties.Resources.preguntaintermedio6,   // Para la pregunta 6
            Properties.Resources.preguntaintermedio7,   // Para la pregunta 7
            Properties.Resources.preguntaintermedio8,   // Para la pregunta 8
            Properties.Resources.preguntaintermedio9,   // Para la pregunta 9
            Properties.Resources.preguntaintermedio10   // Para la pregunta 10
        };

        // Nueva estructura para mezclar preguntas, respuestas e imágenes
        private int[] ordenPreguntas;



        public Form5()
        {
            InitializeComponent();

            // Inicializa el orden aleatorio de las preguntas
            Random rnd = new Random();
            ordenPreguntas = Enumerable.Range(0, preguntas_opciones.GetLength(0)).OrderBy(x => rnd.Next()).ToArray();
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


        private void Form5_Load(object sender, EventArgs e)
        {
            //aqui va el código de estilo
            
            lblTiempoPregunta.Text = TIEMPO_PREGUNTA_MAXIMO.ToString();
            lblTiempoPregunta.Font = new Font("Century Gothic", 20, FontStyle.Bold);
            lblTiempoPregunta.ForeColor = Color.DarkGreen;
            lblTiempoPregunta.TextAlign = ContentAlignment.MiddleCenter;
            lblTiempoPregunta.BackColor = Color.Transparent;
            panelconteo.BackColor = Color.FromArgb(150, 255, 255, 255); // Fondo blanco semi-transparente

            MostrarPregunta();
            

            string tempFile = Path.Combine(Path.GetTempPath(), "musica_modo_facil.wav");
            using (var resourceStream = Properties.Resources.musica_modo_facil)
            using (var fileStream = File.Create(tempFile))
            {
                resourceStream.CopyTo(fileStream);
            }

            //Inicializar SoundPlayer
            player = new SoundPlayer(tempFile);
            player.PlayLooping(); // Reproduce en bucle

            // Aqui iniciamos el temporizador para las preguntas
            tiempoRestante = TIEMPO_PREGUNTA_MAXIMO;
            lblTiempoPregunta.Text = tiempoRestante.ToString() + "s"; //aqui mostramos el restante de tiempo
            timerPreguntas.Interval = 1000; // Intervalo de 1 segundo
            timerPreguntas.Start(); // ¡Arranca el conteo de 20 segundo


        }



        private void MostrarPregunta()
        {
            if (indice_pregunta < preguntas_opciones.GetLength(0))// Verifica que no se exceda el número de preguntas, usamos GetLength para que sea dinámico es decir si agregamos más preguntas no hay que cambiar el código
            {
                int idx = ordenPreguntas[indice_pregunta];
                labelpreguntas.Text = preguntas_opciones[idx, 0];
                btnopcion1.Text = preguntas_opciones[idx, 1];
                btnopcion2.Text = preguntas_opciones[idx, 2];
                btnopcion3.Text = preguntas_opciones[idx, 3];
                btnopcion4.Text = preguntas_opciones[idx, 4];

                // Mostrar imagen correspondiente a la pregunta y ajustar el modo de visualización
                pictureBox1.Image = imagenesPreguntas[idx];
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                labelpreguntas.BackColor = Color.Transparent;
                labelpreguntas.Font = new Font("Century Gothic", 15, FontStyle.Bold);
                labelpreguntas.ForeColor = Color.LightSkyBlue;
                labelpreguntas.TextAlign = ContentAlignment.MiddleCenter;

                lblpuntaje2.BackColor = Color.Transparent;
                lblpuntaje2.Font = new Font("Century Gothic", 15, FontStyle.Bold);
                lblpuntaje2.ForeColor = Color.Black;
                lblpuntaje2.TextAlign = ContentAlignment.MiddleCenter;

                panelpuntaje.BackColor = Color.FromArgb(30, 144, 255);

                btnopcion4.BackColor = Color.FromArgb(255, 135, 206, 250);
                btnopcion4.FlatStyle = FlatStyle.Flat;
                btnopcion4.FlatAppearance.BorderSize = 0;
                btnopcion4.ForeColor = Color.Black;
                btnopcion4.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                btnopcion4.Cursor = Cursors.Hand;

                btnopcion3.BackColor = Color.FromArgb(255, 135, 206, 250);
                btnopcion3.FlatStyle = FlatStyle.Flat;
                btnopcion3.FlatAppearance.BorderSize = 0;
                btnopcion3.ForeColor = Color.Black;
                btnopcion3.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                btnopcion3.Cursor = Cursors.Hand;

                btnopcion2.BackColor = Color.FromArgb(255, 135, 206, 250);
                btnopcion2.FlatStyle = FlatStyle.Flat;
                btnopcion2.FlatAppearance.BorderSize = 0;
                btnopcion2.ForeColor = Color.Black;
                btnopcion2.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                btnopcion2.Cursor = Cursors.Hand;

                btnopcion1.BackColor = Color.FromArgb(255, 135, 206, 250);
                btnopcion1.FlatStyle = FlatStyle.Flat;
                btnopcion1.FlatAppearance.BorderSize = 0;
                btnopcion1.ForeColor = Color.Black;
                btnopcion1.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                btnopcion1.Cursor = Cursors.Hand;
            }
            else
            {
                MessageBox.Show("¡Has terminado todas las preguntas!");
                this.Close();
            }
        }

        private void btnopcion1_Click(object sender, EventArgs e)
        {
            timerPreguntas.Stop(); // Detenemos el temporizador al responder
            


            Button btn = sender as Button;
            int opcion_seleccionada = 0;

            // Determina qué botón fue presionado
            if (btn == btnopcion1) opcion_seleccionada = 0;
            else if (btn == btnopcion2) opcion_seleccionada = 1;
            else if (btn == this.btnopcion3) opcion_seleccionada = 2;
            else if (btn == btnopcion4) opcion_seleccionada = 3;

            int idx = ordenPreguntas[indice_pregunta];
            if (opcion_seleccionada == respuestas_correctas[idx])
            {
                puntaje += 10;
                MessageBox.Show("¡Respuesta correcta! +10 puntos");
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta. La respuesta correcta es: " +
                    preguntas_opciones[idx, respuestas_correctas[idx] + 1]);
            }
            lblpuntaje2.Text = "Puntaje: " + puntaje;
            indice_pregunta++;
            MostrarPregunta();
            ResetearTemporizador(); // Reiniciamos el temporizador para la siguiente pregunta
        }

        private void btnopcion2_Click(object sender, EventArgs e)
        {
            timerPreguntas.Stop(); // Detenemos el temporizador al responder


            Button btn = sender as Button;
            int opcion_seleccionada = 0;

            // Determina qué botón fue presionado
            if (btn == btnopcion1) opcion_seleccionada = 0;
            else if (btn == btnopcion2) opcion_seleccionada = 1;
            else if (btn == this.btnopcion3) opcion_seleccionada = 2;
            else if (btn == btnopcion4) opcion_seleccionada = 3;

            int idx = ordenPreguntas[indice_pregunta];
            if (opcion_seleccionada == respuestas_correctas[idx])
            {
                puntaje += 10;
                MessageBox.Show("¡Respuesta correcta! +10 puntos ");
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta. La respuesta correcta es: " +
                    preguntas_opciones[idx, respuestas_correctas[idx] + 1]);
            }
            lblpuntaje2.Text = "Puntaje: " + puntaje;
            indice_pregunta++;
            MostrarPregunta();
            ResetearTemporizador(); // Reiniciamos el temporizador para la siguiente pregunta
        }

        private void btnopcion3_Click(object sender, EventArgs e)
        {
            timerPreguntas.Stop(); // Detenemos el temporizador al responder


            Button btn = sender as Button;
            int opcion_seleccionada = 0;

            // Determina qué botón fue presionado
            if (btn == btnopcion1) opcion_seleccionada = 0;
            else if (btn == btnopcion2) opcion_seleccionada = 1;
            else if (btn == this.btnopcion3) opcion_seleccionada = 2;
            else if (btn == btnopcion4) opcion_seleccionada = 3;

            int idx = ordenPreguntas[indice_pregunta];
            if (opcion_seleccionada == respuestas_correctas[idx])
            {
                puntaje += 10;
                MessageBox.Show("¡Respuesta correcta! +10 puntos");
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta. La respuesta correcta es: " +
                    preguntas_opciones[idx, respuestas_correctas[idx] + 1]);
            }
            lblpuntaje2.Text = "Puntaje: " + puntaje;
            indice_pregunta++;
            MostrarPregunta();
            ResetearTemporizador(); // Reiniciamos el temporizador para la siguiente pregunta
        }

        private void btnopcion4_Click(object sender, EventArgs e)
        {
            timerPreguntas.Stop(); // Detenemos el temporizador al responder
            

            Button btn = sender as Button;
            int opcion_seleccionada = 0;

            // Determina qué botón fue presionado
            if (btn == btnopcion1) opcion_seleccionada = 0;
            else if (btn == btnopcion2) opcion_seleccionada = 1;
            else if (btn == this.btnopcion3) opcion_seleccionada = 2;
            else if (btn == btnopcion4) opcion_seleccionada = 3;

            int idx = ordenPreguntas[indice_pregunta];
            if (opcion_seleccionada == respuestas_correctas[idx])
            {
                puntaje += 10;
                MessageBox.Show("¡Respuesta correcta! +10 puntos");
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta. La respuesta correcta es: " +
                    preguntas_opciones[idx, respuestas_correctas[idx] + 1]);
            }
            lblpuntaje2.Text = "Puntaje: " + puntaje;
            indice_pregunta++;
            MostrarPregunta();
            ResetearTemporizador(); // Reiniciamos el temporizador para la siguiente pregunta
        }

        private void labelpreguntas_Click(object sender, EventArgs e)
        {

        }

        private void ResetearTemporizador()
        {

            // Detener el conteo actual
            timerPreguntas.Stop();

            // Restablecer el tiempo al máximo (20 segundos)
            tiempoRestante = TIEMPO_PREGUNTA_MAXIMO;

            //  Actualizar la visualización y color
            lblTiempoPregunta.Text = tiempoRestante.ToString() + "s";
            lblTiempoPregunta.ForeColor = Color.DarkGreen;

            // Iniciar el temporizador
            timerPreguntas.Start();
        }

        private void timerPreguntas_Tick(object sender, EventArgs e)
        {

            if (tiempoRestante > 0)
            {
                tiempoRestante--;
                lblTiempoPregunta.Text = tiempoRestante.ToString() + "s";

                if (tiempoRestante <= 5)
                {
                    lblTiempoPregunta.ForeColor = Color.Yellow; // Alerta visual
                }
            }
            else
            {
                // Mostramos un mensaje de tiempo agotado   
                timerPreguntas.Stop();
                MessageBox.Show("¡Tiempo Agotado! Pregunta no respondida.");

                // 1. Mostrar la respuesta correcta
                int idx = ordenPreguntas[indice_pregunta];
                MessageBox.Show("La respuesta correcta era: " + preguntas_opciones[idx, respuestas_correctas[idx] + 1]);

                // 2. Avanzar pregunta
                lblpuntaje2.Text = "Puntaje: " + puntaje;
                indice_pregunta++;
                MostrarPregunta();

                // 3. Reiniciar el temporizador para la nueva pregunta
                ResetearTemporizador();
            }
        }
    }
}
