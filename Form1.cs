using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPMotionOWL

{
    public partial class MainForm : Form
    {
        private TcpClient tcpClient;
        private NetworkStream stream;
        private bool isConnected;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            isConnected = false;
            UpdateConnectionStatus();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                Disconnect();
            }
            else
            {
                try
                {
                    string ipAddress = ipAddr_tb.Text;
                    int port = int.Parse(port_tb.Text);
               
                    tcpClient = new TcpClient(ipAddress, port);
                    stream = tcpClient.GetStream();
                    isConnected = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to connect: " + ex.Message);
                    isConnected = false;
                }

                UpdateConnectionStatus();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Not connected to the server.");
                return;
            }

            Button btn = (Button)sender;
            string message = btn.Text.ToString();
            SendMessage(message);
        }

        private void SendMessage(string message)
        {
            try
            {
                byte[] data = Encoding.ASCII.GetBytes(message);
                stream.Write(data, 0, data.Length);
                //MessageBox.Show("Message sent successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send message: " + ex.Message);
                Disconnect();
            }
        }

        private void Disconnect()
        {
            if (stream != null)
                stream.Close();

            if (tcpClient != null)
                tcpClient.Close();

            isConnected = false;
            UpdateConnectionStatus();
        }

        private void UpdateConnectionStatus()
        {
            labelStatus.Text = isConnected ? "Connected" : "Disconnected";
            connectBtn.Text = isConnected ? "Disconnect" : "Connect";
        }
    }
}
