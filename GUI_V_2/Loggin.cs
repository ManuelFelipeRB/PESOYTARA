using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using PESOYTARA;

namespace PESOYTARA
{
    public partial class Loggin : UserControl
    {
        public Loggin()
        {
            InitializeComponent();
        }
        private void but_conectar_Click_1(object sender, EventArgs e)
        {

            if (text_usuario.Text == "" || text_contraseña.Text == "")
            {
                MessageBox.Show("Error: usuario y contraseña", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Bienvenido", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text_usuario.Clear();
                text_contraseña.Clear();

            }
                
            
        }


    }
}



