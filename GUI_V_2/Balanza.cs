using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_V_2
{
    public class Balanza
    {
        private SerialPort serialPort;

        public Balanza()
        {
            // Inicializar el puerto serial, ajustar el nombre y configuración según tu dispositivo
            serialPort = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
        }

        public void Open()
        {
            if (!serialPort.IsOpen)
            {
                serialPort.Open();
            }
        }

        public void Close()
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        public float get_units(int conversionFactor)
        {
            // Asegúrate de que el puerto esté abierto
            if (!serialPort.IsOpen)
            {
                Open();
            }

            // Leer datos desde la balanza
            string data = serialPort.ReadLine(); // O el método que uses para leer datos
            float weight = float.Parse(data) / conversionFactor; // Ajusta según sea necesario

            return weight; // Devuelve el peso
        }
    }
}
