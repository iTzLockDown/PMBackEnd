using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeruMoney.WS.Dominio;
using PeruMoney.WS.Modelo.Request;
using PeruMoney.WS.Repositorio.Contrato;

namespace PeruMoney.DS.Windows
{
    public partial class Form1 : Form
    {
        String sMacAddress = string.Empty;
        IPHostEntry host;
        String ipPrivada = String.Empty;
        String ipPublica = String.Empty;
        String nombreEquipo = String.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public bool GrabarEditar()
        {
            bool respuesta = false;
            PEMEquipo oPemEquipo = new PEMEquipo();
            oPemEquipo.Nombre = RetornaNombre();
            oPemEquipo.MediaAccessControl = RetornaMAc();
            oPemEquipo.ProtocoloInternetPublico = RetornaIpPublica();
            oPemEquipo.ProtocoloInternetPrivado = RetornaIpPrivada();
            oPemEquipo.Usuario = 1;
            using (IEquipoDominio oDominio = new EquipoDominio())
            {
                respuesta = oDominio.GrabarEditar(oPemEquipo);
            }

            return respuesta;
        }

        public void MostrarInformacion()
        {
            textBox1.Text = RetornaMAc();
            textBox2.Text = RetornaIpPrivada();
            textBox3.Text = RetornaIpPublica();
            textBox4.Text = RetornaNombre();
            button2.Enabled = true;
        }
        public string RetornaMAc()
        {

            try
            {
                NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();

                foreach (NetworkInterface adapter in nics)
                {
                    if (sMacAddress == String.Empty)
                    {
                        IPInterfaceProperties properties = adapter.GetIPProperties();
                        sMacAddress = adapter.GetPhysicalAddress().ToString();
                    }
                }
            }
            catch (Exception)
            {
                sMacAddress = "Error de busqueda, verificar.";
            }
            return sMacAddress;
        }

        public string RetornaIpPrivada()
        {
            try
            {
                host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily.ToString() == "InterNetwork")
                    {
                        ipPrivada = ip.ToString();
                    }
                }
            }
            catch (Exception)
            {
                ipPrivada = "Error de busqueda, verificar.";
            }
            return ipPrivada;
        }

        public string RetornaIpPublica()
        {


            try
            {
                ipPublica = new WebClient().DownloadString("http://checkip.dyndns.org/").ToString();
                ipPublica = new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}").Matches(ipPublica)[0].ToString();
            }
            catch (Exception)
            {
                ipPublica = "Error de busqueda, verificar.";
            }


            return ipPublica;
        }
        public string RetornaNombre()
        {
            try
            {
                nombreEquipo = Environment.MachineName;
            }
            catch (Exception)
            {

                nombreEquipo = "PCError";
            }

            return nombreEquipo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarInformacion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (GrabarEditar())
            {
                MessageBox.Show("Se agrego correctamente.", "Información",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                
                MessageBox.Show("Verificar informacion.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            
        }
    }
}
