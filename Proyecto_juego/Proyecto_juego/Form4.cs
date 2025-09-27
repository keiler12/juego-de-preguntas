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
        private int indicePregunta = 0;
        private int puntaje = 0;
        private const int TIEMPO_PREGUNTA_MAXIMO = 20;
        private int tiempoRestante;

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
            Properties.Resources.preguntafacil1,   // Para la pregunta 1
            Properties.Resources.preguntafacil2,   // Para la pregunta 2
            Properties.Resources.preguntafacil3,   // Para la pregunta 3
            Properties.Resources.preguntafacil4,   // Para la pregunta 4
            Properties.Resources.preguntafacil5,   // Para la pregunta 5
            Properties.Resources.preguntafacil6,   // Para la pregunta 6
            Properties.Resources.preguntafacil7,   // Para la pregunta 7
            Properties.Resources.preguntafacil8,   // Para la pregunta 8
            Properties.Resources.preguntafacil9,   // Para la pregunta 9
            Properties.Resources.preguntafacil10   // Para la pregunta 10
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
            //Aquí va el código de estilo
            lblTiempoPregunta.Text = TIEMPO_PREGUNTA_MAXIMO.ToString();
            lblTiempoPregunta.Font = new Font("Century Gothic", 20, FontStyle.Bold);
            lblTiempoPregunta.ForeColor = Color.Black   ;
            lblTiempoPregunta.TextAlign = ContentAlignment.MiddleCenter;
            lblTiempoPregunta.BackColor = Color.Transparent;
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
                label1.Text = preguntas_opciones[idx, 0];
                btnopcion1.Text = preguntas_opciones[idx, 1];
                btnopcion2.Text = preguntas_opciones[idx, 2];
                btnopcion3.Text = preguntas_opciones[idx, 3];
                btnopcion4.Text = preguntas_opciones[idx, 4];

                // Mostrar imagen correspondiente a la pregunta y ajustar el modo de visualización
                pictureBox1.Image = imagenesPreguntas[idx];
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                label1.BackColor = Color.Transparent;
                label1.Font = new Font("Century Gothic", 15, FontStyle.Bold);
                label1.ForeColor = Color.LightSkyBlue;
                label1.TextAlign = ContentAlignment.MiddleCenter;

                lblpuntaje.BackColor = Color.Transparent;
                lblpuntaje.Font = new Font("Century Gothic", 15, FontStyle.Bold);
                lblpuntaje.ForeColor = Color.Black;
                lblpuntaje.TextAlign = ContentAlignment.MiddleCenter;

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
                MessageBox.Show($"¡Has terminado todas las preguntas!\n Tu puntaje final es: {puntaje}");
                this.Close();
            }
        }

        private void btnvenus_Click(object sender, EventArgs e)
        {
            timerPreguntas.Stop(); // Detenemos el temporizador al responder
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
                puntaje += 10;
                MessageBox.Show("¡Respuesta correcta! +10 puntos ");
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta. La respuesta correcta es: " +
                    preguntas_opciones[idx, respuestas_correctas[idx] + 1]);
            }

            lblpuntaje.Text = "Puntaje: " + puntaje;
            indice_pregunta++;
            MostrarPregunta();
            ResetearTemporizador(); // Reiniciamos el temporizador para la siguiente pregunta

        }

        private void btnmercurio_Click(object sender, EventArgs e)
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

            lblpuntaje.Text = "Puntaje: " + puntaje;
            indice_pregunta++;
            MostrarPregunta();
            ResetearTemporizador(); // Reiniciamos el temporizador para la siguiente pregunta
        }

        private void btntierra_Click_1(object sender, EventArgs e)
        {
            
            //Aquí detenemos el temporizador al responder
            timerPreguntas.Stop();

          
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

            lblpuntaje.Text = "Puntaje: " + puntaje;
            indice_pregunta++;
            MostrarPregunta();
            ResetearTemporizador(); // Reiniciamos el temporizador para la siguiente pregunta
        }

        private void btnmarte_Click(object sender, EventArgs e)
        {
            timerPreguntas.Stop(); // Detenemos el temporizador al responder
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
                puntaje += 10;
                MessageBox.Show("¡Respuesta correcta! +10 puntos");
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta. La respuesta correcta es: " +
                    preguntas_opciones[idx, respuestas_correctas[idx] + 1]);
            }

            lblpuntaje.Text = "Puntaje: " + puntaje;
            indice_pregunta++;
            MostrarPregunta();
            ResetearTemporizador(); // Reiniciamos el temporizador para la siguiente pregunta   
        }

        private void label1_Paint(object sender, PaintEventArgs e)
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
            lblTiempoPregunta.ForeColor = Color.Black;

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
                lblpuntaje.Text = "Puntaje: " + puntaje;
                indice_pregunta++;
                MostrarPregunta();

                // 3. Reiniciar el temporizador para la nueva pregunta
                ResetearTemporizador();
            }
        }

        private void lblTiempoPregunta_Click(object sender, EventArgs e)
        {

        }
    }
}

