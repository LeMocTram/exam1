using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;


namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }


        IPEndPoint IP;
        Socket ser;
        List<Socket> clientList;

        void Connect()
        {
            clientList = new List<Socket>();

            IP = new IPEndPoint(IPAddress.Any, 9999);
            ser = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            ser.Bind(IP);
            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        ser.Listen(100);
                        Socket cli = ser.Accept();
                        clientList.Add(cli);

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(cli);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    ser = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
        }

        void Close(Socket cli)
        {
            ser.Close();
        }

        void Send(Socket cli)
        {
            if (richTextBox1.Text != string.Empty)
                cli.Send(Serialize(richTextBox1.Rtf));
        }

        void Receive(object obj)
        {
            Socket cli = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    cli.Receive(data);
                    string message = (string)Deserialize(data);


                    richTextBox1.Text = message;
                }
            }
            catch
            {
                clientList.Remove(cli);
                cli.Close();
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

        //Hàm viết hoa đầu dòng
        public string CapitalizeFirstLetter(string value)
        {
            value = value.ToLower();
            char[] array = value.ToCharArray();
            if (array.Length >= 1)
            {
                if (char.IsLower(array[1]))
                {
                    array[1] = char.ToUpper(array[1]);
                }
            }
            return new string(array);
        }

        private void SendBut_Click_1(object sender, EventArgs e)
        {
            foreach (var item in clientList)
            {
                Send(item);
            }
        }

        private void Server_Load(object sender, EventArgs e)
        {
           
        }

        //màu chữ 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Yellow")
            {

                richTextBox1.SelectionColor = Color.Yellow;
            }
            if (comboBox1.Text == "Red")
            {

                richTextBox1.SelectionColor = Color.Red;
            }
            if (comboBox1.Text == "Orange")
            {

                richTextBox1.SelectionColor = Color.Orange;
            }
            if (comboBox1.Text == "Blue")
            {

                richTextBox1.SelectionColor = Color.Blue;
            }
            if (comboBox1.Text == "Black")
            {

                richTextBox1.SelectionColor = Color.Black;
            }
        }

        //size chữ 
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            float choose = Convert.ToSingle(this.comboBox2.SelectedItem.ToString());
            this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont.FontFamily, choose, this.richTextBox1.SelectionFont.Style);
        }

        //Font chữ
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choose = this.comboBox3.SelectedItem.ToString();
            this.richTextBox1.SelectionFont = new Font(choose, this.richTextBox1.SelectionFont.Size, this.richTextBox1.SelectionFont.Style);
        }
        //In đậm
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, this.richTextBox1.SelectionFont.Style ^ FontStyle.Bold);

        }
        //In nghiêng
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, this.richTextBox1.SelectionFont.Style ^ FontStyle.Italic);

        }
        //Gạch chân
        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, this.richTextBox1.SelectionFont.Style ^ FontStyle.Underline);

        }


        void Format()
        {
            //Xóa khoảng trắng
            string rbText = richTextBox1.Text;
            rbText = rbText.Trim();
            Regex trimmer = new Regex(@"\s\s+");
            rbText = trimmer.Replace(rbText, " ");
            CapitalizeFirstLetter(rbText);

            richTextBox1.Text = rbText;
            //Viết hoa đầu dòng
            /*
            string[] rbArray = rbText.Split(new char[] { '.' });
            for (int i = 0; i < rbText.Length; i++)
            {
                

                richTextBox2.Text =rbArray[i];
            }
            */
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
                richTextBox1.SaveFile(saveFile1.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Format();
        }
    }
}
