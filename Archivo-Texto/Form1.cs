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
            string fechaTransmision = dateTimePicker1.Text;
            string fechaAutodeterminacion = dateTimePicker2.Text;
            string nomina = textnomina.Text;
            string cedula = textcedula.Text;
            string salario = textsalario.Text;

            // Crear una línea de texto con los datos
            string lineaTexto = $"RNC: {RNC}, Tipo de Registro: {TipoRegistro}, Fecha de Transmisión: {fechaTransmision}, Fecha de Autodeterminación: {fechaAutodeterminacion}, Nómina: {nomina}, Cédula: {cedula}, Salario: {salario}";

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

                MessageBox.Show("Datos guardados en el archivo de texto en la carpeta de descargas correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en el archivo: " + ex.Message);
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {

        }
    }
}
    
    

