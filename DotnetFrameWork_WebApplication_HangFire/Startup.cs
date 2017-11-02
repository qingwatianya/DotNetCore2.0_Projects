using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Hangfire;
using Hangfire.MySql.Core;
using System.Configuration;
using DotNetFrameWork_Library;

[assembly: OwinStartup(typeof(DotnetFrameWork_WebApplication.Startup))]

namespace DotnetFrameWork_WebApplication
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //// 有关如何配置应用程序的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkID=316888
            //string tmpConnection = ConfigurationManager.ConnectionStrings["mysqlconnstr_hangfire"].ConnectionString;
            //GlobalConfiguration.Configuration.UseStorage(new MySqlStorage(tmpConnection));

            //RecurringJob.AddOrUpdate(() => Class1.FuckStatic(), Cron.Minutely()); //每两分钟执行一次 其他类中的静态方法

            //app.UseHangfireServer();
            app.UseHangfireDashboard();


           

        }
    }
}
