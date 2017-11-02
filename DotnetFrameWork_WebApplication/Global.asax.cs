using Hangfire;
using Hangfire.MySql.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace DotnetFrameWork_WebApplication
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            //string tmpConnection = ConfigurationManager.ConnectionStrings["mysqlconnstr_mvctest"].ConnectionString;
            //GlobalConfiguration.Configuration.UseStorage(new MySqlStorage(tmpConnection));
        }
    }
}