using System;
using System.Windows.Forms;
using System.Drawing; 
using System.Linq;
using System.IO;
using System.Media;

namespace Proyecto_juego
{
    /// <summary>
    /// Form4: Formulario para el modo fácil del juego de preguntas.
    /// Gestiona la lógica de preguntas, respuestas, comodines, temporizador y música de fondo.
    /// </summary>
    public partial class Form4 : Form
    {
        // Reproductor de música de fondo
        private SoundPlayer player;

        // Índice de la pregunta actual
        int indice_pregunta = 0;

        // Puntaje acumulado del jugador
        private int puntaje = 0;

        // Tiempo máximo para responder cada pregunta (en segundos)
        private const int TIEMPO_PREGUNTA_MAXIMO = 20;

        // Tiempo restante para responder la pregunta actual
        private int tiempoRestante;

        // Flags para saber si los comodines ya fueron usados
        private bool comodin5050Usado = false;
        private bool comodinSaltarUsado = false;


        // Matriz de preguntas y opciones. Cada fila: [pregunta, opción1, opción2, opción3, opción4]
        string[,] preguntas_opciones = new string[,]
        {
            // Ejemplo: {"Pregunta", "Opción1", "Opción2", "Opción3", "Opción4"}
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

        // Array con el índice de la respuesta correcta para cada pregunta (0 a 3)
        int[] respuestas_correctas = new int[]
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

        // Array de imágenes asociadas a cada pregunta
        readonly Image[] imagenesPreguntas = new Image[]
        {
            Properties.Resources.preguntafacil1,
            Properties.Resources.preguntafacil2,
            Properties.Resources.preguntafacil3,
            Properties.Resources.preguntafacil4,
            Properties.Resources.preguntafacil5,
            Properties.Resources.preguntafacil6,
            Properties.Resources.preguntafacil7,
            Properties.Resources.preguntafacil8,
            Properties.Resources.preguntafacil9,
            Properties.Resources.preguntafacil10
        };

        // Array para mezclar el orden de las preguntas de forma aleatoria
        private int[] ordenPreguntas;

        
        /// Constructor del formulario. Inicializa componentes y mezcla el orden de las preguntas.
        
        public Form4()
        {
            InitializeComponent();
            // Mezcla aleatoriamente el orden de las preguntas al iniciar el formulario
            Random rnd = new Random();
            ordenPreguntas = Enumerable.Range(0, preguntas_opciones.GetLength(0)).OrderBy(x => rnd.Next()).ToArray();
        }

        
        /// Bloquea las teclas Enter y Espacio para evitar respuestas accidentales.
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter || keyData == Keys.Space)
            {
                return true; // bloquea Enter y Space
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        
        /// Evento que se ejecuta al cargar el formulario.
        /// Configura estilos, inicia la música de fondo y el temporizador, y muestra la primera pregunta.
        
        private void Form4_Load(object sender, EventArgs e)
        {
            // Configuración de estilos visuales y temporizador
            lblTiempoPregunta.Text = TIEMPO_PREGUNTA_MAXIMO.ToString();
            lblTiempoPregunta.Font = new Font("Century Gothic", 20, FontStyle.Bold);
            lblTiempoPregunta.ForeColor = Color.DarkGreen;
            lblTiempoPregunta.TextAlign = ContentAlignment.MiddleCenter;
            lblTiempoPregunta.BackColor = Color.Transparent;

            panelconteo.BackColor = Color.FromArgb(150, 255, 255, 255); // Fondo semitransparente

            MostrarPregunta();

            // Inicializa la música de fondo desde recursos
            string tempFile = Path.Combine(Path.GetTempPath(), "musica_modo_facil.wav");
            using (var resourceStream = Properties.Resources.musica_modo_facil)
            using (var fileStream = File.Create(tempFile))
            {
                resourceStream.CopyTo(fileStream);
            }

            player = new SoundPlayer(tempFile);
            player.PlayLooping(); // Reproduce en bucle

            // Inicia el temporizador para las preguntas
            tiempoRestante = TIEMPO_PREGUNTA_MAXIMO;
            lblTiempoPregunta.Text = tiempoRestante.ToString() + "s";
            timerPreguntas.Interval = 1000; // 1 segundo
            timerPreguntas.Start();
        }

        
        /// Muestra la pregunta y opciones actuales en pantalla, junto con la imagen correspondiente.
        /// Aplica estilos a los controles.
        
        private void MostrarPregunta()
        {
            if (indice_pregunta < preguntas_opciones.GetLength(0))
            {
                int idx = ordenPreguntas[indice_pregunta];
                lblpreguntas.Text = preguntas_opciones[idx, 0];
                btnopcion1.Text = preguntas_opciones[idx, 1];
                btnopcion2.Text = preguntas_opciones[idx, 2];
                btnopcion3.Text = preguntas_opciones[idx, 3];
                btnopcion4.Text = preguntas_opciones[idx, 4];

                // Imagen de la pregunta
                pictureBox1.Image = imagenesPreguntas[idx];
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                // Estilos visuales
                lblpreguntas.BackColor = Color.Transparent;
                lblpreguntas.Font = new Font("Century Gothic", 15, FontStyle.Bold);
                lblpreguntas.ForeColor = Color.LightSkyBlue;
                lblpreguntas.TextAlign = ContentAlignment.MiddleCenter;

                lblpuntaje.BackColor = Color.Transparent;
                lblpuntaje.Font = new Font("Century Gothic", 15, FontStyle.Bold);
                lblpuntaje.ForeColor = Color.Black;
                panelpuntaje.BackColor = Color.FromArgb(30, 144, 255);

                // Estilo de botones y comodines
                btn5050.Text = "50/50";
                btn5050.BackColor = Color.FromArgb(255, 215, 0);
                btn5050.ForeColor = Color.Black;
                btn5050.FlatStyle = FlatStyle.Flat;
                btn5050.FlatAppearance.BorderSize = 2;
                btn5050.FlatAppearance.BorderColor = Color.White;
                btn5050.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                btn5050.Cursor = Cursors.Hand;
                btn5050.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 180, 0);

                btnsaltar.Text = "Saltar Pregunta";
                btnsaltar.BackColor = Color.FromArgb(0, 191, 255);
                btnsaltar.ForeColor = Color.White;
                btnsaltar.FlatStyle = FlatStyle.Flat;
                btnsaltar.FlatAppearance.BorderSize = 2;
                btnsaltar.FlatAppearance.BorderColor = Color.White;
                btnsaltar.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                btnsaltar.Cursor = Cursors.Hand;
                btnsaltar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 150, 200);

                // Botones de opciones
                btnopcion1.BackColor = Color.FromArgb(255, 135, 206, 250);
                btnopcion1.FlatStyle = FlatStyle.Flat;
                btnopcion1.FlatAppearance.BorderSize = 0;
                btnopcion1.ForeColor = Color.Black;
                btnopcion1.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                btnopcion1.Cursor = Cursors.Hand;

                btnopcion2.BackColor = Color.FromArgb(255, 135, 206, 250);
                btnopcion2.FlatStyle = FlatStyle.Flat;
                btnopcion2.FlatAppearance.BorderSize = 0;
                btnopcion2.ForeColor = Color.Black;
                btnopcion2.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                btnopcion2.Cursor = Cursors.Hand;

                btnopcion3.BackColor = Color.FromArgb(255, 135, 206, 250);
                btnopcion3.FlatStyle = FlatStyle.Flat;
                btnopcion3.FlatAppearance.BorderSize = 0;
                btnopcion3.ForeColor = Color.Black;
                btnopcion3.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                btnopcion3.Cursor = Cursors.Hand;

                btnopcion4.BackColor = Color.FromArgb(255, 135, 206, 250);
                btnopcion4.FlatStyle = FlatStyle.Flat;
                btnopcion4.FlatAppearance.BorderSize = 0;
                btnopcion4.ForeColor = Color.Black;
                btnopcion4.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                btnopcion4.Cursor = Cursors.Hand;

                // Botón de pausa
                btnpausa.Font = new Font("Century Gothic", 14, FontStyle.Bold);
                btnpausa.ForeColor = Color.White;
                btnpausa.BackColor = Color.FromArgb(220, 50, 50);
                btnpausa.FlatStyle = FlatStyle.Flat;
                btnpausa.FlatAppearance.BorderSize = 0;
                btnpausa.Cursor = Cursors.Hand;
            }
            else
            {
                // Si no hay más preguntas, muestra el puntaje final y vuelve al menú de niveles
                MessageBox.Show($"¡Has terminado todas las preguntas!\n Tu puntaje final es: {puntaje}");
                Form2 menu_nivel = new Form2();
                menu_nivel.Show();
                this.Hide();
                return;
            }
        }

        
        /// Métodos para manejar el clic en cada botón de opción de respuesta.
        /// Evalúan si la respuesta es correcta, actualizan el puntaje y muestran mensajes.
        
