using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Diagnostics;
using System.IO;



namespace WinLoL
{
    public partial class mainWin : Form
    {
        private LOL Lol = new();
        private string SharePath = "";

        private Card card = new();

        public mainWin()
        {
            InitializeComponent();
        }


        private void mainWin_Load(object sender, EventArgs e)
        {
            if (Lol.IsRunDav())
            {
                RunStateChange();
            }
            else
            {
                StopStateChange();
            }

            reSever.Enabled = false;
      

            // 判断注册表
            Regedit Reg = new();
            Reg.CheckReg();
            // 添加防火墙规则
            var Path = Application.ExecutablePath;
            FireWalld.AddRuls(Path);
        }

        private void mainWin_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.MyNotifyIcon.Visible = true;
                this.Visible = false;
            }
        }

        private void MyNotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                this.Hide();
            }
            else
            {
                this.Show();
                this.Activate();
            }
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        // 运行状态改变
        private void RunStateChange()
        {
            butStart.Enabled = false;
            butStop.Enabled = true;
            butReStart.Enabled = true;

            startServer.Enabled = false;
            stopServer.Enabled = true;
            reSever.Enabled = true;

            // 切换启动图片
            pbStatusBox.Image = WinLoL.Properties.Resources.start_64;
        }



        private void GlobalStart()
        {

           if (Lol.Run())
            {
                CheckCardTime.Enabled = true;
                // 改变按钮状态
                RunStateChange();
            }


        }

        private void butStart_Click(object sender, EventArgs e)
        {
            GlobalStart();
        }
        // 停止状态改变
        private void StopStateChange()
        {
            butStart.Enabled = true;
            butStop.Enabled = false;
            butReStart.Enabled = false;

            startServer.Enabled = true;
            stopServer.Enabled = false;
            reSever.Enabled = false;
            pbStatusBox.Image = WinLoL.Properties.Resources.stop_64;
        }

        private void GlobalStop()
        {
            try
            {
                Lol.Stop();
                CheckCardTime.Enabled = false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            StopStateChange();
        }

        private void butStop_Click(object sender, EventArgs e)
        {
            GlobalStop();
        }



        private void butReStart_Click(object sender, EventArgs e)
        {
            GlobalReStart();
        }

        // 全局调用重启事件
        private void GlobalReStart()
        {
            Lol.Stop();
            CheckCardTime.Enabled = false;
            pbStatusBox.Image = WinLoL.Properties.Resources.stop_64;
            System.Threading.Thread.Sleep(1000);

            pbStatusBox.Image = WinLoL.Properties.Resources.start_64;
            Lol.Run();
            CheckCardTime.Enabled = true;
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel1.LinkVisited = true;
                using var process = new Process();
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.FileName = "https://ser163.cn/doc";
                process.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void cbDisk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gb2_Enter(object sender, EventArgs e)
        {

        }

        private void stopServer_Click(object sender, EventArgs e)
        {
            GlobalStop();
        }

        private void startServer_Click(object sender, EventArgs e)
        {
            GlobalStart();
        }

        private void cbIpList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mainWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Lol.IsRunDav())
            {
                DialogResult ret = MessageBox.Show("是否退出服务", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == ret)
                {
                    Lol.KillDav();
                }
            }
        }

        private void browseDir_Click(object sender, EventArgs e)
        {
            SelectFolder();
        }

        private void SelectFolder()
        {

        }

        private void dirPathBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbIP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // 开启定时任务.每过1秒钟检测一下
        private void CheckCardTime_Tick(object sender, EventArgs e)
        {
            var cardStr = card.GetCardNo();
            if (cardStr != "")
            {
                cardNo.Text = card.GetCardNo();
                Lol.SendMessage(cardStr);
            }
           
        }
    }
}
