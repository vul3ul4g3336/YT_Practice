using PubSub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT_Practice
{
    public class MessageNotify
    {
        static Subject<MessageModel> subject = new Subject<MessageModel>();
        public static void Register(Action<MessageModel> message)
        {
            subject.Subscribe(message);
        }
        public static void Notify(MessageModel message)
        {
            subject.Notify(message);
        }
    }
}
