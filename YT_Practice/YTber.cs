using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT_Practice
{
    public class YTber
    {
        public List<Channel> channels = new List<Channel>();

        public YTber()
        {
            channels.Add(new Channel("ChannelA"));
            channels.Add(new Channel("ChannelB"));
            channels.Add(new Channel("ChannelC"));
        }

        public void publish(VideoModel model, Channel channel)
        {
            channel.Notify(model);
        }
    }
}