        private void btnvenus_Click(object sender, EventArgs e)
        {
            timerPreguntas.Stop();
            Button btn = sender as Button;
            int opcion_seleccionada = 0;
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
            CargarSiguientePregunta();
            ResetearTemporizador();
        }

        // Repite la misma lógica para los otros botones de opción
        private void btnmercurio_Click(object sender, EventArgs e)
        {
            timerPreguntas.Stop();
            Button btn = sender as Button;
            int opcion_seleccionada = 0;
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
            CargarSiguientePregunta();
            ResetearTemporizador();
        }
        private void btntierra_Click_1(object sender, EventArgs e) 
        {
            timerPreguntas.Stop();
            Button btn = sender as Button;
            int opcion_seleccionada = 0;
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
            CargarSiguientePregunta();
            ResetearTemporizador();
        }
        private void btnmarte_Click(object sender, EventArgs e)
        {
            timerPreguntas.Stop();
            Button btn = sender as Button;
            int opcion_seleccionada = 0;
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
            CargarSiguientePregunta();
            ResetearTemporizador();
        }

        
        /// Reinicia el temporizador para la siguiente pregunta.
        
        private void ResetearTemporizador()
        {
            timerPreguntas.Stop();
            tiempoRestante = TIEMPO_PREGUNTA_MAXIMO;
            lblTiempoPregunta.Text = tiempoRestante.ToString() + "s";
            lblTiempoPregunta.ForeColor = Color.DarkGreen;
            timerPreguntas.Start();
        }

        
        /// Evento del temporizador: actualiza el tiempo restante y gestiona el tiempo agotado.
        
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
                timerPreguntas.Stop();
                MessageBox.Show("¡Tiempo Agotado! Pregunta no respondida.");
                int idx = ordenPreguntas[indice_pregunta];
                MessageBox.Show("La respuesta correcta era: " + preguntas_opciones[idx, respuestas_correctas[idx] + 1]);
                lblpuntaje.Text = "Puntaje: " + puntaje;
                indice_pregunta++;
                CargarSiguientePregunta();
                ResetearTemporizador();
            }
        }

        
        /// Lógica del comodín 50/50: oculta dos opciones incorrectas.
        
        private void btn5050_Click(object sender, EventArgs e)
        {
            if (comodin5050Usado)
            {
                MessageBox.Show("El comodín 50/50 ya fue usado.");
                return;
            }
            comodin5050Usado = true;
            btn5050.Enabled = false;

            int idx_original = ordenPreguntas[indice_pregunta];
            int columnaRespuestaCorrecta = respuestas_correctas[idx_original] + 1;
            string respuestaCorrecta = preguntas_opciones[idx_original, columnaRespuestaCorrecta];

            Button[] botonesRespuesta = { btnopcion1, btnopcion2, btnopcion3, btnopcion4 };
            Random rnd = new Random();
            int opcionesOcultadas = 0;
            while (opcionesOcultadas < 2)
            {
                int indiceBoton = rnd.Next(0, botonesRespuesta.Length);
                Button boton = botonesRespuesta[indiceBoton];
                if (boton.Text != respuestaCorrecta && boton.Visible)
                {
                    boton.Visible = false;
                    opcionesOcultadas++;
                }
            }
        }

        
        /// Carga la siguiente pregunta o finaliza el juego si no hay más preguntas.
      
        private void CargarSiguientePregunta()
        {
            btnopcion1.Visible = true;
            btnopcion2.Visible = true;
            btnopcion3.Visible = true;
            btnopcion4.Visible = true;

            if (indice_pregunta >= preguntas_opciones.GetLength(0))
            {
                MessageBox.Show($"¡Has terminado todas las preguntas!\n Tu puntaje final es: {puntaje}\nTe le mides a otro nivel o es todo por hoy?");
                timerPreguntas.Stop();
                timerPreguntas.Tick -= timerPreguntas_Tick;
                Form2 menu_nivel = new Form2();
                menu_nivel.Show();
                this.Hide();
                return;
            }
            MostrarPregunta();
        }

        
        /// Lógica del comodín "Saltar pregunta".
        
        private void btnsaltar_Click(object sender, EventArgs e)
        {
            if (comodinSaltarUsado)
            {
                MessageBox.Show("El comodín Saltar Pregunta ya fue usado.");
                return;
            }
            comodinSaltarUsado = true;
            btnsaltar.Enabled = false;
            indice_pregunta++;
            CargarSiguientePregunta();
        }

        
        /// Botón de pausa: permite volver al menú principal.
        
        private void btnpausa_Click(object sender, EventArgs e)
        {
            timerPreguntas.Stop();
            var resultado = MessageBox.Show(
                "¿Desea ir al menú principal?",
                "Pausa...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button3);

            if (resultado == DialogResult.Yes)
            {
                timerPreguntas.Tick -= timerPreguntas_Tick;
                Form1 menu_principal = new Form1();
                menu_principal.Show();
                this.Hide();
                return;     
            }
            else
            {
                timerPreguntas.Start();
            }
        }
    }
}

