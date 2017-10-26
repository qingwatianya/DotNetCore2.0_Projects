using Hangfire;
using Hangfire.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameWork_WindowsService_HangFire
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new JobManager()
            };
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter("C:\\log11111111111112.txt", true))
            {
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + "Start.");
            }
            ServiceBase.Run(ServicesToRun);
        }
    }
}
