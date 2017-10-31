using Dapper;
using DotNetFrameWork_Library;
using Hangfire;
using Hangfire.MySql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFrameWorkConsoleApplicationHangFire
{
    public class Program
    {
         //public static BackgroundJobServer _server;
        static void Main(string[] args)
        {
            Console.WriteLine("服务开始了！");
            string tmpConnection = ConfigurationManager.ConnectionStrings["mysqlconnstr_mvctest"].ConnectionString;
            GlobalConfiguration.Configuration               
               .UseStorage(new MySqlStorage(tmpConnection));

            
            RecurringJob.AddOrUpdate(() => Console.WriteLine("香菇蓝瘦"), Cron.Minutely()); //正常执行 作业1分钟1次            

            RecurringJob.AddOrUpdate(() => Class1.FuckStatic(), Cron.Minutely()); //失败

                RecurringJob.AddOrUpdate(() => Program.DoSomething2(), Cron.Minutely()); //失败

                BackgroundJob.Enqueue<Class1>(X => X.Fuck("GG"));           //失败        

            //using (var _server = new BackgroundJobServer())
            //{
            //    Console.ReadLine();
            //}

        }

        public static void DoSomething2()
        {
            Console.WriteLine("xxxx");
        }

    }

    


}
