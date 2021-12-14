
namespace WinLoL
{
    partial class mainWin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWin));
            this.MyNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cxMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startServer = new System.Windows.Forms.ToolStripMenuItem();
            this.stopServer = new System.Windows.Forms.ToolStripMenuItem();
            this.reSever = new System.Windows.Forms.ToolStripMenuItem();
            this.toolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.pbStatusBox = new System.Windows.Forms.PictureBox();
            this.butStop = new System.Windows.Forms.Button();
            this.butReStart = new System.Windows.Forms.Button();
            this.butStart = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.CheckCardTime = new System.Windows.Forms.Timer(this.components);
            this.bottomStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.cardNo = new System.Windows.Forms.TextBox();
            this.cardInfoLabel = new System.Windows.Forms.Label();
            this.cxMenuStrip.SuspendLayout();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusBox)).BeginInit();
            this.bottomStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyNotifyIcon
            // 
            this.MyNotifyIcon.ContextMenuStrip = this.cxMenuStrip;
            this.MyNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MyNotifyIcon.Icon")));
            this.MyNotifyIcon.Text = "Hodor";
            this.MyNotifyIcon.Visible = true;
            this.MyNotifyIcon.DoubleClick += new System.EventHandler(this.MyNotifyIcon_DoubleClick);
            // 
            // cxMenuStrip
            // 
            this.cxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startServer,
            this.stopServer,
            this.reSever,
            this.toolExit});
            this.cxMenuStrip.Name = "cxMenuStrip";
            this.cxMenuStrip.Size = new System.Drawing.Size(137, 92);
            // 
            // startServer
            // 
            this.startServer.Image = global::WinLoL.Properties.Resources.start;
            this.startServer.Name = "startServer";
            this.startServer.Size = new System.Drawing.Size(136, 22);
            this.startServer.Text = "启动服务器";
            this.startServer.Click += new System.EventHandler(this.startServer_Click);
            // 
            // stopServer
            // 
            this.stopServer.Image = global::WinLoL.Properties.Resources.stop;
            this.stopServer.Name = "stopServer";
            this.stopServer.Size = new System.Drawing.Size(136, 22);
            this.stopServer.Text = "停止服务器";
            this.stopServer.Click += new System.EventHandler(this.stopServer_Click);
            // 
            // reSever
            // 
            this.reSever.Image = global::WinLoL.Properties.Resources.restart;
            this.reSever.Name = "reSever";
            this.reSever.Size = new System.Drawing.Size(136, 22);
            this.reSever.Text = "重启服务";
            // 
            // toolExit
            // 
            this.toolExit.Image = global::WinLoL.Properties.Resources.exit;
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(136, 22);
            this.toolExit.Text = "退出";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.pbStatusBox);
            this.gb1.Controls.Add(this.butStop);
            this.gb1.Controls.Add(this.butReStart);
            this.gb1.Controls.Add(this.butStart);
            this.gb1.Location = new System.Drawing.Point(8, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(247, 165);
            this.gb1.TabIndex = 1;
            this.gb1.TabStop = false;
            this.gb1.Text = "服务信息";
            this.gb1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pbStatusBox
            // 
            this.pbStatusBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbStatusBox.Image = global::WinLoL.Properties.Resources.stop_64;
            this.pbStatusBox.Location = new System.Drawing.Point(129, 27);
            this.pbStatusBox.Name = "pbStatusBox";
            this.pbStatusBox.Size = new System.Drawing.Size(105, 105);
            this.pbStatusBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStatusBox.TabIndex = 3;
            this.pbStatusBox.TabStop = false;
            // 
            // butStop
            // 
            this.butStop.Location = new System.Drawing.Point(15, 109);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(92, 23);
            this.butStop.TabIndex = 2;
            this.butStop.Text = "停止服务";
            this.butStop.UseVisualStyleBackColor = true;
            this.butStop.Click += new System.EventHandler(this.butStop_Click);
            // 
            // butReStart
            // 
            this.butReStart.Location = new System.Drawing.Point(15, 68);
            this.butReStart.Name = "butReStart";
            this.butReStart.Size = new System.Drawing.Size(92, 23);
            this.butReStart.TabIndex = 1;
            this.butReStart.Text = "重启服务";
            this.butReStart.UseVisualStyleBackColor = true;
            this.butReStart.Click += new System.EventHandler(this.butReStart_Click);
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(15, 27);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(92, 23);
            this.butStart.TabIndex = 0;
            this.butStart.Text = "启动服务";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(8, 545);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(64, 17);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ser163.cn";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // CheckCardTime
            // 
            this.CheckCardTime.Interval = 1000;
            this.CheckCardTime.Tick += new System.EventHandler(this.CheckCardTime_Tick);
            // 
            // bottomStatus
            // 
            this.bottomStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
            this.bottomStatus.Location = new System.Drawing.Point(0, 254);
            this.bottomStatus.Name = "bottomStatus";
            this.bottomStatus.Size = new System.Drawing.Size(264, 22);
            this.bottomStatus.TabIndex = 4;
            this.bottomStatus.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatus.Text = "WinLoL ...";
            // 
            // cardNo
            // 
            this.cardNo.Location = new System.Drawing.Point(8, 214);
            this.cardNo.Name = "cardNo";
            this.cardNo.Size = new System.Drawing.Size(247, 23);
            this.cardNo.TabIndex = 5;
            // 
            // cardInfoLabel
            // 
            this.cardInfoLabel.AutoSize = true;
            this.cardInfoLabel.Location = new System.Drawing.Point(8, 191);
            this.cardInfoLabel.Name = "cardInfoLabel";
            this.cardInfoLabel.Size = new System.Drawing.Size(35, 17);
            this.cardInfoLabel.TabIndex = 6;
            this.cardInfoLabel.Text = "卡号:";
            // 
            // mainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(264, 276);
            this.Controls.Add(this.cardInfoLabel);
            this.Controls.Add(this.cardNo);
            this.Controls.Add(this.bottomStatus);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.gb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinLoL";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainWin_FormClosing);
            this.Load += new System.EventHandler(this.mainWin_Load);
            this.SizeChanged += new System.EventHandler(this.mainWin_SizeChanged);
            this.cxMenuStrip.ResumeLayout(false);
            this.gb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusBox)).EndInit();
            this.bottomStatus.ResumeLayout(false);
            this.bottomStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon MyNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip cxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem startServer;
        private System.Windows.Forms.ToolStripMenuItem stopServer;
        private System.Windows.Forms.ToolStripMenuItem reSever;
        private System.Windows.Forms.ToolStripMenuItem toolExit;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.PictureBox pbStatusBox;
        private System.Windows.Forms.Button butStop;
        private System.Windows.Forms.Button butReStart;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Timer CheckCardTime;
        private System.Windows.Forms.StatusStrip bottomStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.TextBox cardNo;
        private System.Windows.Forms.Label cardInfoLabel;
    }
}

