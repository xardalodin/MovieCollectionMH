using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieCollectionMH
{
    public partial class MainWindow : Form
    {
       

        public MainWindow()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    label5.Text = "Address: " + address.ToString() + ":8080/simpleserver/";
                }

            }
        }

        // export Excel
        private void button1_Click(object sender, EventArgs e)
        {
            backend.ExcelHandler handler = new backend.ExcelHandler();
            List<backend.Movies> mov = handler.ImpExcel(tbLoadExcel.Text);
            populateList(mov);
        }

        private void populateList(List<backend.Movies> mov)
        {
            List<ListViewItem> LLV = new List<ListViewItem>();

            foreach (backend.Movies m in mov)
            {
                ListViewItem LVI = new ListViewItem();
                LVI.Text = m.Movie;
                LVI.SubItems.Add(m.Length);
                LVI.SubItems.Add(m.Format);
                LLV.Add(LVI);   
            }
            listView1.Items.Clear();
            listView1.Items.AddRange(LLV.ToArray());
        } 


        private List<backend.Movies> retrive()
        {
            List<backend.Movies> List = new List<backend.Movies>();

            foreach (ListViewItem LVI in listView1.Items)
            {
                backend.Movies temp = new backend.Movies();
                temp.Movie = LVI.Text;
                temp.Length = LVI.SubItems[1].Text;
                temp.Format = LVI.SubItems[2].Text;
                List.Add(temp);                    
            }
            return List;
        }


        // load from file
        private void button3_Click(object sender, EventArgs e)
        {
            //create excel save handler
            backend.ExcelHandler handler = new backend.ExcelHandler();
            //create List of movies
            backend.MovieList movlis = new backend.MovieList();

            //load the list from listview
            movlis.ListOfMovies = retrive();
            try
            {
                //save to file
                handler.ExportExcel(movlis, tbSaveExcel.Text);
            }
            catch (Exception x)
            {

                MessageBox.Show("fileName Bad"+x);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            backend.MovieList movlis = new backend.MovieList();

            //load the list from listview
            movlis.ListOfMovies = retrive();

            backend.json.json.JsonSerial(movlis.ListOfMovies, tbJsonSave.Text);
            tbfiletoServer.Text = tbJsonSave.Text;
        }

        private void btStartServer_Click(object sender, EventArgs e)
        {
            
            // create the server 
            Frontend.Server from = new Frontend.Server(tbfiletoServer.Text,tbIpAddress.Text);
            // create the movieList
            from.Show();          

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                tbfiletoServer.Text = fdlg.FileName;
            } 
        }

        private void btnBrowseSaveToJson_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                tbJsonSave.Text = fdlg.FileName;
            }
        }

        private void btnBrowseSaveToExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                tbSaveExcel.Text = fdlg.FileName;
            }
        }

        private void btnBrowseLoadExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                tbLoadExcel.Text = fdlg.FileName;
            }
        }
    }
}
