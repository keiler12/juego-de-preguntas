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
        private int puntaje = 0;
        private const int TIEMPO_PREGUNTA_MAXIMO = 20;
        private int tiempoRestante;
        private bool comodin5050Usado = false;
        private bool comodinSaltarUsado = false;

        // Matriz: [pregunta, opción1, opción2, opción3, opción4]
        string[,] preguntas_opciones = new string[,]
        {
            {"¿En qué año comenzó la Segunda Guerra Mundial en Europa?", "1938", "1945", "1939", "1941"},
            {"¿Cuantas zonas horarias tiene Rusia?", "11", "8", "5", "7"},
            {"¿Cuál es la flor nacional de Japón?", "Kiku", "Sakura", "Loto", "tsutsuji"},
            {"¿En qué novela de J.R.R. Tolkien aparece por primera vez el personaje de Sméagol, más tarde conocido como Gollum?", "El Hobbit", "Star Wars", "El Silmalirion", "Los Hijos De Hurin"},
            {"¿¿Qué filósofo griego fue el maestro de Alejandro Magno??", "Socrates", "Aristoteles", "Platón", "Demócrito"},
            {"En el anime Neon Genesis Evangelion, ¿cuál es el nombre de la organización paramilitar que opera los EVA para combatir a los Ángeles?", "Nerv", "Seele", "WILLE", "GHOST"},
            {"¿En qué año se estableció el gobierno de la República de Colombia?", "1810", "1821", "1819", "1830"},
            {"¿Cuál es el nombre del director que filmó la película 'El Padrino y Apocalypse Now?'", "Martin Scorsese", " Francis F. Coppola", "Alfred Hitchcock", "Stanley Kubrick"},
            {"¿Cuál fue el nombre del héroe griego que derrotó al Minotauro en el laberinto de Creta?", "Hércules", "Teseo", "Perseo", "Ulises"},
            {"En la serie de juegos 'Metal Gear Solid', ¿Cuál es el nombre del protagonista y espía conocido por el alias de 'Solid Snake'?", " Big Boss", "Raiden", "Snake", "Kazuhira Miller"}
        };

        // Índice de la respuesta correcta para cada pregunta (0 a 3)
        int[] respuestas_correctas = new int[]//usamos un array para guardar las respuestas correctas
        {
            2, // 1939
            0, // 11
            1, // Sakura
            0, // El Hobbit
            1, // Aristoteles
            0, // Nerv
            0, // 1810
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

        // Mueve el método fuera del constructor
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter || keyData == Keys.Space)
            {
                return true; // bloquea Enter y Space
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }



        private void Form6_Load(object sender, EventArgs e)
        {

            // aqui va el código de estilo

            lblTiempoPregunta.Text = TIEMPO_PREGUNTA_MAXIMO.ToString();
            lblTiempoPregunta.Font = new Font("Century Gothic", 20, FontStyle.Bold);
            lblTiempoPregunta.ForeColor = Color.DarkGreen;
            lblTiempoPregunta.TextAlign = ContentAlignment.MiddleCenter;
            lblTiempoPregunta.BackColor = Color.Transparent;


            panelconteo.BackColor = Color.FromArgb(150, 255, 255, 255);
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



                lblpuntaje3.BackColor = Color.Transparent;
                lblpuntaje3.Font = new Font("Century Gothic", 15, FontStyle.Bold);
                lblpuntaje3.ForeColor = Color.Black;
                lblpuntaje3.TextAlign = ContentAlignment.MiddleCenter;

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



                btn5050.Text = "50/50";
                btn5050.BackColor = Color.FromArgb(255, 215, 0); // Amarillo Dorado brillante
                btn5050.ForeColor = Color.Black; // Texto negro para alto contraste
                btn5050.FlatStyle = FlatStyle.Flat;
                btn5050.FlatAppearance.BorderSize = 2; // Borde más grueso para resaltar
                btn5050.FlatAppearance.BorderColor = Color.White; // Borde blanco (clásico sobre rojo)
                btn5050.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                btn5050.Cursor = Cursors.Hand;
                btn5050.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 180, 0);



                btnsaltar.Text = "Saltar Pregunta";
                btnsaltar.BackColor = Color.FromArgb(0, 191, 255); // Cian/Azul Brillante
                btnsaltar.ForeColor = Color.White; // Texto blanco
                btnsaltar.FlatStyle = FlatStyle.Flat;
                btnsaltar.FlatAppearance.BorderSize = 2;
                btnsaltar.FlatAppearance.BorderColor = Color.White; // Borde blanco
                btnsaltar.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                btnsaltar.Cursor = Cursors.Hand;
                btnsaltar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 150, 200);


                btnopcion2.BackColor = Color.FromArgb(255, 135, 206, 250);
                btnopcion2.FlatStyle = FlatStyle.Flat;
                btnopcion2.FlatAppearance.BorderSize = 0;
                btnopcion2.ForeColor = Color.Black;
                btnopcion2.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                btnopcion2.Cursor = Cursors.Hand;


                btnpausa.Font = new Font("Century Gothic", 14, FontStyle.Bold);
                btnpausa.ForeColor = Color.White; // Texto en blanco
                btnpausa.BackColor = Color.FromArgb(220, 50, 50); // Rojo elegante
                btnpausa.FlatStyle = FlatStyle.Flat;
                btnpausa.FlatAppearance.BorderSize = 0;
                btnpausa.Cursor = Cursors.Hand;

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
            timerPreguntas.Stop(); // Detiene el temporizador al responder


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
            lblpuntaje3.Text = "Puntaje: " + puntaje;
            indice_pregunta++;
            CargarSiguientePregunta(); //aqui cambiamos para que cargue la siguiente pregunta
            ResetearTemporizador(); //Aquí reiniciamos el temporizador para la siguiente pregunta

        }

        private void btnopcion2_Click(object sender, EventArgs e)
        {
            timerPreguntas.Stop(); // Detiene el temporizador al responder  


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
            lblpuntaje3.Text = "Puntaje: " + puntaje;
            indice_pregunta++;
            CargarSiguientePregunta(); //aqui cambiamos para que cargue la siguiente pregunta
            ResetearTemporizador(); //Aquí reiniciamos el temporizador para la siguiente pregunta
        }

        private void btnopcion3_Click(object sender, EventArgs e)
        {
            timerPreguntas.Stop(); // Detiene el temporizador al responder


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
            lblpuntaje3.Text = "Puntaje: " + puntaje;
            indice_pregunta++;
            CargarSiguientePregunta(); //aqui cambiamos para que cargue la siguiente pregunta
            ResetearTemporizador(); //Aquí reiniciamos el temporizador para la siguiente pregunta
        }

        private void btnopcion4_Click(object sender, EventArgs e)
        {
            timerPreguntas.Stop(); // Detiene el temporizador al responder


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
            lblpuntaje3.Text = "Puntaje: " + puntaje;
            indice_pregunta++;
            CargarSiguientePregunta(); //aqui cambiamos para que cargue la siguiente pregunta
            ResetearTemporizador(); //Aquí reiniciamos el temporizador para la siguiente pregunta
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
        private void labelpreguntas_Click(object sender, EventArgs e)
        {

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
                lblpuntaje3.Text = "Puntaje: " + puntaje;
                indice_pregunta++;
                MostrarPregunta();

                // 3. Reiniciar el temporizador para la nueva pregunta
                ResetearTemporizador();
            }
        }

        private void CargarSiguientePregunta()
        {

            // 1. Mostrar todos los botones (Resetea el efecto del comodín 50/50)
            // Esto es esencial para que la nueva pregunta tenga las 4 opciones visibles.
            btnopcion1.Visible = true;
            btnopcion2.Visible = true;
            btnopcion3.Visible = true;
            btnopcion4.Visible = true;

            // 2. Verificar si se acabaron las preguntas
            if (indice_pregunta >= preguntas_opciones.GetLength(0))
            {
                MessageBox.Show($"¡Has terminado todas las preguntas!\n Tu puntaje final es: {puntaje}\n¿Te le mides a otro nivel o es todo por hoy?");

                // Aquí debes llamar a la función que finaliza tu juego y vuelve al inicio (Ajusta si tienes 'formInicio'):
                // formInicio.Show(); 
                this.Close();
                return;
            }

            // 3. Llama al método original para cargar el contenido, imágenes y estilos
            // MostrarPregunta() se encargará de todo lo que ya tienes.
            MostrarPregunta();
        }

        private void btnsaltar_Click(object sender, EventArgs e)
        {

            if (comodinSaltarUsado)
            {
                MessageBox.Show("El comodín Saltar Pregunta ya fue usado.");
                return;
            }

            comodinSaltarUsado = true;
            btnsaltar.Enabled = false;

            // Usamos tu variable principal
            indice_pregunta++;

            // Llama al método que resetea y luego llama a MostrarPregunta()
            CargarSiguientePregunta();
        }

        private void btn5050_Click(object sender, EventArgs e)
        {
            if (comodin5050Usado)
            {
                MessageBox.Show("El comodín 50/50 ya fue usado.");
                return;
            }

            // 1. Marcar como usado y deshabilitar el botón visualmente
            comodin5050Usado = true;
            btn5050.Enabled = false;

            // --- Lógica para obtener la Respuesta Correcta ---

            // Obtener el índice de la pregunta actual del array ORDENADO
            int idx_original = ordenPreguntas[indice_pregunta];

            // El valor de la respuesta correcta es:
            // La fila de la pregunta (idx_original)
            // + La columna de la opción correcta: que es el valor de respuestas_correctas[idx_original] + 1
            // (+1 porque respuestas_correctas usa 0-3 y preguntas_opciones usa 1-4 para las opciones)
            int columnaRespuestaCorrecta = respuestas_correctas[idx_original] + 1;
            string respuestaCorrecta = preguntas_opciones[idx_original, columnaRespuestaCorrecta];

            // --- Lógica de Ocultar Botones ---

            // 3. Crear una lista de todos los botones de respuesta
            Button[] botonesRespuesta = { btnopcion1, btnopcion2, btnopcion3, btnopcion4 };

            // 4. Buscar y ocultar dos opciones incorrectas
            Random rnd = new Random();
            int opcionesOcultadas = 0;

            while (opcionesOcultadas < 2)
            {
                int indiceBoton = rnd.Next(0, botonesRespuesta.Length);
                Button boton = botonesRespuesta[indiceBoton];

                // La condición: Que el texto del botón NO sea la respuesta correcta Y que NO esté ya oculto.
                if (boton.Text != respuestaCorrecta && boton.Visible)
                {
                    boton.Visible = false;
                    opcionesOcultadas++;

                }
            }
        }

        private void btnpausa_Click(object sender, EventArgs e)
        {
            // Detener el temporizador antes de mostrar el MessageBox
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
                // Si el usuario elige "No", reanudar el temporizador
                timerPreguntas.Start();
            }
        }
    }
}