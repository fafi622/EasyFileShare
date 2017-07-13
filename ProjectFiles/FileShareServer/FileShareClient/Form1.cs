using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
namespace FileShareClient
{
    public partial class Form1 : Form
    {
        private Socket server = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
        private IPEndPoint address;
        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            address = new IPEndPoint(IPAddress.Parse(IPtextbox.Text), 25567);
            server.Connect(address);
            AlertLable.Text = "Connected To a server";
            IPlabel.Visible = false;
            IPtextbox.Visible = false;
            ConnectButton.Visible = false;
            FirstPanle.Visible = true;
        }
    }
}
