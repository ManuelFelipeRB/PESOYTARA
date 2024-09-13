using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PESOYTARA
{
    public partial class Pesajes : UserControl
    {
        private string datos;
        public string puertoSeleccionado;
        //private SqlConnection conexionSql;
        //private Loggin loggin;
        //private Reportes reportes;
        //private Configuracion configuracion;
        //public SerialPort SerialPort1 { get; private set; }

        public Pesajes()
        {
            InitializeComponent();
            ConfigureSerialPort();
            LoadComboBoxPuertos();
            timer1.Enabled = true;
            // Inicializa el UserControl Loggin y lo añade al formulario actual
            //Loggin userControl = new Loggin
            //{
            //    ParentForm = this
            //};
            //this.Controls.Add(userControl);
            //SerialPort1 = new SerialPort();
        }

        public void LoadComboBoxPuertos()
        {
            string[] puertos = SerialPort.GetPortNames();
            comboBox_puertos.Items.AddRange(puertos);
        }

        public void ConfigureSerialPort()
        {
            SerialPort1.PortName = comboBox_puertos.Text;
            SerialPort1.BaudRate = 9600;
            SerialPort1.Parity = Parity.None;
            SerialPort1.DataBits = 8;
            SerialPort1.StopBits = StopBits.One;
            SerialPort1.DataReceived += SerialPort1_DataReceived;
            SerialPort1.ErrorReceived += SerialPort1_ErrorReceived;
        }

        private void UpdateControlState(bool connected)
        {
            comboBox_bascula.Enabled = !connected;
            comboBox_puertos.Enabled = !connected;
            but_capturar.Enabled = connected;
            but_conectar.Enabled = !connected;
            text_placa.Focus();
        }

        public void but_desconectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (SerialPort1.IsOpen)
                {
                    SerialPort1.Close();
                    MessageBox.Show("Desconectado", "Puerto COM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimpiarDatos();
                    text_peso.ReadOnly = !true;
                    display_peso.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al desconectar: {ex.Message}", "Error de Desconexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                UpdateControlState(false);
            }
        }

        public void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string datos = SerialPort1.ReadLine();

                // Validar o procesar datos aquí si es necesario
                if (IsValidData(datos))
                {
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() =>
                        {
                            display_peso.Text = FormatData(datos);
                        }));
                    }
                    else
                    {
                        display_peso.Text = FormatData(datos);
                    }
                }
                else
                {
                    // Manejo de datos no válidos, si es necesario
                    // Por ejemplo, registrar el problema o mostrar una advertencia
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer del puerto serie: {ex.Message}");
            }
        }

        private bool IsValidData(string data)
        {
            // Implementar lógica para validar datos
            return !string.IsNullOrWhiteSpace(data);
        }

        private string FormatData(string data)
        {
            // Implementar lógica para formatear datos
            return data.Trim(); // Ejemplo de formateo
        }

        public void SerialPort1_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            MessageBox.Show("Se ha producido un error en el puerto serial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void but_guardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(text_peso.Text, out int peso) || peso <= 0 ||
                string.IsNullOrEmpty(text_placa.Text) ||
                comboBox_ejes.Text == "Seleccione" ||
                comboBox_proceso.Text == "Seleccione" ||
                comboBox_proceso.SelectedItem == null ||
                comboBox_ejes.SelectedItem == null)
            {
                MessageBox.Show("Verifique datos ingresados", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

            
            // Aquí iría el código para guardar los datos en la base de datos
            // basededatos nuevoevento = new basededatos(fecha, hora, placa, ejes, pesoini, pesofin, tara, peso_neto);
            // int fila = nuevoevento.addeventopesaje();
            // if (fila == 1)
            // {
            MessageBox.Show("Evento Guardado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarDatos();
            }
        }

        private void LimpiarDatos()
        {
            text_peso.Text = "0";
            text_item.Text = "0";
            text_tara.Text = "0";
            text_placa.Clear();
            text_observaciones.Clear();
            comboBox_ejes.Text = "Seleccione";
            comboBox_proceso.Text = "Seleccione";
            ResetLabels();
        }

        private void ResetLabels()
        {
            label_date.Text = " - - ";
            label_placa.Text = " - - ";
            label_pesoini.Text = " - - ";
            label_pesofin.Text = " - - ";
            label_tara.Text = " - - ";
            label_neto.Text = " - - ";
            label_ejes.Text = " - - ";
            label_sobre.Text = " - - ";
            text_placa.Focus();
        }

        public void but_capturar_Click(object sender, EventArgs e)
        {
            text_peso.Text = display_peso.Text;
            text_peso.Show();
            ActualizarTiquete();
        }

        private void ActualizarTiquete()
        {
            if (comboBox_proceso.Text != "Pesaje Final")
            {
                // Verifica si los campos de placa o tara no están vacíos
                bool esValido = !string.IsNullOrEmpty(text_placa.Text) || !string.IsNullOrEmpty(text_tara.Text);

                if (esValido)
                {
                    // Intenta obtener el peso desde el campo de texto
                    if (int.TryParse(text_peso.Text, out int peso) && int.TryParse(text_tara.Text, out int tara))
                    {
                        // Calcula el peso neto
                        int pesoNeto = Math.Abs(peso - tara);

                        // Actualiza los controles de la interfaz de usuario
                        label_date.Text = label_fecha.Text;
                        label_pesoini.Text = text_peso.Text;
                        label_pesofin.Text = " - - ";
                        label_neto.Text = pesoNeto.ToString();
                        label_ejes.Text = comboBox_ejes.Text;
                        label_tara.Text = text_tara.Text;
                    }
                    else
                    {
                        // Muestra un mensaje de error si la conversión falla
                        MessageBox.Show("El peso o la tara no son números válidos.");
                    }
                }
                else
                {
                    // Muestra un mensaje de error si los campos de placa o tara están vacíos
                    MessageBox.Show("Peso o tara no pueden estar vacíos.");
                    text_tara.Text = ""; // Limpia el campo de tara en caso de error
                }
            }
            else
            {
                Pesofinal();
            }
        }


        private void Pesofinal()
        {
            if (int.TryParse(text_peso.Text, out int peso) && int.TryParse(text_tara.Text, out int tara))
            {
                int pesoNeto = Math.Abs(peso - tara);
                label_date.Text = label_fecha.Text;
                label_pesofin.Text = text_peso.Text;
                label_pesoini.Text = " - - ";
                label_neto.Text = pesoNeto.ToString();
                label_ejes.Text = comboBox_ejes.Text;
                label_tara.Text = text_tara.Text;
            }
            else
            {
                MessageBox.Show("PESO o TARA no válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_tara.Clear();
            }
        }

        private void text_placa_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(text_placa.Text) || !string.IsNullOrEmpty(text_peso.Text))
            {
                but_capturar.Enabled = true;
                label_placa.Text = text_placa.Text;
            }
        }

        private void comboBox_ejes_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_ejes.Text = comboBox_ejes.Text;
        }

        private void text_tara_TextChanged(object sender, EventArgs e)
        {
            if (this.label_neto.Text == "*" || !string.IsNullOrEmpty(text_tara.Text))
            {
                ActualizarTiquete();
            }
            else
            {
                label_tara.Text = text_tara.Text;
            }
        }

        private void MoveFocusOnEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var nextControl = GetNextControl((Control)sender, true);
                if (nextControl != null)
                {
                    nextControl.Focus();
                    e.Handled = true;
                }
            }
        }

        private void text_placa_KeyPress(object sender, KeyPressEventArgs e) => MoveFocusOnEnter(sender, e);
        private void text_tara_KeyPress(object sender, KeyPressEventArgs e) => MoveFocusOnEnter(sender, e);
        private void comboBox_proceso_KeyPress(object sender, KeyPressEventArgs e) => MoveFocusOnEnter(sender, e);
        private void comboBox_ejes_KeyPress(object sender, KeyPressEventArgs e) => MoveFocusOnEnter(sender, e);
        private void text_item_KeyPress(object sender, KeyPressEventArgs e) => MoveFocusOnEnter(sender, e);

        private void comboBox_proceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarTiquete();
        }

        private void comboBox_puertos_SelectedIndexChanged(object sender, EventArgs e)
        {
            puertoSeleccionado = comboBox_puertos.Text;
        }

        private void comboBox_bascula_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aquí iría el código para manejar el cambio en el comboBox_bascula
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label_hora.Text = DateTime.Now.ToString("hh:mm tt");
            label_fecha.Text = DateTime.Now.ToShortDateString();
        }

        public void but_conectar_Click(object sender, EventArgs e)
        {
            {
                if (comboBox_puertos.SelectedItem == null || comboBox_bascula.SelectedItem == null)
                {
                    MessageBox.Show("Error: Seleccione Puerto y Báscula", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    ConfigureSerialPort();
                    SerialPort1.Open();
                    SerialPort1.DataReceived += SerialPort1_DataReceived; // Asegúrate de suscribirte al evento
                    MessageBox.Show("Conexión Exitosa", "Puerto COM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al conectar: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    UpdateControlState(true); // El estado debe ser conectado
                }
            }
        }

    }

}