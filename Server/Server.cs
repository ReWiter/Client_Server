using devil;
using Npgsql;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Data.Entity;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
namespace Server
{
    public partial class Server : Form
    {
        [Table("product", Schema = "black_market")]
        public class Entity
        {
            [Column("id")] public int Id { get; set; }
            [Column("type")] public string Type { get; set; }
            [Column("name")] public string Name { get; set; }
            [Column("price")] public decimal Price { get; set; }
            [Column("date")] public DateTime Date { get; set; }
        }
        public class LibraryContext : DbContext
        {
            private static string connString = "Host=localhost;Username=postgres;Password=aA1aA1aA1;Database=postgres;";
            public LibraryContext() : base(new NpgsqlConnection(connString), true) { }
            public DbSet<Entity> Entities { get; set; }
        }
        public Server()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Connect();
        }
        private async void Connect()
        {
            string[] WtA;
            string root;
            var server = new TcpListener(IPAddress.Any, 1562);
            BinaryFormatter bf = new BinaryFormatter();
            server.Start();
            while (true)
            {
                dataSet1.Clear();
                var client = await server.AcceptTcpClientAsync();
                Fill_the_table();
                NetworkStream client_stream;
                client_stream = client.GetStream();
                root = (string)bf.Deserialize(client_stream);
                if (root == "Show")
                {
                    client_stream.Flush();
                    client_stream.Write(Class1.GetByteDataSet(dataSet1), 0, Class1.GetByteDataSet(dataSet1).Length);
                    client.Close();
                }
                else if (root == "Add")
                {
                    client_stream.Flush();
                    client_stream = client.GetStream();
                    string words = (string)bf.Deserialize(client_stream);
                    WtA = words.Split(new char[] { ' ','\n' });
                    AddToTable(WtA);
                    client.Close();
                }
            }
        }
        private void Fill_the_table()
        {
            string connString = "Host=localhost;Username=postgres;Password=aA1aA1aA1;Database=postgres";
            string comandString = "select * from black_market.product";
            using (DbDataAdapter dbDataAdapter = new NpgsqlDataAdapter(comandString, connString))
            {
                try
                {
                    dbDataAdapter.Fill(dataSet1);
                }
                catch (Exception ex)
                {

                }
            }
        }
        private void AddToTable(string[] words)
        {
            using (LibraryContext context = new LibraryContext())
            {
                var word = new Entity() { Type = words[0], Name = words[1],
                Price = Convert.ToDecimal(words[2]), Date = DateTime.Now };
                context.Entities.Add(word);
                context.SaveChanges();
            }
        }
    }
}