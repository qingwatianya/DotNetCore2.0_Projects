using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameWork_Console_Appliaction
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceToRun = new ServiceBase[] {
                 new JobManager()
            };

            ServiceBase.Run(serviceToRun);
        }
    }
}
