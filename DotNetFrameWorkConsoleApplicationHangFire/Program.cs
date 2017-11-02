using Dapper;
using DotNetFrameWork_Library;
using Hangfire;
using Hangfire.MySql;
using Hangfire.MySql.Core;
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
        static void Main(string[] args)
        {
            Console.WriteLine("服务开始了，讲道理 茫茫人海相逢即是缘分 加个微信还是可以的：15249207822 可输入Exit命令结束服务....");

            //1、配置HangFire数据库连接：首次连接数据会自动创建12张相关系统表
            //string tmpConnection = "server=xxx;uid=xxx;pwd=xxx;database=xxx;Allow User Variables=True";
            string tmpConnection = ConfigurationManager.ConnectionStrings["mysqlconnstr_mvctest"].ConnectionString;
            GlobalConfiguration.Configuration.UseColouredConsoleLogProvider().UseStorage(new MySqlStorage(tmpConnection));

            //2、创建任务，自动将任务信息存储到数据系统表
            //BackgroundJob.Enqueue<Class1>(X => X.Fuck("GG"));//执行一次其他类中的非静态方法
            //RecurringJob.AddOrUpdate(() => Console.WriteLine("曾经沧海难为水，除却浓妆皆是鬼！"), Cron.Minutely()); //每分钟执行一次控制台输出
            //RecurringJob.AddOrUpdate(() => Class1.FuckStatic(), Cron.Minutely()); //每两分钟执行一次 其他类中的静态方法
            
            //var client = new BackgroundJobClient();
            //client.Enqueue(()=>Class1.FuckStatic());
            //client.Schedule(() => Class1.FuckStatic(), DateTimeOffset.FromUnixTimeSeconds(5));
            
            //3、开启HangFire作业服务
            using (var _server = new BackgroundJobServer())
            {
                RecurringJob.AddOrUpdate(() => DoSomething2(), Cron.Minutely()); //每天执行一次 其他类中的静态方法
                //4、控制台等待等待用户输入命令结束程序，如果控制台程序结束 HangFire服务跟着宿主一起停止
                while (true)
                {
                    string tmpCmd = Console.ReadLine();
                    if (tmpCmd.ToLower().Equals("exit"))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("可输入Exit结束程序！");
                    }
                }
            }
        }

        public static void DoSomething2()
        {
            Console.WriteLine("Fire in the hole!");
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@"D:\log_Stop.txt", true))
            {
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + "Stop.");

            }
        }

    }




}
