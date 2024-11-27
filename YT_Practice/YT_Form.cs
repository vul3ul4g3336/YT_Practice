using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YT_Practice
{
    public partial class YT_Form : Form
    {
        public YTber YTber;
        public YT_Form(YTber ytber)
        {
            InitializeComponent();
            YTber = ytber;
        }
        private void YT_Form_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = YTber.channels;
            comboBox1.DisplayMember = "ChannelName";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Channel channel = comboBox1.SelectedItem as Channel;
            VideoModel model = new VideoModel(textBox1.Text, textBox2.Text, channel.ChannelName);
            Label label = new Label();
            label.Text = channel.ChannelName + "已發布:" + textBox1.Text + ":" + textBox2.Text;
            MessageModel message = new MessageModel(SenderType.YT, label.Text);
            YTber.publish(model, channel);
            MessageNotify.Notify(message);



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
