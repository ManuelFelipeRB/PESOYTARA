using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO.Ports;
using peso_y_tara.Properties;


namespace PESOYTARA
{
    public partial class Form1 : Form
    {
        private Loggin Loggin;
        private Pesajes Pesajes;
        private Reportes Reportes;
        private Configuracion Configuracion;
        private List<Control> controlesOriginales = new List<Control>();

        public Form1()
        {
            InitializeComponent();
            GuardarControlesOriginales();
            timer1.Start();
            //Pesajes Pesajes = new pesajes();
           // this.Controls.Add(pesajes);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            // Cambiar el ancho del panel de menú vertical entre 250 y 70
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;

                // Cambiar la imagen del botón al estado contraído
                btnMenu.Image = peso_y_tara.Properties.Resources.Chevron_Right; // Reemplaza con tu recurso RIGHT
            }
            else
            {
                MenuVertical.Width = 250;

                // Cambiar la imagen del botón al estado expandido
                btnMenu.Image = peso_y_tara.Properties.Resources.Chevron_Left; // Reemplaza con tu recurso LEFT
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label_hora.Text = DateTime.Now.ToString("hh:mm tt");
            //label_fecha.Text = DateTime.Now.ToLongDateString();
        }

        public void iconcerrar_Click(object sender, EventArgs e)
        {
            try
            {
                //if (Pesajes.SerialPort1.IsOpen)
                //{
                //    Pesajes.SerialPort1.Close();
                //    MessageBox.Show("Desconectado", "Puerto COM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //    Pesajes.text_peso.ReadOnly = true;
                //    display_peso.Text = "";
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al desconectar: {ex.Message}", "Error de Desconexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
              
                Application.Exit();
            }
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void GuardarControlesOriginales()
        {
            // Guarda una copia de los controles actuales
            controlesOriginales = this.Backpanel.Controls.Cast<Control>().ToList();
        }

        private void RestaurarControlesOriginales()
        {
            // Limpia el panel
            this.Backpanel.Controls.Clear();

            // Añade los controles guardados
            foreach (var control in controlesOriginales)
            {
                this.Backpanel.Controls.Add(control);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            paneldefondo("Loggin");
        }

        internal void paneldefondo(string panelName)
        {
            this.Backpanel.Controls.Clear();

            switch (panelName)
            {

                case "reportes":
                    if (this.Reportes == null)
                    {
                        this.Reportes = new Reportes();
                        this.Backpanel.Controls.Add(Reportes);
                        this.Reportes.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.Reportes.Location = new System.Drawing.Point(0, 0);
                        this.Reportes.Name = "reporte";
                        this.Size = new System.Drawing.Size(1300, 650);
                        this.Reportes.TabIndex = 0;
                    }
                    else
                    {
                        this.Backpanel.Controls.Add(Reportes);
                    }
                    break;
                case "config":
                    if (this.Configuracion == null)
                    {
                        this.Configuracion = new Configuracion();
                        this.Backpanel.Controls.Add(Configuracion);
                        this.Configuracion.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.Configuracion.Location = new System.Drawing.Point(0, 0);
                        this.Configuracion.Name = "configurar";
                        this.Size = new System.Drawing.Size(1300, 650);
                        this.Configuracion.TabIndex = 0;
                    }
                    else
                    {
                        this.Backpanel.Controls.Add(Configuracion);
                    }
                    break;
                case "Loggin":

                    if (this.Loggin == null)
                    {
                        this.Loggin = new Loggin();
                        this.Backpanel.Controls.Add(Loggin);
                        this.Loggin.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.Loggin.Location = new System.Drawing.Point(0, 0);
                        this.Loggin.Name = "Loggin";
                        this.Size = new System.Drawing.Size(1300, 650);
                        this.Loggin.TabIndex = 0;
                    }
                    else
                    {
                        this.Backpanel.Controls.Add(Loggin);
                    }
                    break;
                case "pesajes":

                    if (this.Pesajes == null)
                    {
                        this.Pesajes = new Pesajes();
                        this.Backpanel.Controls.Add(Loggin);
                        this.Pesajes.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.Pesajes.Location = new System.Drawing.Point(0, 0);
                        this.Pesajes.Name = "pesajes";
                        this.Size = new System.Drawing.Size(1300, 650);
                        this.Pesajes.TabIndex = 0;
                    }
                    else
                    {
                        this.Backpanel.Controls.Add(Pesajes);
                    }
                    break;
                default:

                    //this.defaultControl.BringToFront();
                    break;

            }
        }

        private void btnlogoInicio_Click(object sender, EventArgs e)
        {
            RestaurarControlesOriginales();
        }

        private void but_loggin_Click(object sender, EventArgs e)
        {
            paneldefondo("Loggin");
        }

        private void but_pesajes_Click(object sender, EventArgs e)
        {
            paneldefondo("pesajes");
        }

        private void but_configuracion_Click(object sender, EventArgs e)
        {
            paneldefondo("config");
        }

        private void but_reportes_Click(object sender, EventArgs e)
        {
            paneldefondo("reportes");
        }



    }
}
