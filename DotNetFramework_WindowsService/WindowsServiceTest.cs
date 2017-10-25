using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFramework_WindowsService
{
    public partial class WindowsServiceTest : ServiceBase
    {
        public WindowsServiceTest()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Console.WriteLine("开始");
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter("C:\\log.txt", true))
            {
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + "Start.");
            }
        }

        protected override void OnStop()
        {
            Console.WriteLine("截止");
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter("C:\\log.txt", true))
            {
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + "Stop.");
            }
        }
    }
}
