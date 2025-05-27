using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hilos_de_proceso_Juego
{
    public partial class Form1: Form
    {
        private int Velocidad;
        private PictureBox[] road = new PictureBox[8];
        private int Puntaje = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Velocidad = 3;
            road[0] = pictureBox1;
            road[1] = pictureBox2;
            road[2] = pictureBox3;
            road[3] = pictureBox4;
            road[4] = pictureBox5;
            road[5] = pictureBox6;
            road[6] = pictureBox7;
            road[7] = pictureBox8;
        }

        private void MovimientoPista_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox pb in road)
            {
                pb.Top += Velocidad;
                if (pb.Top > this.Height)
                {
                    pb.Top = -pb.Height;
                }
            }
            if (Puntaje > 10 && Puntaje < 30)
            {
                Velocidad = 5;
            }
            if (Puntaje >= 30 && Puntaje < 50)
            {
                Velocidad = 6;
            }
            if (Puntaje >= 50 && Puntaje < 70)
            {
                Velocidad = 7;
            }
            if (Puntaje > 100)
            {
                Velocidad = 9;
            }
            label2.Text = "Velocidad" + Velocidad;
            if ((Cuchillo.Bounds.IntersectsWith(Abuela1.Bounds)))
            {
                endgame();
            }
            if ((Cuchillo.Bounds.IntersectsWith(Bebe1.Bounds)))
            {
                endgame();
            }
            if ((Cuchillo.Bounds.IntersectsWith(Perro1.Bounds)))
            {
                endgame();
            }
        }
        private void endgame()
        {
            button1.Visible = true;
            label3.Visible = true;
            MovimientoPista.Stop();
            Abuela.Stop();
            Bebe.Stop();
            Perro.Stop();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                LadoDerecho.Start();
            }

            if (e.KeyCode == Keys.Left)
            {
                LaodIzquierdo.Start();
            }
        }

        private void LadoDerecho_Tick(object sender, EventArgs e)
        {
            if (Cuchillo.Location.X < 285)
            {
                Cuchillo.Left += 5;
            }
        }

        private void LaodIzquierdo_Tick(object sender, EventArgs e)
        {
            if (Cuchillo.Location.X > 0)
            {
                Cuchillo.Left -= 5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            LadoDerecho.Stop();
            LaodIzquierdo.Stop();
        }
        private void Abuela_Tick(object sender, EventArgs e)
        {
            Abuela1.Top += Velocidad / 2;
            if (Abuela1.Top >= this.Height)
            {
                Puntaje += 1;
                label1.Text = "Puntaje: " + Puntaje;

                Random rnd = new Random();
                Abuela1.Top = -(Convert.ToInt32(Math.Ceiling(rnd.NextDouble() * 200)) + Abuela1.Height);
                Abuela1.Left = Convert.ToInt32(Math.Ceiling(rnd.NextDouble() * 50)) + 0;
            }
        }

        private void Bebe_Tick(object sender, EventArgs e)
        {
            Bebe1.Top += Velocidad / 3;
            if (Bebe1.Top >= this.Height)
            {
                Puntaje += 1;
                label1.Text = "Puntaje: " + Puntaje;

                Random rnd = new Random();
                Bebe1.Top = -(Convert.ToInt32(Math.Ceiling(rnd.NextDouble() * 200)) + Bebe1.Height);
                Bebe1.Left = Convert.ToInt32(Math.Ceiling(rnd.NextDouble() * 50)) + 100;
            }
        }

        private void Perro_Tick(object sender, EventArgs e)
        {
            Perro1.Top += Velocidad * 1 / 2;
            if (Perro1.Top >= this.Height)
            {
                Puntaje += 1;
                label1.Text = "Puntaje: " + Puntaje;

                Random rnd = new Random();
                Perro1.Top = -(Convert.ToInt32(Math.Ceiling(rnd.NextDouble() * 200)) + Perro1.Height);
                Perro1.Left = Convert.ToInt32(Math.Ceiling(rnd.NextDouble() * 120)) + 180;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Puntaje = 0;
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }       
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
