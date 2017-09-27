using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCore_Filter_Test_API.Filters
{
    public class MyActionFilterAttribute : Attribute, IActionFilter
    {
        //private readonly ILogger<SimpleActionFilterAttribute> logger;

        //public MyActionFilterAttribute(ILoggerFactory loggerFactory)
        //{
        //    logger = loggerFactory.CreateLogger<SimpleActionFilterAttribute>();
        //}


        public void OnActionExecuted(ActionExecutedContext context)
        {
            //logger.LogError("Fire in the hole!");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add("My-Header-02", "WebApiFrame-Header");
        }
    }
}
