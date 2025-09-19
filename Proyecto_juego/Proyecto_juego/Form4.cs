using System;
using System.Windows.Forms;
using System.Drawing; 
using System.Linq; 

namespace Proyecto_juego
{
    using System.IO;
    using System.Media;
    public partial class Form4 : Form
    {
        private SoundPlayer player;
        int indice_pregunta = 0;

        // Matriz: [pregunta, opción1, opción2, opción3, opción4]
        string[,] preguntas_opciones = new string[,]
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
            {"¿Cuál es la mitad de uno?", "El ombligo", "0.5", "Medio", "Uno"}
        };

        // Índice de la respuesta correcta para cada pregunta (0 a 3)
        int[] respuestas_correctas = new int[]//usamos un array para guardar las respuestas correctas
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

        
        readonly Image[] imagenesPreguntas = new Image[]// Array de imágenes para cada pregunta, sirve para mostrar la imagen correspondiente a cada pregunta
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
            ordenPreguntas = Enumerable.Range(0, preguntas_opciones.GetLength(0)).OrderBy(x => rnd.Next()).ToArray();

        }


        private void Form4_Load(object sender, EventArgs e)
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
                label1.Text = preguntas_opciones[idx, 0];
                btnvenus.Text = preguntas_opciones[idx, 1];
                btntierra.Text = preguntas_opciones[idx, 2];
                btnmercurio.Text = preguntas_opciones[idx, 3];
                btnmarte.Text = preguntas_opciones[idx, 4];

                // Mostrar imagen correspondiente a la pregunta y ajustar el modo de visualización
                pictureBox1.Image = imagenesPreguntas[idx];
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                label1.BackColor = Color.Transparent;
                label1.Font = new Font("Century Gothic", 15, FontStyle.Bold);
                label1.ForeColor = Color.LightSkyBlue;
                label1.TextAlign = ContentAlignment.MiddleCenter;


                btnmarte.BackColor = Color.FromArgb(255, 135, 206, 250);
                btnmarte.FlatStyle = FlatStyle.Flat;
                btnmarte.FlatAppearance.BorderSize = 0;
                btnmarte.ForeColor = Color.Black;
                btnmarte.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                btnmarte.Cursor = Cursors.Hand;

                btnmercurio.BackColor = Color.FromArgb(255, 135, 206, 250);
                btnmercurio.FlatStyle = FlatStyle.Flat;
                btnmercurio.FlatAppearance.BorderSize = 0;
                btnmercurio.ForeColor = Color.Black;
                btnmercurio.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                btnmercurio.Cursor = Cursors.Hand;

                btntierra.BackColor = Color.FromArgb(255, 135, 206, 250);
                btntierra.FlatStyle = FlatStyle.Flat;
                btntierra.FlatAppearance.BorderSize = 0;
                btntierra.ForeColor = Color.Black;
                btntierra.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                btntierra.Cursor = Cursors.Hand;

                btnvenus.BackColor = Color.FromArgb(255, 135, 206, 250);
                btnvenus.FlatStyle = FlatStyle.Flat;
                btnvenus.FlatAppearance.BorderSize = 0;
                btnvenus.ForeColor = Color.Black;
                btnvenus.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                btnvenus.Cursor = Cursors.Hand;
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
            int opcion_seleccionada = 0;

            // Determina qué botón fue presionado
            if (btn == btnvenus) opcion_seleccionada = 0;
            else if (btn == btntierra) opcion_seleccionada = 1;
            else if (btn == btnmercurio) opcion_seleccionada = 2;
            else if (btn == btnmarte) opcion_seleccionada = 3;

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

        private void btnmercurio_Click(object sender, EventArgs e)
        { 

        // Método único para todos los botones de opción
            Button btn = sender as Button;
            int opcion_seleccionada = 0;

            // Determina qué botón fue presionado
            if (btn == btnvenus) opcion_seleccionada = 0;
            else if (btn == btntierra) opcion_seleccionada = 1;
            else if (btn == btnmercurio) opcion_seleccionada = 2;
            else if (btn == btnmarte) opcion_seleccionada = 3;

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

        private void btntierra_Click_1(object sender, EventArgs e)
        {

        // Método único para todos los botones de opción
        
            Button btn = sender as Button;
            int opcion_seleccionada = 0;

            // Determina qué botón fue presionado
            if (btn == btnvenus) opcion_seleccionada = 0;
            else if (btn == btntierra) opcion_seleccionada = 1;
            else if (btn == btnmercurio) opcion_seleccionada = 2;
            else if (btn == btnmarte) opcion_seleccionada = 3;

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

        private void btnmarte_Click(object sender, EventArgs e)
        {

            // Método único para todos los botones de opción

            Button btn = sender as Button;
            int opcion_seleccionada = 0;

            // Determina qué botón fue presionado
            if (btn == btnvenus) opcion_seleccionada = 0;
            else if (btn == btntierra) opcion_seleccionada = 1;
            else if (btn == btnmercurio) opcion_seleccionada = 2;
            else if (btn == btnmarte) opcion_seleccionada = 3;

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

        private void label1_Paint(object sender, PaintEventArgs e)
        {
        
        }

    }
}

