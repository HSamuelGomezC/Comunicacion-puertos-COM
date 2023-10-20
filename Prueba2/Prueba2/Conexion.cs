using Lector_De_Puertos_COM;
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
    public partial class Conexion : Form
    {
        private const int WN_NCLBUTOONDBCLK = 0x00A3; //Mensaje de doble clic 

        public Conexion()
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

        private void Conexion_Load(object sender, EventArgs e)
        {

        }

        private void textNombreBD_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUsuarioBD_TextChanged(object sender, EventArgs e)
        {

        }

        private void textContraseñaBD_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtConexion_Click(object sender, EventArgs e)
        {
            //Obtener los datos ingresados por el usuario
            string nombreDB = textNombreBD.Text;
            string usuario = textUsuarioBD.Text;
            string contraseña = textContraseñaBD.Text;

            //Guardar los cambios en la configuracion
            Settings2.Default.NombreDB = nombreDB;
            Settings2.Default.Usuario = usuario;
            Settings2.Default.Contraseña = contraseña;

            //Guardar los cambios en la configuracion
            Settings2.Default.Save();

            //Mostrar mensaje de exito
            MessageBox.Show("Datos de conexion guardados exitosamente","Éxito",MessageBoxButtons.OK, MessageBoxIcon.Information);

           

            Close();
        }
    }
}
