using System;
namespace Mediator
{
    public class UserImpl : User
    {
        public UserImpl(string name, IChatMediator mediator) : base(name, mediator) { }

        public override void ReceiveMessage(string message)
        {
            Console.WriteLine(Name + " has received a message"); 
            Console.WriteLine(Name + "received: " + message);
        }

        public override void SendMessage(string message)
        {
            Console.WriteLine(Name + " sent: " + message);
            Mediator.SendMessage(message, this);
        }

        public override void SendPrivateMessage(string message, User sender, User recipient)
        {
            Console.WriteLine(Name + " sent: " + message);
            Mediator.SendPrivateMessage(message, this, recipient);
        }


    }
}

