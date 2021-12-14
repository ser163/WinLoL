using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace WinLoL {
    public class MWZN64ReaderAPI {
        /// <summary>打开读卡器
        /// </summary>
        /// <param name="port">读卡器占用端口号</param>
        /// <param name="baud">数据传输波特率</param>
        /// <returns>成功则返回串口标识符>0，失败返回负值</returns>
        //[DllImport("dcrf32.dll")]
        //public static extern int dc_init(Int16 port, long baud);
        [DllImport("hc_icrf64.dll", EntryPoint = "hc_init")]
        public static extern IntPtr _init(short port, uint baud);

        /// <summary>关闭读卡器
        /// </summary>
        /// <param name="icDev"></param>
        /// <returns></returns>
        //[DllImport("dcrf32.dll")]
        //public static extern short dc_exit(int icdev);
        [DllImport("hc_icrf64.dll", EntryPoint = "hc_exit")]
        public static extern short _exit(IntPtr icdev);

        /// <summary>寻卡。查询是否有IC卡放在读卡器上。
        /// </summary>
        /// <param name="icDev">读卡器设备号</param>
        /// <param name="mode">寻卡模式</param>
        /// <param name="secnr">返回卡序列号</param>
        /// <returns>成功则返回 0</returns>
        //[DllImport("dcrf32.dll")]
        //public static extern short dc_card(int icdev, char _Mode, ref ulong Snr);
        [DllImport("hc_icrf64.dll", EntryPoint = "rf_card")]
        public static extern short _card(IntPtr icdev, byte _Mode, ref ulong Snr);

        /// <summary>向读卡器装载密码
        /// </summary>
        /// <param name="icDev">读卡器设备号</param>
        /// <param name="mode">密码验证模式</param>
        /// <param name="secnr">扇区号</param>
        /// <param name="key">密码</param>
        /// <returns>成功则返回 0</returns>
        //[DllImport("dcrf32.dll")]
        //public static extern short dc_load_key_hex(int icdev, int mode, int secnr, string nkey);
        [DllImport("hc_icrf64.dll", EntryPoint = "rf_load_key_hex")]
        public static extern short _load_key_hex(IntPtr icdev, byte mode, byte secnr, string nkey);
        /// <summary>
        /// 以字符串验证密码
        /// </summary>
        /// <param name="icdev">通讯设备句柄</param>
        /// <param name="mode">
        /// 密码类型：	
        ///	    0x00	验证A密码
        ///	    0x01	验证B密码
        /// </param>
        /// <param name="sectorNo">要验证的扇区号</param>
        /// <param name="key">以'\0'为结尾的16进制字符串，密码长度应为12。</param>
        /// <returns> >=0	正确;	&lt;0	错误</returns>
        [DllImport("hc_icrf64.dll", EntryPoint = "rf_authentication_key_hex")]
        public static extern short _authenticationHex(IntPtr icdev, byte mode, byte sectorNo, string strKey);

        /// <summary>读取卡中数据
        /// </summary>
        /// <param name="icDev">读卡器设备号</param>
        /// <param name="adr">地址</param>
        /// <param name="data">获取的数据</param>
        /// <returns>成功则返回 0</returns>
        //public static extern short dc_read_hex(int icdev, int adr, [MarshalAs(UnmanagedType.LPStr)] StringBuilder sdata);
        [DllImport("hc_icrf64.dll", EntryPoint = "rf_read_hex")]
        public static extern short _read_hex(IntPtr icdev, byte adr, [MarshalAs(UnmanagedType.LPStr)] StringBuilder sdata);

        /// <summary> 请求卡片
        /// </summary>
        /// <param name="icDev">读卡器设备号</param>
        /// <param name="_Mode">寻卡模式</param>
        /// <param name="TagType">卡片类型</param>
        /// <returns>0 成功; <0 失败</returns>
        [DllImport("hc_icrf64.dll", EntryPoint = "rf_request")]
        public static extern short _request(IntPtr icdev, byte _Mode, out short TagType);

        /// <summary> 防冲突
        /// </summary>
        /// <param name="icDev">读卡器设备号</param>
        /// <param name="_Bcnt">默认为 0</param>
        /// <param name="_Snr">返回卡片序列号</param>
        /// <returns>0 成功; <0 失败</returns>
        [DllImport("hc_icrf64.dll", EntryPoint = "rf_anticoll")]
        public static extern short _anticoll(IntPtr icdev, byte _Bcnt, out uint _Snr);

        /// <summary> 将卡片置于 halt 状态
        /// 将选中的卡片设为“Halt”停止状态，只有当该卡再次复位或用 ALL 模
        //  式调用 request 函数时，读写器才能够再次操作它
        /// </summary>
        /// <param name="icDev">读卡器设备号</param>
        /// <param name="_Bcnt">默认为 0</param>
        /// <param name="_Snr">返回卡片序列号</param>
        /// <returns>0 成功; <0 失败</returns>
        [DllImport("hc_icrf64.dll", EntryPoint = "rf_halt")]
        public static extern short _halt(IntPtr icdev);
    }
}
