using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Hangfire;
using Hangfire.MySql.Core;
using Hangfire.Dashboard;

namespace DotNetCore2_Web_Aplication_HangFire
{
    public class Startup
    {
        readonly string tmpConnection = "server=rds5n95035s53i40c6m5o.mysql.rds.aliyuncs.com;uid=qingwatianya;pwd=qingwatianya101674;database=mvctest;Allow User Variables=True";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //app.useh(config =>
            //{
            //    config.UseSqlServerStorage(@"Data Source=192.168.210.138;Initial Catalog=Hangfire;User ID=sa;Password=hotelrj");
            //    config.UseServer();
            //});

            //        var options = new DashboardOptions
            //        {
            //            AppPath = HangfireSettings.Instance.AppWebSite,
            //            AuthorizationFilters = new[]
            //{
            //    new BasicAuthAuthorizationFilter ( new BasicAuthAuthorizationFilterOptions
            //    {
            //        SslRedirect = false,
            //        RequireSsl = false,
            //        LoginCaseSensitive = true,
            //        Users = new[]
            //        {
            //            new BasicAuthAuthorizationUser
            //            {
            //                Login = HangfireSettings.Instance.LoginUser,
            //                // Password as plain text
            //                PasswordClear = HangfireSettings.Instance.LoginPwd
            //            }

            //        }
            //    } )
            //}
            //        };

            GlobalConfiguration.Configuration
                 .UseColouredConsoleLogProvider()
                 .UseStorage(new MySqlStorage(tmpConnection));
            //BackgroundJob.Enqueue(() => Console.WriteLine("HangFire start"));//初始化生成HangFire数据库表  
            app.UseHangfireDashboard();
            app.UseHangfireServer();



            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });


        }


    }
}
