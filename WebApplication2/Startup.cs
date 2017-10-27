using System;
using System.Threading.Tasks;
using Owin;
using Hangfire;
using Hangfire.MySql;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(WebApplication2.Startup))]

namespace WebApplication2
{
    public class Startup
    {
        //public void Configuration(IAppBuilder app)
        //{
        //    // 有关如何配置应用程序的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkID=316888

        //    //MySqlStorageOptions dd = new MySqlStorageOptions();
        string tmpConnection = "server=rds5n95035s53i40c6m5o.mysql.rds.aliyuncs.com;uid=qingwatianya;pwd=qingwatianya101674;database=mvctest;Allow User Variables=True";
        //    //GlobalConfiguration.Configuration.UseStorage(new MySqlStorage(tmpConnection, dd));
        //    //app.UseHangfireDashboard();


        //}

        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configuration.UseStorage(new MySqlStorage(tmpConnection));

            //app.UseHangfireDashboard();

            app.UseHangfireDashboard("/hangfire", new DashboardOptions
            {
                Authorization = new[] { new MyAuthorizationFilter() }
            });

            app.UseHangfireServer();
        }
    }
}
