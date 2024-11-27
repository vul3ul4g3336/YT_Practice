using PubSub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT_Practice
{
    public class Channel
    {
        public string ChannelName { get; set; } = null;
        Subject<VideoModel> subject = new Subject<VideoModel>();
        public Channel(string Name)
        {
            ChannelName = Name;
        }
        public Subscription<VideoModel> subscribe(Action<VideoModel> action)
        {
            var subscription = subject.Subscribe(action);
            return subscription;
        }
        public void Notify(VideoModel model)
        {
            subject.Notify(model);
        }
    }
}
