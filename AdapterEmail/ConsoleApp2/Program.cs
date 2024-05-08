using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            GoogleMailServer googleMailServer = new GoogleMailServer();
            AdapterGoogleMailServer adapterGoogleMailServer = new AdapterGoogleMailServer(googleMailServer);
            Console.WriteLine("Sending email");
            adapterGoogleMailServer.ConnectAndSendMail("darina.cherniavskaia@gmail.com", "Abc123def", "Darina Cherniavskaia");
            Console.WriteLine("Email sent!");
        }
    }
}
