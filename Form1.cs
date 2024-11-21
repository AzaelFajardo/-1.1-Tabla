using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; // Necesario para reproducir el sonido

namespace _1._1__Tabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cubana_Click(object sender, EventArgs e)
        {

        }

        private void Boton_ajajaajja_Click(object sender, EventArgs e)
        {
            this.muestraTabla();
        }

        private void muestraTabla()
        {
            int n = Convert.ToInt32(this.Española.Text);
            string tabla = "";

            if (n != 29)
            {
                for (int i = 1; i <= 10; i++)
                {
                    tabla = tabla + n + " x " + i + " = " + (n * i) + "\n";
                }
                this.La_caja_rica_de_texto.AppendText(tabla);
            }
            else
            {
                
                PictureBox easterEggImage = new PictureBox
                {
                    Image = Properties.Resources.amongus, 
                    SizeMode = PictureBoxSizeMode.AutoSize,
                    Location = new Point(10, 150) 
                };
                this.Controls.Add(easterEggImage);

                
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Sus_sound); 
                soundPlayer.Play();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
