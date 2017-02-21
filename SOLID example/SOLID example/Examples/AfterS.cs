using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_example.S
{
    public class GoodExample
    {
        public void Send(Message message)
        {
            MessageSender messageSender = new MessageSender(); 
            messageSender.SendMessage(message);
        }

        public void SetMessageTarget(TargetSettings targetSettings)
        {
            ConnectionProvider connectionProvider = new ConnectionProvider();
            connectionProvider.SetMessageTarget(targetSettings);
        }
    }


    public class Message { }
    public class TargetSettings { }
    public class ConnectionProvider {
        public void SetMessageTarget(TargetSettings targetSettings)
        {
            //logic for setting messages target
            if (cable)
            {
                
            }
        }
    }
    public class MessageSender {
        public void SendMessage(Message message)
        {
            //logic for sending messages
        }
    }
}
