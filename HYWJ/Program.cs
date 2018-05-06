using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace HYWJ
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            string MName = Process.GetCurrentProcess().MainModule.ModuleName;
            string PName = Path.GetFileNameWithoutExtension(MName);
            Process[] myProcess = Process.GetProcessesByName(PName);
            if (myProcess.Length > 1)
            {
                MessageBox.Show("海益ERP系统已经在运行不能重复运行！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Logon());
            }
           
        }
    }
}
