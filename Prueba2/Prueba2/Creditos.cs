using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba2
{
    public partial class Creditos : Form
    {

        private const int WN_NCLBUTOONDBCLK = 0x00A3; //Mensaje de doble clic 
        public Creditos()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            //Verificar si el mensaje es un doble clic en la barra de titulo
            if (m.Msg == WN_NCLBUTOONDBCLK)
            {
                //No hacer para para evitar la maximinazion por doble clic
                return;
            }
            base.WndProc(ref m);
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Creditos_Load(object sender, EventArgs e)
        {
            // Carga la imagen desde el archivo
            
           

            // Cambia el tamaño de la imagen al tamaño deseado
           
           // Image resizedlogo = ResizeImage(logo, pictureBox1.Width, pictureBox1.Height);

            // Asigna la imagen redimensionada al PictureBox
            //pictureBox1.Image = resizedlogo;
            //pictureBox2.Image = resizedlogo;
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
