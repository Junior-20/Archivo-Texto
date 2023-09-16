using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivo_Texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Obtener los datos desde los controles del formulario
            string RNC = txtrnc.Text;
            string TipoRegistro = txtregistro.Text;
            string fechaTransmision = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            string fechaAutodeterminacion = dateTimePicker2.Value.ToString("dd/MM/yyyy");
            string nomina = textnomina.Text;
            string cedula = textcedula.Text;
            string salario = textsalario.Text;
            string dependientes = txtdependientes.Text;

            // Crear una línea de texto con los datos
            string lineaTexto = $"{RNC},{TipoRegistro},{fechaTransmision},{fechaAutodeterminacion},{nomina},{cedula},{salario},{dependientes}";

            // Ruta de la carpeta de descargas del usuario
            string rutaDescargas = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";

            // Nombre del archivo de texto
            string nombreArchivo = "datos.txt";

            // Ruta completa del archivo de texto en la carpeta de descargas
            string rutaArchivo = Path.Combine(rutaDescargas, nombreArchivo);

            try
            {
                // Escribir la línea de texto en el archivo
                using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
                {
                    writer.WriteLine(lineaTexto);
                }

                MessageBox.Show("Datos guardados en el archivo de texto en la carpeta de Descargas correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en el archivo: " + ex.Message);
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            dataTable.Columns.Add("RNC", typeof(string));
            dataTable.Columns.Add("Tipo Registro", typeof(string));
            dataTable.Columns.Add("Fecha T", typeof(string));
            dataTable.Columns.Add("Fecha A", typeof(string));
            dataTable.Columns.Add("Nomina", typeof(string));
            dataTable.Columns.Add("Cedula", typeof(string));
            dataTable.Columns.Add("Salario", typeof(string));
            dataTable.Columns.Add("Dependientes", typeof(string));

            try
            {
                string rutaDescargas = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
                string nombreArchivo = "datos.txt";
                string[] archivos = Directory.GetFiles(rutaDescargas, nombreArchivo, SearchOption.TopDirectoryOnly);

                if (archivos.Length > 0)
                {
                    string rutaCompleta = archivos[0];
                    string dato;
                    System.IO.StreamReader file = new System.IO.StreamReader(rutaCompleta);

                    while ((dato = file.ReadLine()) != null) {

                        string[] linea = dato.Split(',');
                        DataRow registro = dataTable.NewRow();
                        registro["RNC"] = linea[0];
                        registro["Tipo Registro"] = linea[1];
                        registro["Fecha T"] = linea[2];
                        registro["Fecha A"] = linea[3];
                        registro["Nomina"] = linea[4];
                        registro["Cedula"] = linea[5];
                        registro["Cedula"] = linea[5]; //.Insert(3, "-").Insert(11, "-");
                        registro["Salario"] = linea[6];
                        registro["Dependientes"] = linea[7];
                        dataTable.Rows.Add(registro);

                    }
                    file.Close();
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("El archivo no se encontró en la carpeta de Descargas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtregistro_Click(object sender, EventArgs e)
        {

        }






    }
}



