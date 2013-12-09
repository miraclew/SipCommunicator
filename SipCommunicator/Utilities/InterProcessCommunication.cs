using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;

namespace SipCommunicator.Utilities
{
    public class InterProcessCommunication
    {
        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(
         int hWnd, //目标窗口的handle
         int Msg, // 消息
         int wParam, // 第一个消息参数
         ref COPYDATASTRUCT lParam // 第二个消息参数
         );

        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        private static extern int FindWindow(string lpClassName, string
         lpWindowName);

        public struct COPYDATASTRUCT
        {
            public IntPtr dwData;
            public int cbData;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpData;
        }
        public const int WM_COPYDATA = 0x004A;

        public static bool IsProcessRunning(string window)
        {
            int WINDOW_HANDLER = FindWindow(null, window);
            return WINDOW_HANDLER != 0;
        }

        public static void SendMessage(string window, string message)
        {
            int WINDOW_HANDLER = FindWindow(null, window);
            if (WINDOW_HANDLER != 0)
            {
                byte[] sarr = System.Text.Encoding.Default.GetBytes(message);
                int len = sarr.Length;
                COPYDATASTRUCT cds;
                cds.dwData = (IntPtr)100;
                cds.lpData = message;
                cds.cbData = len + 1;
                SendMessage(WINDOW_HANDLER, WM_COPYDATA, 0, ref cds);
            }
        }

        public static string ReciveMessage(ref Message m)
        {
            COPYDATASTRUCT mystr = new COPYDATASTRUCT();
            Type mytype = mystr.GetType();
            mystr = (COPYDATASTRUCT)m.GetLParam(mytype);
            string data = mystr.lpData;
            Debug.WriteLine("WM_COPYDATA message:" + data);
            return data;
        }
    }
}
