using System;
using System.Net.Sockets;
using System.Text;

namespace Chat
{
    class ClientObject
    {
        protected internal string Id { get; set; }
     
        protected internal NetworkStream stream { get; private set; }
        string userName;
       // string ip;
       //string color;
       
        TcpClient client;
        ServerObject server;
/// <summary>
/// 
/// </summary>
/// <param name="tcpClient"></param>
/// <param name="serverObject"></param>
/// 
//--------------------------------------------------------------------------------------------------------
        public ClientObject(TcpClient tcpClient, ServerObject serverObject)
        {
            Id = Guid.NewGuid().ToString();
            client = tcpClient;
            server = serverObject;
            serverObject.AddConnection(this);
        }
//-------------------------------------------------------------------------------------------------------
        public void Process()
        {
            try
            {
                stream = client.GetStream();
                string message = GetMessage();
                userName = message;
             

                message = userName + " вошел в чат. ";
               

                server.BroadcastMessage(message, this.Id);
                Console.WriteLine(message);

                while (true)
                {
                    try
                    {
                        message = GetMessage();
                        message = String.Format( message);
                        Console.WriteLine(message);
                        server.BroadcastMessage(message, this.Id);
                        
                    }
                    catch
                    {
                        message = String.Format("{0} : покинул чат =(.", userName);
                        Console.WriteLine(message);
                        server.BroadcastMessage(message, this.Id);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                server.RemoveConnection(this.Id);
                Close();
            }

        }
//----------------------------------------------------------------------------------------------------------------
        private string GetMessage()
        {
            byte[] data = new byte[128];
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (stream.DataAvailable);
            return builder.ToString();
        }
//----------------------------------------------------------------------------------------------------------------
       protected internal void Close()
        {
            if (stream != null) stream.Close();
            if (client != null) client.Close();
        }
//----------------------------------------------------------------------------------------------------------------
   


    }
}
