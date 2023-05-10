using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jakob_S
{
    internal interface IMessage
    {
        public interface IMessageHandler
        {
            void SendMessage(Message m);
            void SendMessageToAll(string[] to, Message m);
        }
    }
}
