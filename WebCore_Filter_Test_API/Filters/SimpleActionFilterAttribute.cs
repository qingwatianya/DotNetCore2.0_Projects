using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCore_Filter_Test_API.Filters
{
    public class SimpleActionFilterAttribute : Attribute, IActionFilter
    {
        private readonly ILogger<SimpleActionFilterAttribute> logger;

        public SimpleActionFilterAttribute(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<SimpleActionFilterAttribute>();
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            logger.LogInformation("ActionFilter Executed!");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            logger.LogInformation("ActionFilter Executing!");
            context.HttpContext.Response.Headers.Add("My-Header", "WebApiFrame-Header");
        }
    }
}
