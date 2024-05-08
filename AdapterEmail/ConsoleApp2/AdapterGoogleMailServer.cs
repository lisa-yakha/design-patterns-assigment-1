using System;

namespace Adapter
{
    public class AdapterGoogleMailServer : IMailServer
    {
        private GoogleMailServer server;

        public AdapterGoogleMailServer(GoogleMailServer server)
        {
            this.server = server;
        }
        public static string Encryption(string content)
        {
            string result = string.Empty;
            foreach (char i in content)
                result += (char)(i + 1);
            return result;
        }
        /*static string Decryption(string content)
           {
               string result = string.Empty;
               foreach (char i in content)
                   result += (char)(i - 1);
               return result;
           }*/
        
        public void ConnectAndSendMail(string emailAdress, string content, string receiverName)
        {
            server.BuildConnection();
            content = Encryption(content);
            server.SendEmail(emailAdress, content);
            //Console.WriteLine("Content received: " + Decryption(content));
        }
    }
}