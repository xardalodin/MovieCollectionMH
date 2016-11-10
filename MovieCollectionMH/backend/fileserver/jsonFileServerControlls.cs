using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;
using  System.Threading;

namespace MovieCollectionMH.backend.fileserver
{
    class jsonFileServerControlls
    {
        private HttpListener listener = null;
        private BackgroundWorker backServer;
        private bool running = true;
        private string FileN;

        public void StartServer(string filename)
        {

            FileN = filename;
            listener = new HttpListener();
            listener.Prefixes.Add("http://192.168.1.2:8080/simpleserver/");
            listener.Start();

            backServer = new BackgroundWorker();  // create background worker 
            backServer.DoWork += new DoWorkEventHandler(back_DoWork); // add function to worker
            // dont need a on backround worker completed completed 
            backServer.RunWorkerAsync();  // start worker;
            backServer.WorkerSupportsCancellation = true;

        }

        private void back_DoWork(object sender, DoWorkEventArgs e)
        {

            while (running)
            {
                try
                {
                    HttpListenerContext context = listener.GetContext();
                    WriteFile(context, FileN);  // test file location , lanch a task ??   
                }
                catch (WebException x)
                {
                    MessageBox.Show(x.Message.ToString());
                }
           }
        }

        public void stopserver()
        {
            try
            {
                //shuting bacground worker down
                running = false; // turn off while loop;
                listener.Close();
                System.Threading.Thread.Sleep(1000); // wait for lisner close
                backServer.CancelAsync(); // kills backServer thread;

                listener.Close();
            }
            catch (WebException x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }

        void WriteFile(HttpListenerContext ctx, string path)
        {
            Console.WriteLine("start writeline");
            var response = ctx.Response;
            using (FileStream fs = File.OpenRead(path))
            {
                string filename = Path.GetFileName(path);
                //response is HttpListenerContext.Response...
                response.ContentLength64 = fs.Length;
                response.SendChunked = false;
                response.ContentType = System.Net.Mime.MediaTypeNames.Application.Octet;
                response.AddHeader("Content-disposition", "attachment; filename=" + filename);

                byte[] buffer = new byte[64 * 1024];
                int read;
                using (BinaryWriter bw = new BinaryWriter(response.OutputStream))
                {
                    while ((read = fs.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        bw.Write(buffer, 0, read);
                        bw.Flush(); //seems to have no effect
                    }

                    bw.Close();
                }

                response.StatusCode = (int)HttpStatusCode.OK;
                response.StatusDescription = "OK";
                response.OutputStream.Close();
            }
        }

    }
}
