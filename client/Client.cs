using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using devil;
namespace client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        private void Showing(TcpClient client,BinaryFormatter bf)
        {
            NetworkStream client_streem = client.GetStream();
            DataSet data = (DataSet)bf.Deserialize(client_streem);
            dataGridView1.DataSource = data.Tables[0].DefaultView;
        }
        private void Conn()
        {
            TcpClient client = new TcpClient("192.168.88.17", 1562);
            NetworkStream client_stream;
            client_stream = client.GetStream();
            client_stream.Write(Class1.GetByteDataSet("Show"), 0, Class1.GetByteDataSet("Show").Length);
            BinaryFormatter bf = new BinaryFormatter();
            Showing(client, bf);
        }
        private void Show_Click(object sender, EventArgs e)
        {
            Conn();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            int rowsCount = dataGridView1.Rows.Count;
            for (int i = 0; i < rowsCount - 1; i++)
            {
                dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            Send send = new Send();
            send.Show();
        }
    }
}