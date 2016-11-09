using System;
using System.Windows.Forms;

namespace SocketChat
{
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            string text = ChatBox.Text;
            if (!text.Equals(""))
            {
                if (ContentBox.Text.Equals(""))
                {
                    ContentBox.Text = "나: " + text;
                }
                else
                {
                    ContentBox.Text += "\n" + "나: " + text;
                }
                ChatBox.Text = "";
                ChatBox.Focus();
            }
            //else
            //{
            //    MessageBox.Show("내용을 입력해주세요.", "SocketChat", 
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void ChatBox_TextChanged(object sender, EventArgs e)
        {
            SendBtn.Enabled = !ChatBox.Text.Equals("");
        }
    }
}
