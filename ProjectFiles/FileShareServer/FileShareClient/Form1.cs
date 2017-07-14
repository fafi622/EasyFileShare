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
          
            //string promptValue = Prompt.ShowDialog("Enter IP", "Add Person");
            
            tabControl1.SelectTab(1);
            connecttionindicater.BackColor = Color.Green;
        }

      
    }

    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
            
            prompt.Width = 300;
            prompt.Height = 200;
            prompt.StartPosition = FormStartPosition.CenterParent;
            prompt.Text = caption;
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text, Width = 200, TextAlign = ContentAlignment.MiddleCenter };
            TextBox inputBox = new TextBox() { Left = 50, Top = 50, Width = 200 };
            Button confirmation = new Button() { Text = "Add", Left = 100, Width = 100, Top = 90 };
            
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.ShowDialog();
            inputBox.Focus();
            return (string)inputBox.Text;
        }
    }
}
