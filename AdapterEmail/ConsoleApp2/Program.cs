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
            adapterGoogleMailServer.ConnectAndSendMail("example@gmail.com", "Abc123def", "Max Mustermann");
            Console.WriteLine("Email sent!");
        }
    }
}
