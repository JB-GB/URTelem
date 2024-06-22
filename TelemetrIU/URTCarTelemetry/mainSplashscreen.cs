using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace URTCarTelemetry
{
    public partial class mainSplashscreen : Form
    {
        // Variables globales
        string[] ports = SerialPort.GetPortNames();
        //

        public mainSplashscreen()
        {
            InitializeComponent();
            cbxSerialPorts.Items.Clear();
            cbxSerialPorts.Items.AddRange(ports);
        }

        private void btnStart_Click(object sender, EventArgs e) // Iniciar el logger de datos entrantes
        {

        }

        private void btnUpdateSerialPorts_Click(object sender, EventArgs e) // Actualizar los puertos seriales disponibles
        {
            cbxSerialPorts.Items.Clear();
            if (ports != SerialPort.GetPortNames()) 
            {
                string[] ports = SerialPort.GetPortNames();
                cbxSerialPorts.Items.AddRange(ports);
                MessageBox.Show("Hay puertos nuevos!", "Port update");
                //Sacar messagebox para mostrar que se han encontrado puertos
                //Anadir los items
            }
        }

        private void btnStartDB_Click(object sender, EventArgs e) // Checar la conexion con la base de datos
        {
            
        }

        private void chbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxShowPass.Checked == true)
            {
                tbxDBPass.UseSystemPasswordChar = false;
            }
            else
            {
                tbxDBPass.UseSystemPasswordChar = true;
            }
        }
    }
}
