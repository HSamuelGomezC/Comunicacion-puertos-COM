using System;
using System.IO.Ports;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lector_De_Puertos_COM;

namespace Prueba2
{
    public partial class ConfiguracionForm : Form
    {
        private const int WM_NCLBUTTONDBLCLK = 0x00A3; // Mensaje de doble clic en la barra de título

        public ConfiguracionForm()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            // Verificar si el mensaje es un doble clic en la barra de título
            if (m.Msg == WM_NCLBUTTONDBLCLK)
            {
                // No hacer nada para evitar la maximización por doble clic
                return;
            }
            base.WndProc(ref m);
        }


        private void ConfiguracionForm_Load(object sender, EventArgs e)
        {
            //Obtener la configuracion guardada y mostrarla en los controles
            comboBoxPuertos.SelectedItem = Settings1.Default.PuertoSeleccionado;
            checkBoxA.Checked = Settings1.Default.OpcionA;
            checkBoxB.Checked = Settings1.Default.OpcionB;
            checkBoxC.Checked = Settings1.Default.OpcionC;
            checkBoxSDR.Checked = Settings1.Default.OpcionSDR;

            //Obtener la lista de puertos COM disponibles
            string[] availablePorts = SerialPort.GetPortNames();

            //Agregar los puertos disponibles al ComboBox
            comboBoxPuertos.Items.AddRange(availablePorts);

        }

        private void comboBoxPuertos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxSDR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener la configuración del usuario desde los controles
            string puertoSeleccionado = comboBoxPuertos.SelectedItem?.ToString();
            bool opcionA = checkBoxA.Checked;
            bool opcionB = checkBoxB.Checked;
            bool opcionC = checkBoxC.Checked;
            bool opcionSDR = checkBoxSDR.Checked;

            //Guardar configuracion en el archivo de configuracion
            Settings1.Default.PuertoSeleccionado = puertoSeleccionado;
            Settings1.Default.OpcionA = opcionA;
            Settings1.Default.OpcionB = opcionB;
            Settings1.Default.OpcionC = opcionC;
            Settings1.Default.OpcionSDR = opcionSDR;


            Settings1.Default.Save();

            MessageBox.Show("Configuracion guardada exitosamente." , "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information); 

            // Finalmente, cierra el formulario de configuración y establece DialogResult.OK
            DialogResult = DialogResult.OK;
            Close(); // Cierra el formulario
        }
    }
}
