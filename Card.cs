using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Runtime.InteropServices;



namespace WinLoL
{
    class Card
    {
        private const int TransBound = 115200;
        private static IntPtr devHandle = IntPtr.Zero;
        private const char CardMode = (char)0;


        public Card()
        {
            // port 取值为 0～19 时，表示串口 1～20；
            // 为 100 或大于 100，表示 USB
            // 口通讯，此时波特率参数无效
            // Baud 为通讯波特率 9600～115200
            short comPort = 100;
            try
            {
                devHandle = MWZN64ReaderAPI._init(comPort, TransBound);
            }
            catch (Exception)
            {
                throw new CardException("设备初始化失败!");
            }
        }

        public string GetCardNo()
        {
            int ret = 0;
            int retNo = 0;
            uint secnr = 0;
            short TagType = 0;
            byte _Bcnt = 0;

            if (devHandle.ToInt32() > 0)
            {
                try
                {
                    ret = MWZN64ReaderAPI._request(devHandle, (byte)CardMode, out TagType);
                    if (ret == 0)
                    {
                        retNo = MWZN64ReaderAPI._anticoll(devHandle, _Bcnt, out secnr);

                        if (retNo == 0)
                        {
                            return secnr.ToString();
                        }
                    }
                }
                catch (Exception)
                {
                    return "";
                }

            }

            return "";
        }

        public void Close()
        {
            MWZN64ReaderAPI._exit(devHandle);
        }

    }
}
