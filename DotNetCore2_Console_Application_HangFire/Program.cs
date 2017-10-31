using Dapper;
using Hangfire;
using Hangfire.MySql.Core;
using System;
using System.IO;
using System.Text;

namespace DotNetCore2_Console_Application_HangFire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("服务开始了！");
            string tmpConnection = "server=rds5n95035s53i40c6m5o.mysql.rds.aliyuncs.com;uid=qingwatianya;pwd=qingwatianya101674;database=mvctest;Allow User Variables=True";
            GlobalConfiguration.Configuration
               .UseColouredConsoleLogProvider()
               .UseStorage(new MySqlStorage(tmpConnection));

            //支持基于队列的任务处理：任务执行不是同步的，而是放到一个持久化队列中，以便马上把请求控制权返回给调用者。
            //   BackgroundJob.Enqueue(() => Console.WriteLine("Simple!"));
            //延迟任务执行：不是马上调用方法，而是设定一个未来时间点再来执行。            
            //  BackgroundJob.Schedule(() => Console.WriteLine("Reliable!"), TimeSpan.FromSeconds(5));
            //循环任务执行：一行代码添加重复执行的任务，其内置了常见的时间循环模式，也可基于CRON表达式来设定复杂的模式。
            // RecurringJob.AddOrUpdate(() => Console.WriteLine("Transparent!"), Cron.Minutely);//注意最小单位是分钟

            using (var server = new BackgroundJobServer())
            {
                //    //BackgroundJob.Enqueue(() => Dosomething());
                //    var tmpJobID = BackgroundJob.Enqueue(() => Console.WriteLine("开始咯"));
                //    tmpJobID = BackgroundJob.ContinueWith(tmpJobID, () => Console.WriteLine(string.Format("the parent job(ID:{0}) completed,turn to the child job！", tmpJobID)));

                RecurringJob.AddOrUpdate<Program>((Program) => Dosomething3(), Cron.Minutely());
                //Console.WriteLine("Hangfire Server started. Press any key to exit...");
                Console.ReadKey();


            }

        }

        public static void Dosomething3()
        {
            Console.WriteLine("..............................................................");
            string tmpConnection = "server=rds5n95035s53i40c6m5o.mysql.rds.aliyuncs.com;uid=qingwatianya;pwd=qingwatianya101674;database=mvctest;Allow User Variables=True";
            
            MySql.Data.MySqlClient.MySqlConnection ff = new MySql.Data.MySqlClient.MySqlConnection(tmpConnection);
            string tmpSql = "UPDATE modules SET Module_URL='2222';";
            ff.Execute(tmpSql);

            //using (System.IO.StreamWriter sw = new System.IO.StreamWriter("D:\\log33332.txt", true))
            //{
            //    sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + "JobDone.--------------------------------------------------");
            //    sw.Flush();
            //    sw.Close();
            //    sw.Dispose();
            //}

            //FileStream fs = new FileStream(@"C:\example.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //StreamWriter sw = new StreamWriter(fs);
            //sw.BaseStream.Seek(0, SeekOrigin.End);
            //sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + "JobDone.--------------------------------------------------");
            //sw.Flush();
            //fs.Flush(true);
            //sw.Close();
            //fs.Close();
            //sw.Dispose();
            //fs.Dispose();
        }
    }
}
