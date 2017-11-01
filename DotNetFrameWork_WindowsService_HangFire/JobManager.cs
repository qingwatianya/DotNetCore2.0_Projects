
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
using Dapper;
using System.Configuration;
using DotNetFrameWork_Library;

namespace DotNetFrameWork_WindowsService_HangFire
{
    public partial class JobManager : ServiceBase
    {
        private BackgroundJobServer _server;
        public JobManager()
        {
            InitializeComponent();
            string tmpConnection = ConfigurationManager.ConnectionStrings["mysqlconnstr_mvctest"].ConnectionString;
            GlobalConfiguration.Configuration.UseStorage(new MySqlStorage(tmpConnection));        
        }

        protected override void OnStart(string[] args)
        {   
            _server = new BackgroundJobServer();
            BackgroundJob.Enqueue<Class1>(x => x.Fuck("xxx"));
            RecurringJob.AddOrUpdate(() => JobManager.FFF(), Cron.Minutely());
            RecurringJob.AddOrUpdate(() => Class1.FuckStatic(), Cron.Minutely());
            
        }

        protected override void OnStop()
        {
            _server.Dispose();
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@"D:\log_Stop.txt", true))
            {
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + "Stop.");

            }
        }

        public static void FFF()
        {            
            string tmpConnection = "server=rds5n95035s53i40c6m5o.mysql.rds.aliyuncs.com;uid=qingwatianya;pwd=qingwatianya101674;database=mvctest;Allow User Variables=True";
            MySql.Data.MySqlClient.MySqlConnection ff = new MySql.Data.MySqlClient.MySqlConnection(tmpConnection);
            string tmpSql = string.Format("UPDATE modules SET Module_URL='{0}';", DateTime.Now.ToString());
            ff.Execute(tmpSql);
        }

        public void DDD()
        {

        }
    }


}
