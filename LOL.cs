using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace WinLoL
{
    class LOL
    {

        private WebSocketServer wssv;
        public bool Run()
        {
            try
            {
                wssv = new WebSocketServer(5050);
                wssv.AddWebSocketService<Lei>("/Love");
                wssv.Start();
            } catch (Exception ex)
            {
                return false;
            }

            return true;
        }


        public void Stop()
        {
            wssv.Stop();
        }

        public bool IsRunDav()
        {
            //var Count = System.Diagnostics.Process.GetProcessesByName("webDav_go").ToList().Count;
            //if (Count > 0)
            //{
            //    return true;
            //}
            return false;
        }

        public bool KillDav()
        {
            //try
            //{
            //    var DavList = System.Diagnostics.Process.GetProcessesByName("webDav_go");

            //    for (int i = 0; i < DavList.Length; i++)
            //    {
            //        DavList[i].Kill();//结束进程
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    return false;
            //}
            return true;
        }
        // 发送数据
        public void SendMessage(string Message)
        {
            try
            {
                wssv.WebSocketServices.Broadcast(Message);

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

    }
}
