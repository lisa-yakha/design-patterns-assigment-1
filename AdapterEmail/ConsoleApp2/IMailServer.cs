using System;
namespace Adapter
{
    public interface IMailServer
    {
        void ConnectAndSendMail(string emailAdress, string content, string receiverName);
    }

}

