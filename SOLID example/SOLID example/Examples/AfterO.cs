using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_example.S
{
    public class AfterO
    {
        private readonly ISendMessage _messageSender;
        private readonly IEstablishConnection _connectionProvider;

        public AfterO(ISendMessage messageSender, IEstablishConnection connectionProvider)
        {
            _messageSender = messageSender;
            _connectionProvider = connectionProvider;
        }

        public void Send(Message message)
        {
            _messageSender.SendMessage(message);
        }

        public void SetMessageTarget(TargetSettings targetSettings)
        {
            _connectionProvider.SetMessageTarget(targetSettings);
        }
    }

    public interface ISendMessage {
        void SendMessage(Message message);
    }
    public interface IEstablishConnection {
        void SetMessageTarget(TargetSettings targetSettings);
    }

}
