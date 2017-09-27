using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCore_Filter_Test_API.Filters
{
    public class SimpleExceptionFilterAttribute : Attribute, IExceptionFilter
    {
        private readonly ILogger<SimpleExceptionFilterAttribute> logger;

        public SimpleExceptionFilterAttribute(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<SimpleExceptionFilterAttribute>();
        }

        public void OnException(ExceptionContext context)
        {
            logger.LogError("Exception Execute! Message:" + context.Exception.Message);
            context.ExceptionHandled = true;
        }
    }
}
