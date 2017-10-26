
using Hangfire;
using Hangfire.MySql;
using Hangfire.MySql.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameWork_WindowsService_HangFire
{
    public partial class JobManager : ServiceBase
    {
        public JobManager()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter("C:\\log11111111111113.txt", true))
            {
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + "Start.");
            }

            Console.WriteLine("Service Start!");
            string tmpConnection = "server=rds5n95035s53i40c6m5o.mysql.rds.aliyuncs.com;uid=qingwatianya;pwd=qingwatianya101674;database=mvctest;Allow User Variables=True";
            GlobalConfiguration.Configuration
               .UseStorage(new MySqlStorage(tmpConnection));

            BackgroundJob.Enqueue(() => ddd());
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter("C:\\log1111111111114.txt", true))
            {
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + "Start.");
            }
        }

        protected override void OnStop()
        {
            Console.WriteLine("Service Stop!");
        }

        public void ddd()
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter("C:\\log1111111111111.txt", true))
            {
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + "Start.");
            }
        }
    }

    
}
