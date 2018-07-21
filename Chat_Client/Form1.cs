using System;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Chat_Client
{
    public partial class Form1 : Form
    {
       
        static string userName;
        public string host;
        private const int port = 2222;
        static TcpClient client;
        static NetworkStream stream;
        ColorDialog color;
        public  Image img { set; get; }
        
        public Form1()
        {
            InitializeComponent();

            chatTextBox.ReadOnly = true;
            sineINbutton.Enabled = true;
            sineOUTbutton.Enabled = false;
            send_button.Enabled = false;
       


      
           
        }
        //---------------------------------------------------------------------------------------
        static void SendMessage()
        {
            MessageBox.Show("Введите сообщение:");

            while (true)
            {
                string message = Console.ReadLine();
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);
            }
        }

        //---------------------------------------------------------------------------------------

        private void ReceiveMessage()
        {
        
            
            while (true)
            {
                try
                {
                 

                    byte[] data = new byte[128]; // буфер для получаемых данных
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));

                    }
                    while (stream.DataAvailable);

                    string message = builder.ToString();

                    this.Invoke(new MethodInvoker(() =>
                    {
                      //chatTextBox.TextAlign = HorizontalAlignment.Right;

                        string time_message_out = DateTime.Now.ToShortTimeString();
                        chatTextBox.Text+= time_message_out + " : " + message + "\r\n" + chatTextBox.Text;
                    }));
                }

        
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    chatTextBox.Text+= ("Подключение прервано!");
                    Disconnect();
                }
            }
              
            }
        
//----------------------------------------------------------------------------------------
      static void Disconnect()
        {
            if (stream != null) stream.Close();
            if (client != null) client.Close();
            Environment.Exit(0);
                 
        }
//-----------------------------------------------------------------------------------------
        private void colorTextBox_TextChanged(object sender, EventArgs e)
        {
             color = new ColorDialog();
            color.AllowFullOpen = true;
            color.ShowHelp = true;
            color.Color = colorTextBox.ForeColor;

            if (color.ShowDialog() == DialogResult.OK)
            {
                colorTextBox.Text = color.ToString();
                color.AllowFullOpen = false;
                color.ShowHelp = false;
                return;
            }
           
              chatTextBox.ForeColor = color.Color;
            
        }
//--------------------------------------------------------------------------------------------------
        private void sineINbutton_Click(object sender, EventArgs e)
        {
            userName = nameTextBox.Text;
            nameTextBox.ReadOnly = true;

            host = ipTextBox.Text;
            ipTextBox.ReadOnly = true;

            chatTextBox.ForeColor = color.Color;
            colorTextBox.ReadOnly = true;
            img = pictureBox1.Image; 
 

            sineINbutton.Enabled = false;
            sineOUTbutton.Enabled = true;
             send_button.Enabled = true;

            client = new TcpClient();
            try
            {
                client.Connect(host, port);
               stream = client.GetStream();

                 string message = userName;
                string ip = host;
                byte[] data = Encoding.Unicode.GetBytes(message+" IP: "+host);
                stream.Write(data, 0, data.Length);

                Thread receiveThread = new Thread(new ThreadStart(ReceiveMessage));
                receiveThread.Start();

                
                chatTextBox.Text = ($"  Добро пожаловать {userName} в нашем чате!\r\n\r\n");
              
             

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
         

        }
//-----------------------------------------------------------------------------------------------
        private void send_button_Click(object sender, EventArgs e)
        {
            try
            {
                string message = String.Format($"{userName} : {messageTextBox.Text}");
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);
                chatTextBox.ForeColor = color.Color;
                string time_message_out = DateTime.Now.ToShortTimeString();

                
               
                chatTextBox.Text += time_message_out+"\r\n"+ message + "\r\n\r\n";
                messageTextBox.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //-------------------------------------------------------------------------------------------

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          
                ExitChat();
        }


        //-------------------------------------------------------------------------------------------

        private void ExitChat()
        {
            string mess = userName + " покинул чат";
            byte[] data = Encoding.Unicode.GetBytes(mess);
            stream.Write(data, 0, data.Length);

         
            client.Close();
        }
        //------------------------------------------------------------------------------------------------------

        private void sineOUTbutton_Click(object sender, EventArgs e)
        {
            nameTextBox.ReadOnly = false;
            ExitChat();

            sineINbutton.Enabled = true;
            sineOUTbutton .Enabled= false;
            send_button.Enabled = false;
        }

        private void chatTextBox_TextChanged(object sender, EventArgs e)
        {
            
          //  chatTextBox.TextAlign = HorizontalAlignment.Left;
            chatTextBox.ForeColor = color.Color;
        }

  //------------------------------------------------------------------------------------------------------------------------     

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }
//---------------------------------------------------------------------------------------------------------------------------
        int click = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            click++;
            switch(click)
            {
                case 1:
                     pictureBox1.Image= global::Chat_Client.Properties.Resources._2;
                   
                    break;
                case 2:
                    pictureBox1.Image = global::Chat_Client.Properties.Resources._3;
                    break;
                case 3:
                    pictureBox1.Image = global::Chat_Client.Properties.Resources._4;
                    break;
                case 4:
                    pictureBox1.Image = global::Chat_Client.Properties.Resources._5;
                    break;
                case 5:
                    pictureBox1.Image = global::Chat_Client.Properties.Resources._6;
                    break;
                case 6:
                    pictureBox1.Image = global::Chat_Client.Properties.Resources._1;
                     click = 0;
                    break;


            }
        }
//---------------------------------------------------------------------------------------------------------------
  public static Image ScaleImage(Image img)
        {
            if (img.Height == 2)
            {
                return img;
            }
            else
            {
                return new Bitmap(img, new Size((int)((img.Height / 2.0) * img.Width), 2));
            }
        }
//----------------------------------------------------------------------------------------------------------------
private void SetIcons()
        {
            chatTextBox.ReadOnly = false;
            Bitmap bitmap = new Bitmap(pictureBox1.Image, new Size(20,20));
            
            Clipboard.SetImage(bitmap);
            DataFormats.Format format = DataFormats.GetFormat(DataFormats.Bitmap);

            chatTextBox.Paste(format);
            Clipboard.Clear();

        }
//----------------------------------------------------------------------------------------------------------
        private void chatTextBox_TextChanged_1(object sender, EventArgs e)
        {
            ScaleImage(pictureBox1.Image);
            SetIcons();


        }


        //------------------------------------------------------------------------------------------------------
    }
}
