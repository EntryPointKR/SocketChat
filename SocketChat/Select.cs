using System;
using System.Windows.Forms;

namespace SocketChat
{
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }

        private void ServerBtn_Click(object sender, EventArgs e)
        {
            Chat chatWindow = new Chat();
            chatWindow.Show();
            chatWindow.FormClosed += 
                (s, args) => this.Close();
            this.Hide();
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            Chat chatWindow = new Chat();
            chatWindow.Show();
            chatWindow.FormClosed += 
                (s, args) => this.Close();
            this.Hide();
        }
    }
}
