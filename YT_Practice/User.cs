using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT_Practice
{
    public class User
    {
        public string Name = null;
        public User(string name)
        {
            this.Name = name;
        }
        public void ReceiveNotify(VideoModel model)
        {

            MessageModel message = new MessageModel
                (SenderType.user, Name + "已收到" + model.YTerName + "發布的內容" + model.title + model.video);
            MessageNotify.Notify(message);
        }
    }
}
