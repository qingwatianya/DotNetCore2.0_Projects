using Hangfire;
using Hangfire.MySql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
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
           
            ServiceBase.Run(ServicesToRun);
            
        }
    }
}
