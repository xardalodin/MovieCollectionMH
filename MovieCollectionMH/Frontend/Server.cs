using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieCollectionMH.Frontend
{
    public partial class Server : Form
    {

        backend.fileserver.jsonFileServerControlls server;
        public Server(string filename,string ip)
        {
            InitializeComponent();

            //(start server 
            server = new backend.fileserver.jsonFileServerControlls();

            server.StartServer(filename, ip);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            server.stopserver();
            this.Close();
        }
    }
}
