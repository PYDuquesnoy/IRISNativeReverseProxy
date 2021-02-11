using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using InterSystems.Data.IRISClient;
using InterSystems.Data.IRISClient.ADO;

namespace IrisNative
{
    public partial class IrisNative : Form
    {
        IRISConnection connection;
        IRIS irisNativeCn;

        public IrisNative()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //Retrieve connection information from form
            string ip = txtServer.Text;
            int port = Convert.ToInt32(txtPort.Text);
            string Namespace = txtNamespace.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            ///
            // Making connection using IRISConnecion
            connection = new IRISConnection();

            // Create connection string
            connection.ConnectionString = "Server = " + ip + "; Port = " + port + "; Namespace = " +
                                    Namespace + "; Password = " + password + "; User ID = " + username;
            connection.Open();
            txtLog.AppendText("Connected to " + connection.ConnectionString);

            irisNativeCn = IRIS.CreateIRIS(connection);
            ///
            grpUpload.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show the dialog that allows user to select a file, the 
            // call will result a value from the DialogResult enum
            // when the dialog is dismissed.
            DialogResult result = this.openFileDialog1.ShowDialog();
            // if a file is selected
            if (result == DialogResult.OK)
            {
                // Set the selected file URL to the textbox
                this.txtFilename.Text = this.openFileDialog1.FileName;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string filename = System.IO.Path.GetFileName(txtFilename.Text);
            string serverpath = Path.Combine(txtServerDir.Text, filename);
            txtLog.AppendText("\r\n");
            txtLog.AppendText("Uploading '" + txtFilename.Text + "' to Server as '"+serverpath+"'");
            
            ///Get Server FileStream: Reverse Proxy Object
            ///https://docs.intersystems.com/irislatest/csp/docbook/Doc.View.cls?KEY=BNETNAT_gateway
            IRISObject fileStr = (IRISObject)irisNativeCn.ClassMethodObject("%Stream.FileBinary","%New");
            fileStr.InvokeIRISStatusCode("LinkToFile", serverpath);

            ///Open Local Stream
            FileStream fs = File.OpenRead(txtFilename.Text);

            byte[] buf = new byte[1024];
            int c;

            while ((c = fs.Read(buf, 0, buf.Length)) > 0)
            {
                if (c == buf.Length)
                {
                    fileStr.InvokeIRISStatusCode("Write", buf);
                }else
                {
                    byte[] endbuf=new byte[c];
                    Array.Copy(buf, endbuf, c);
                    fileStr.InvokeIRISStatusCode("Write", endbuf);
                }
                //Console.WriteLine(Encoding.UTF8.GetString(buf, 0, c));
            }
            fileStr.InvokeIRISStatusCode("%Save");
            fileStr.InvokeIRISStatusCode("%Close");
            txtLog.AppendText("\r\nFinished uploading "+fs.Length+" bytes to "+fileStr.Get("Size"));
        }
    }
}
