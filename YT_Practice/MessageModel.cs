using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT_Practice
{
    public class MessageModel
    {
        public SenderType type;
        public String message = null;
        public MessageModel(SenderType type, string message)
        {
            this.type = type;
            this.message = message;
        }
    }
}
