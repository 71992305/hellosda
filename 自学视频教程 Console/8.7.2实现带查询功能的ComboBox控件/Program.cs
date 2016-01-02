using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _8._7._2实现带查询功能的ComboBox控件
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Main());
        }
    }
}
