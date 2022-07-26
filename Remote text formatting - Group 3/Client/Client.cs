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
using System.IO;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;



namespace Client
{
    public partial class Client : Form
    {
        IPAddress iP;
        int port;
        IPEndPoint ipe;
        Socket client;

        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            LockControl();
   
        }

        void LockControl()
        {
            IPbox.ReadOnly = false;
            Portbox.ReadOnly = false;
            ConnectBut.Enabled = true;
            IPbox.Focus();

            SelectBut.Enabled = false;
            SendBut.Enabled = false;
            DownBut.Enabled = false;
            ClearBut.Enabled = false;
        }

        void UnlockConTrol()
        {
            IPbox.ReadOnly = true;
            Portbox.ReadOnly = true;
            ConnectBut.Enabled = false;
            IPbox.Focus();

            SelectBut.Enabled = true;
            SendBut.Enabled = true;
            DownBut.Enabled = true;
            ClearBut.Enabled = true;
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void ConnectBut_Click(object sender, EventArgs e)
        {
            Connect();
            if (IPbox.Text == "")
            {
                LockControl();
            }
            else
            {
                UnlockConTrol();
            }
        }

        private void SendBut_Click(object sender, EventArgs e)
        {
            Send();
        }

        void Connect()
        {
            try
            {
                iP = IPAddress.Parse(IPbox.Text.Trim());
                port = Int32.Parse(Portbox.Text.Trim());
                ipe = new IPEndPoint(iP, port);
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                client.Connect(ipe);
                MessageBox.Show("Kết nối thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch
            {
                MessageBox.Show("Không kết nối được Server!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.None);
                IPbox.Text = "";
                Portbox.Text = "";
                return;
            }
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        void Close()
        {
            client.Close();
        }

        void Send()
        {
            if(richTextBox1.Text!= string.Empty)
            {
                client.Send(Serialize(richTextBox1.Text));
            }
        }


        void Receive()
        {

            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string message = (string)Deserialize(data);
                    richTextBox2.Rtf = message;
                }
            }
            catch
            {
                return;
            }
        }

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        private void SelectBut_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            richTextBox1.Text = content;
            fs.Close();
        }

        private void DownBut_Click(object sender, EventArgs e)
        {
            SaveMyFile();
        }
        public void SaveMyFile()
        {
            // Create a SaveFileDialog to request a path and file name to save to.
            SaveFileDialog saveFile1 = new SaveFileDialog();

            // Initialize the SaveFileDialog to specify the RTF extention for the file.
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            // Determine whether the user selected a file name from the saveFileDialog.
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                richTextBox2.SaveFile(saveFile1.FileName);
            }
        }

        private void ClearBut_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
        }

    }
}
