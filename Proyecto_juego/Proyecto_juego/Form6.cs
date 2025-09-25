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

    public partial class Form6 : Form
    {
        private SoundPlayer player;
        int indice_pregunta = 0;

        // Matriz: [pregunta, opción1, opción2, opción3, opción4]
        string[,] preguntas_opciones = new string[,]
        {
            {"¿En qué año comenzó la Segunda Guerra Mundial en Europa?", "1938", "1945", "1939", "1941"},
            {"¿Cuál es el nombre del actor que interpreta a Iron Man?", "Chris Evans", "Chris Hemsworth", " Robert Downey Jr", "Mark Ruffalo"},
            {"¿En el anime Naruto, ¿cuál es el nombre completo del personaje conocido como 'Kakashi', el sensei del equipo 7?", "kakashi Sarutobi", "kakashi Senju", "Kakashi Uchiha", "Kakashi Hatake"},
            {"¿En qué novela de J.R.R. Tolkien aparece por primera vez el personaje de Sméagol, más tarde conocido como Gollum?", "El Hobbit", "El Señor De Los Anillos", "El Silmalirion", "Los Hijos De Hurin"},
            {"¿Quién es el dios nórdico del trueno, hijo de Odín y de la giganta Jörð?", "Loki", "Thor", "Balder", "Heidemal"},
            {"¿En el anime Neon Genesis Evangelion, ¿cuál es el nombre de la organización paramilitar que opera los EVA para combatir a los Ángeles?", "Nerv", "Seele", "WILLE", "GHOST"},
            {"¿Cuál es el único país de América del Sur que tiene costas en el Océano Pacífico y en el Océano Atlántico?", "Colombia", "Venezuela", "Chile", "Peru"},
            {"¿Cuál es el nombre del director que filmó la película ¨El Padrino¨ y Apocalypse Now?", "Martin Scorsese", " Francis Ford Coppola", "Alfred Hitchcock", "Stanley Kubrick"},
            {"¿Cuál fue el nombre del héroe griego que derrotó al Minotauro en el laberinto de Creta?", "Hércules", "Teseo", "Perseo", "Ulises"},
            {"¿En la serie de juegos ¨Metal Gear Solid¨, ¿cuál es el nombre del protagonista y espía conocido por el alias de 'Solid Snake?", " Big Boss", "Raiden", "Snake", "Kazuhira Miller"}
        };

        // Índice de la respuesta correcta para cada pregunta (0 a 3)
        int[] respuestas_correctas = new int[]//usamos un array para guardar las respuestas correctas
        {
            2, // 1939
            2, // Robert Downey Jr.
            3, // Kakashi Hatake
            0, // El Hobbit
            1, // Thor
            0, // Nerv
            0, // Colombia
            0, // Francis Ford Coppola
            1, // Teseo
            2 // Snake
        };

        readonly Image[] imagenesPreguntas = new Image[]// Array de imágenes para cada pregunta, sirve para mostrar la imagen correspondiente a cada pregunta
       {
            Properties.Resources.preguntadificil1,   // Para la pregunta 1
            Properties.Resources.preguntadificil2,   // Para la pregunta 2
            Properties.Resources.preguntadificil3,   // Para la pregunta 3
            Properties.Resources.preguntadificil4,   // Para la pregunta 4
            Properties.Resources.preguntadificil5,   // Para la pregunta 5
            Properties.Resources.preguntadificil6,   // Para la pregunta 6
            Properties.Resources.preguntadificil7,   // Para la pregunta 7
            Properties.Resources.preguntadificil8,   // Para la pregunta 8
            Properties.Resources.preguntadificil9,   // Para la pregunta 9
            Properties.Resources.preguntadificil10   // Para la pregunta 10
       };

        // Nueva estructura para mezclar preguntas, respuestas e imágenes
        private int[] ordenPreguntas;

        public Form6()
        {
            InitializeComponent();
            // Inicializa el orden aleatorio de las preguntas
            Random rnd = new Random();
            ordenPreguntas = Enumerable.Range(0, preguntas_opciones.GetLength(0)).OrderBy(x => rnd.Next()).ToArray();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
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
            // Método único para todos los botones de opción


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
                MessageBox.Show("¡Respuesta correcta!");
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta. La respuesta correcta es: " +
                    preguntas_opciones[idx, respuestas_correctas[idx] + 1]);
            }

            indice_pregunta++;
            MostrarPregunta();
        }

        private void btnopcion2_Click(object sender, EventArgs e)
        {
            // Método único para todos los botones de opción


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
                MessageBox.Show("¡Respuesta correcta!");
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta. La respuesta correcta es: " +
                    preguntas_opciones[idx, respuestas_correctas[idx] + 1]);
            }

            indice_pregunta++;
            MostrarPregunta();
        }

        private void btnopcion3_Click(object sender, EventArgs e)
        {
            // Método único para todos los botones de opción


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
                MessageBox.Show("¡Respuesta correcta!");
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta. La respuesta correcta es: " +
                    preguntas_opciones[idx, respuestas_correctas[idx] + 1]);
            }

            indice_pregunta++;
            MostrarPregunta();
        }

        private void btnopcion4_Click(object sender, EventArgs e)
        {
            // Método único para todos los botones de opción


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
                MessageBox.Show("¡Respuesta correcta!");
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta. La respuesta correcta es: " +
                    preguntas_opciones[idx, respuestas_correctas[idx] + 1]);
            }

            indice_pregunta++;
            MostrarPregunta();
        }

        private void labelpreguntas_Click(object sender, EventArgs e)
        {

        }
    }



}
