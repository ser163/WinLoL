using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace WinLoL
{
    class Lei : WebSocketBehavior
    {
        // 接收到消息的时候
        protected override void OnMessage(MessageEventArgs e)
        {
            Sessions.Broadcast(e.Data);
        }
    }
}
