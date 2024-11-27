using PubSub;
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
    public partial class UserForm : Form
    {
        public List<Channel> channels;
        public UserForm(List<Channel> channels)
        {
            InitializeComponent();
            this.channels = channels;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = channels;
            comboBox1.DisplayMember = "ChannelName";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //HW: 完成取消訂閱的功能
            //下次上課先講 += 複寫
            YTber yTber = new YTber();
            Label label = new Label();
            Channel channel = comboBox1.SelectedItem as Channel;
            User user = new User(textBox1.Text);
            FlowLayoutPanel panel = new FlowLayoutPanel();
            Button button = new Button();
            button.Text = "取消訂閱";
            button.Click += UnSubscribe_Click;
            button.Tag = channel.subscribe(user.ReceiveNotify);



            label.Text = textBox1.Text + "已訂閱" + channel.ChannelName;
            MessageModel message = new MessageModel(SenderType.user, label.Text);
            MessageNotify.Notify(message);
            panel.Controls.Add(label);
            panel.Controls.Add(button);
            flowLayoutPanel1.Controls.Add(panel);

        }

        private void UnSubscribe_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            var subscription = (Subscription<VideoModel>)btn.Tag;
            subscription.Unsubscribe();
            FlowLayoutPanel currentPanel = btn.Parent as FlowLayoutPanel;
            flowLayoutPanel1.Controls.Remove(currentPanel);
        }
    }
}
