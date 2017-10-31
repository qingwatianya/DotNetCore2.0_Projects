using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Hangfire.MySql;
using System.Configuration;
using Hangfire;

[assembly: OwinStartup(typeof(DotNetFrameWorkConsoleApplicationHangFire.Startup))]

namespace DotNetFrameWorkConsoleApplicationHangFire
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // 有关如何配置应用程序的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkID=316888
            
            string tmpConnection = ConfigurationManager.ConnectionStrings["mysqlconnstr_mvctest"].ConnectionString;
            GlobalConfiguration.Configuration
               .UseStorage(new MySqlStorage(tmpConnection));

            app.UseHangfireDashboard();
            app.UseHangfireServer();

            RecurringJob.AddOrUpdate(() => Console.WriteLine("香菇蓝瘦"), Cron.Minutely()); //正常执行 作业1分钟1次
        }
    }
}

