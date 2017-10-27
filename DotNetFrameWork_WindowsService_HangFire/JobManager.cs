
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
            string tmpConnection = "server=rds5n95035s53i40c6m5o.mysql.rds.aliyuncs.com;uid=qingwatianya;pwd=qingwatianya101674;database=mvctest;Allow User Variables=True";
            GlobalConfiguration.Configuration.UseStorage(new MySqlStorage(tmpConnection));
            try
            {
                using (var server = new BackgroundJobServer())
                {

                    BackgroundJob.Enqueue(() => FFF());

                    RecurringJob.AddOrUpdate(() => FFF(), Cron.Minutely());

                }
            }
            catch (Exception ex)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@"D:\log_Stop.txt", true))
                {
                    sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss: ") + ex.ToString());

                }
            }

        }

        protected override void OnStop()
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@"D:\log_Stop.txt", true))
            {
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + "Stop.");

            }
        }

        public void FFF()
        {
            //using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@"D:\34343.txt", true))
            //{
            //    sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + "ddd.");

            //}
            string tmpConnection = "server=rds5n95035s53i40c6m5o.mysql.rds.aliyuncs.com;uid=qingwatianya;pwd=qingwatianya101674;database=mvctest;Allow User Variables=True";
            MySql.Data.MySqlClient.MySqlConnection ff = new MySql.Data.MySqlClient.MySqlConnection(tmpConnection);
            string tmpSql = string.Format("UPDATE modules SET Module_URL='{0}';", DateTime.Now.ToString());
            ff.Execute(tmpSql);


        }

        public void SSS()
        {
            string tmpConnection = "server=rds5n95035s53i40c6m5o.mysql.rds.aliyuncs.com;uid=qingwatianya;pwd=qingwatianya101674;database=mvctest;Allow User Variables=True";
            MySql.Data.MySqlClient.MySqlConnection ff = new MySql.Data.MySqlClient.MySqlConnection(tmpConnection);
            string tmpSql = string.Format("UPDATE Module_Description SET Module_URL='111{0}';", DateTime.Now.ToString());
            ff.Execute(tmpSql);


        }
    }


}
