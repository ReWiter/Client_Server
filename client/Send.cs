using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using devil;
namespace client
{
    public partial class Send : Form
    {
        public Send()
        {
            InitializeComponent();
        }
        private void Sendmess()
        {
            TcpClient client = new TcpClient("192.168.88.17", 1562);
            NetworkStream client_stream;
            client_stream = client.GetStream();
            client_stream.Write(Class1.GetByteDataSet("Add"), 0, Class1.GetByteDataSet("Add").Length);
            client_stream.Flush();
            string w2 = TypeBox.Text+" "+NameBox.Text+" "+PriceBox.Text+" ";
            client_stream.Write(Class1.GetByteDataSet(w2), 0, Class1.GetByteDataSet(w2).Length);
        }
        private void TypeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ok_Click(object sender, EventArgs e)
        {
            Sendmess();
            Close();
        }
    }
}