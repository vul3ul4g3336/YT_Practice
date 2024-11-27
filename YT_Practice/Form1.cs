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
    public partial class Form1 : Form
    {
        YTber yTber = new YTber();

        public Form1()
        {
            InitializeComponent();
            MessageNotify.Register(DisplayMessage);
        }

        // call back function => 當程式執行到後面，條件成立的時候 才會回過頭來呼叫
        private void button1_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(yTber.channels);
            userForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YT_Form yT_Form = new YT_Form(yTber);
            yT_Form.Show();
        }
        private void DisplayMessage(MessageModel message)
        {
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            Label label = new Label();
            label.Text = message.message;
            flowLayoutPanel.Controls.Add(label);

            switch (message.type)
            {
                case SenderType.user:
                    flowLayoutPanel1.Controls.Add(flowLayoutPanel);
                    break;
                case SenderType.YT:
                    flowLayoutPanel2.Controls.Add(flowLayoutPanel);
                    break;
            }

        }
    }
}
