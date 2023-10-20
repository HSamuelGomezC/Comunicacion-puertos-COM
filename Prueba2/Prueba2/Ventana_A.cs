using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Lector_De_Puertos_COM;

namespace Prueba2
{
    public partial class Ventana_A : Form
    {
        private SerialPort puertoCOM;
        private bool opcionAActiva = false;
        private bool detenerHiloLectura = false;
        private Thread hiloLecturaBascula;



        public Ventana_A()
        {
            InitializeComponent();
        }



        private void Ventana_A_Load(object sender, EventArgs e)
        {
            this.FormClosing += Ventana_A_FormClosing;


            // Verificar si la opción 'OpcionA' está activada en la configuración
            opcionAActiva = Settings1.Default.OpcionA;


            if (string.IsNullOrEmpty(Settings1.Default.PuertoSeleccionado))
            {
                MessageBox.Show("Por favor, configure un puerto COM en la opción de configuración antes de abrir la ventana A.", "Configuración Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }
            else
            {
                if (opcionAActiva)
                {
                    //Para abrir el puerto COM
                    if (this.Owner is Ventana_Principal principal)
                    {
                        principal.AbrirPuertoCOM();
                    }

                    // Iniciar el hilo de lectura de la báscula
                    hiloLecturaBascula = new Thread(LecturaBasculaThread);
                    hiloLecturaBascula.Start();
                }
                else
                {
                    MessageBox.Show("Error: Bazcula no activa en Configuracion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                }
            }
        }


        private void LecturaBasculaThread()
        {
            if (opcionAActiva)
            {
                while (!detenerHiloLectura) // Un bucle infinito para continuar intentando hasta recibir "K"
                {
                    EnviarComandoK("F#03");
                    string respuesta = LeerRespuestaBasculaK();

                    if (respuesta != "K")
                    {
                        MessageBox.Show("Error: No se recibió la respuesta esperada 'K' de la báscula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        // Puedes agregar un tiempo de espera antes de intentar nuevamente para evitar una rápida repetición
                        Thread.Sleep(10000); // Esperar 1 minuto antes de volver a intentar
                    }
                    else
                    {
                        // Si se recibe "K", continuar con la lectura normal
                        while (opcionAActiva && !detenerHiloLectura)
                        {
                            // Enviar el comando 'F#02' a la báscula
                            EnviarComando("F#02");

                            // Enviar el comando 'F#01' a la báscula
                            EnviarComando("F#01");

                            string cadena = LeerRespuestaBascula();

                            if (cadena.EndsWith("R1X"))
                            {
                                ActualizarInterfazDesdeHilo(cadena);
                            }

                            // Esperar 1 minuto antes de la siguiente lectura
                            Thread.Sleep(60000);
                        }
                    }
                }
            }
        }


        private void EnviarComandoK(string comando)
        {
            if (puertoCOM != null && puertoCOM.IsOpen)
            {

                puertoCOM.Write(comando + "\r\n");


            }
        }

        private void EnviarComando(string comando)
        {
            if (puertoCOM != null && puertoCOM.IsOpen)
            {
                puertoCOM.DiscardOutBuffer();
                puertoCOM.Write(comando + "\r\n");


            }
        }


        private string LeerRespuestaBascula()
        {
            Thread.Sleep(10);
            if (puertoCOM != null && puertoCOM.IsOpen)
            {
                string respuesta = string.Empty;

                // Leer y descartar datos hasta encontrar una respuesta válida
                while (true)
                {
                    string linea = puertoCOM.ReadLine(); // Leer línea
                    if (linea == null) break; // Salir si no hay más datos
                    if (!linea.StartsWith("F#")) // Ignorar comandos
                    {
                        respuesta = linea.Trim(); // Guardar respuesta válida
                        if (!string.IsNullOrEmpty(respuesta) && !string.IsNullOrWhiteSpace(respuesta))
                        {
                            break; // Salir si la respuesta no es vacía ni espacios en blanco
                        }
                    }
                }

                return respuesta;
            }
            return string.Empty;
        }



        private string LeerRespuestaBasculaK()
        {
            if (puertoCOM != null && puertoCOM.IsOpen)
            {
                string respuesta = string.Empty;
                while (!respuesta.Contains("K"))
                {
                    respuesta += puertoCOM.ReadLine();
                }
                // puertoCOM.DiscardInBuffer();
                if (respuesta.Length > 1)
                {
                    string subcadena = respuesta.Substring(5);


                    return subcadena;
                }
                else
                {

                    return respuesta;

                }
            }
            return string.Empty;
        }


        private void Ventana_A_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cerrar el puerto COM y detener el hilo al cerrar la ventana

            detenerHiloLectura = true; //Primero deten el hilo

            if (hiloLecturaBascula != null && hiloLecturaBascula.IsAlive)
            {
                hiloLecturaBascula.Join(); //Espera a que el hilo termine
            }

            opcionAActiva = false;

            if (puertoCOM != null && puertoCOM.IsOpen)
            {
                if (this.Owner is Ventana_Principal principal)
                {
                    principal.CerrarPuertoCOM();
                }
            }
        }

        private void ActualizarInterfazDesdeHilo(string cadena)
        {
            if (InvokeRequired)
            {
                //Si es necesario, invocar el metodo en el hilo de la interfaz
                BeginInvoke(new Action<string>(ActualizarInterfazDesdeHilo), cadena);
                return;
            }
            //MessageBox.Show(cadena);

            // Buscar las letras y sus índices en la cadena
            Dictionary<char, int> letraIndices = new Dictionary<char, int>();
            for (int i = 0; i < cadena.Length; i++)
            {
                char letra = cadena[i];
                if (char.IsLetter(letra))
                {
                    letraIndices[letra] = i;
                }
            }

            // Extraer valores entre las letras y asignarlos a los TextBox
            foreach (char letra in letraIndices.Keys)
            {
                int startIndex = letraIndices[letra];
                int endIndex = cadena.Length;
                if (letraIndices.ContainsKey((char)(letra + 1)))
                {
                    endIndex = letraIndices[(char)(letra + 1)];
                }
                string valor = cadena.Substring(startIndex + 1, endIndex - startIndex - 1);

                switch (letra)
                {
                    case 'A':
                        textArena1.Text = valor;
                        break;
                    case 'B':
                        textGrava.Text = valor;
                        break;
                    case 'C':
                        textGrava_2.Text = valor;
                        break;
                    case 'D':
                        textGrava_3.Text = valor;
                        break;
                    case 'E':
                        textCemento1.Text = valor;
                        break;
                    case 'F':
                        textAgua1.Text = valor;
                        break;
                    case 'G':
                        textHRArena1.Text = valor;
                        break;
                    case 'H':
                        textHora1.Text = valor;
                        break;
                    case 'I':
                        textFecha1.Text = valor;
                        break;
                    case 'J':
                        textLote1.Text = valor;
                        break;
                }
            }
            InsertarDatosEnBaseDeDatosSiNoExiste();
        }

        // Función para insertar datos en la base de datos si el lote no existe
        private void InsertarDatosEnBaseDeDatosSiNoExiste()
        {
            try
            {
                // Obtener los valores de los TextBox
                string arena = textArena1.Text;
                string grava = textGrava.Text;
                string grava2 = textGrava_2.Text;
                string grava3 = textGrava_3.Text;
                string cemento = textCemento1.Text;
                string agua = textAgua1.Text;
                string hrArena = textHRArena1.Text;
                string hora = textHora1.Text;
                string fecha = textFecha1.Text.Replace(" ", "");
                string lote = textLote1.Text;

                // Obtener los valores de conexión desde el archivo de configuración
                string nombreDB = Settings2.Default.NombreDB;
                string usuario = Settings2.Default.Usuario;
                string contraseña = Settings2.Default.Contraseña;

                // Crear la cadena de conexión a la base de datos (ajusta esto según tu configuración)
                string connectionString = $"Database={nombreDB};Uid={usuario};Pwd={contraseña};";

                // Verificar si el lote ya existe en la base de datos
                string queryVerificar = "SELECT COUNT(*) FROM dbo.TablaA WHERE Lote = @Lote";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand commandVerificar = new SqlCommand(queryVerificar, connection))
                    {
                        commandVerificar.Parameters.AddWithValue("@Lote", lote);
                        int count = Convert.ToInt32(commandVerificar.ExecuteScalar());

                        // Si el lote no existe, procede con la inserción de datos
                        if (count == 0)
                        {
                            // Crear la consulta SQL para insertar los datos en la tabla correspondiente
                            string queryInsertar = "INSERT INTO dbo.TablaA (Arena, Grava1, Grava2, Grava3, Cemento, Agua, Humedad, Hora, Fecha, Lote) " +
                                                   "VALUES (@Arena, @Grava, @Grava2, @Grava3, @Cemento, @Agua, @HrArena, @Hora, @Fecha, @Lote)";

                            using (SqlCommand commandInsertar = new SqlCommand(queryInsertar, connection))
                            {
                                // Agregar parámetros a la consulta
                                commandInsertar.Parameters.AddWithValue("@Arena", arena);
                                commandInsertar.Parameters.AddWithValue("@Grava", grava);
                                commandInsertar.Parameters.AddWithValue("@Grava2", grava2);
                                commandInsertar.Parameters.AddWithValue("@Grava3", grava3);
                                commandInsertar.Parameters.AddWithValue("@Cemento", cemento);
                                commandInsertar.Parameters.AddWithValue("@Agua", agua);
                                commandInsertar.Parameters.AddWithValue("@HrArena", hrArena);
                                commandInsertar.Parameters.AddWithValue("@Hora", hora);
                                commandInsertar.Parameters.AddWithValue("@Fecha", fecha);
                                commandInsertar.Parameters.AddWithValue("@Lote", lote);

                                // Ejecutar la consulta de inserción
                                int rowsAffected = commandInsertar.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Datos guardados en la base de datos correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Error al guardar los datos en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            // El lote ya existe en la base de datos, no se hace nada
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al establecer la conexión con la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }




        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxLote_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void textBoxFecha_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxHora_TextChanged(object sender, EventArgs e)
        {

        }

        //Buscar por fecha
        private void btnFecha_Click(object sender, EventArgs e)
        {
            try
            {

                //Obtener los valores de conexion desde el archivo de configuracion

                string nombreDB = Settings2.Default.NombreDB;
                string usuario = Settings2.Default.Usuario;
                string contraseña = Settings2.Default.Contraseña;



                // Crear la cadena de conexión a la base de datos (ajusta esto según tu configuración)
                string connectionString = $"Database={nombreDB};Uid={usuario};Pwd={contraseña};";

                string Fecha = textBoxFecha.Text;

                string query = "SELECT * FROM dbo.TablaA WHERE Fecha = @Fecha";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Fecha", Fecha);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;

                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron registros con los datos buscados.", "No se encontraron registros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar registros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBoxFecha.Clear();
        }

        //Buscar por lote
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //Obtener los valores de conexion desde el archivo de configuracion

                string nombreDB = Settings2.Default.NombreDB;
                string usuario = Settings2.Default.Usuario;
                string contraseña = Settings2.Default.Contraseña;



                // Crear la cadena de conexión a la base de datos (ajusta esto según tu configuración)
                string connectionString = $"Database={nombreDB};Uid={usuario};Pwd={contraseña};";

                string Lote = textBoxLote.Text.Trim();

                string query = "SELECT * FROM dbo.TablaA WHERE Lote = @Lote";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Lote", Lote);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;

                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron registros con los datos buscados.", "No se encontraron registros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar registros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBoxLote.Clear();
        }


        //Buscar Todos los datos de la DB
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                //Obtener los valores de conexion desde el archivo de configuracion

                string nombreDB = Settings2.Default.NombreDB;
                string usuario = Settings2.Default.Usuario;
                string contraseña = Settings2.Default.Contraseña;



                // Crear la cadena de conexión a la base de datos (ajusta esto según tu configuración)
                string connectionString = $"Database={nombreDB};Uid={usuario};Pwd={contraseña};";



                string query = "SELECT * FROM dbo.TablaA";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {


                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar registros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void ExportarDataGridViewAExcel(DataGridView dataGridView, string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            // Crear el nuevo paquete de Excel
            using (var package = new ExcelPackage())
            {
                // Agregar una nueva hoja de cálculo al paquete
                var worksheet = package.Workbook.Worksheets.Add("Datos Nave A");

                // Rellenar los datos desde el DataGridView
                for (int rowIndex = 0; rowIndex < dataGridView.Rows.Count; rowIndex++)
                {
                    for (int colIndex = 0; colIndex < dataGridView.Columns.Count; colIndex++)
                    {
                        worksheet.Cells[rowIndex + 1, colIndex + 1].Value = dataGridView.Rows[rowIndex].Cells[colIndex].Value;
                    }
                }

                // Aplicar estilo a las celdas (opcional)
                using (var range = worksheet.Cells[1, 1, dataGridView.Rows.Count, dataGridView.Columns.Count])
                {
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    range.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    range.Style.Font.Bold = true;
                }

                // Guardar el paquete en un archivo
                using (var stream = new MemoryStream())
                {
                    package.SaveAs(stream);
                    stream.Position = 0;

                    // Guardar el archivo en disco o hacer lo que necesites con el stream
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        stream.CopyTo(fileStream);
                    }
                }
            }

            MessageBox.Show("Datos exportados a Excel correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                filePath = filePath + ".xlsx";
                ExportarDataGridViewAExcel(dataGridView1, filePath);

            }
        }

        private void lbGrava3_Click(object sender, EventArgs e)
        {

        }

        private void lbLote_Click(object sender, EventArgs e)
        {

        }
    }
}