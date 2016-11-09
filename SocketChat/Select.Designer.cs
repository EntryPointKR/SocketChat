namespace SocketChat
{
    partial class Select
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ServerTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.ServerPortBox = new System.Windows.Forms.TextBox();
            this.ServerBtn = new System.Windows.Forms.Button();
            this.ClientTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.ClientPortBox = new System.Windows.Forms.TextBox();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.ServerTab.SuspendLayout();
            this.ClientTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ServerTab);
            this.tabControl1.Controls.Add(this.ClientTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(282, 149);
            this.tabControl1.TabIndex = 0;
            // 
            // ServerTab
            // 
            this.ServerTab.Controls.Add(this.label1);
            this.ServerTab.Controls.Add(this.ServerPortBox);
            this.ServerTab.Controls.Add(this.ServerBtn);
            this.ServerTab.Location = new System.Drawing.Point(4, 22);
            this.ServerTab.Name = "ServerTab";
            this.ServerTab.Padding = new System.Windows.Forms.Padding(3);
            this.ServerTab.Size = new System.Drawing.Size(274, 123);
            this.ServerTab.TabIndex = 0;
            this.ServerTab.Text = "서버";
            this.ServerTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "포트:";
            // 
            // ServerPortBox
            // 
            this.ServerPortBox.Location = new System.Drawing.Point(47, 13);
            this.ServerPortBox.Name = "ServerPortBox";
            this.ServerPortBox.Size = new System.Drawing.Size(221, 21);
            this.ServerPortBox.TabIndex = 1;
            this.ServerPortBox.Text = "1010";
            // 
            // ServerBtn
            // 
            this.ServerBtn.Location = new System.Drawing.Point(10, 47);
            this.ServerBtn.Name = "ServerBtn";
            this.ServerBtn.Size = new System.Drawing.Size(252, 64);
            this.ServerBtn.TabIndex = 0;
            this.ServerBtn.Text = "서버 오픈";
            this.ServerBtn.UseVisualStyleBackColor = true;
            this.ServerBtn.Click += new System.EventHandler(this.ServerBtn_Click);
            // 
            // ClientTab
            // 
            this.ClientTab.Controls.Add(this.label3);
            this.ClientTab.Controls.Add(this.label2);
            this.ClientTab.Controls.Add(this.ConnectBtn);
            this.ClientTab.Controls.Add(this.ClientPortBox);
            this.ClientTab.Controls.Add(this.IPBox);
            this.ClientTab.Location = new System.Drawing.Point(4, 22);
            this.ClientTab.Name = "ClientTab";
            this.ClientTab.Padding = new System.Windows.Forms.Padding(3);
            this.ClientTab.Size = new System.Drawing.Size(274, 123);
            this.ClientTab.TabIndex = 1;
            this.ClientTab.Text = "클라이언트";
            this.ClientTab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "포트:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "아이피:";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(10, 63);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(254, 51);
            this.ConnectBtn.TabIndex = 7;
            this.ConnectBtn.Text = "접속";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // ClientPortBox
            // 
            this.ClientPortBox.Location = new System.Drawing.Point(55, 36);
            this.ClientPortBox.Name = "ClientPortBox";
            this.ClientPortBox.Size = new System.Drawing.Size(209, 21);
            this.ClientPortBox.TabIndex = 5;
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(55, 9);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(209, 21);
            this.IPBox.TabIndex = 6;
            // 
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 145);
            this.Controls.Add(this.tabControl1);
            this.Name = "Select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select";
            this.tabControl1.ResumeLayout(false);
            this.ServerTab.ResumeLayout(false);
            this.ServerTab.PerformLayout();
            this.ClientTab.ResumeLayout(false);
            this.ClientTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ServerTab;
        private System.Windows.Forms.TabPage ClientTab;
        private System.Windows.Forms.TextBox ServerPortBox;
        private System.Windows.Forms.Button ServerBtn;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.TextBox ClientPortBox;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

