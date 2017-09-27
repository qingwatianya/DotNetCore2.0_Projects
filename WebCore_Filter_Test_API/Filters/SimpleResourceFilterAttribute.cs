using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebCore_Filter_Test_API.Filters
{
    public class SimpleResourceFilterAttribute : Attribute, IResourceFilter
    {
        private readonly ILogger<SimpleResourceFilterAttribute> logger;

        public SimpleResourceFilterAttribute(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<SimpleResourceFilterAttribute>();
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            logger.LogInformation("ResourceFilter Executed!");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            logger.LogInformation("ResourceFilter Executing!");
        }
    }
}
