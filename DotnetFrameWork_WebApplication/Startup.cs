using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Hangfire;

[assembly: OwinStartup(typeof(DotnetFrameWork_WebApplication.Startup))]

namespace DotnetFrameWork_WebApplication
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // 有关如何配置应用程序的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkID=316888
            //app.UseHangfireDashboard();
        }
    }
}
