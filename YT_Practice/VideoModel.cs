using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT_Practice
{
    public class VideoModel
    {
        public string title = null;
        public string video = null;
        public string YTerName = null;
        public VideoModel(string title, string video, string yTerName)
        {
            this.title = title;
            this.video = video;
            this.YTerName = yTerName;
        }
    }
}
