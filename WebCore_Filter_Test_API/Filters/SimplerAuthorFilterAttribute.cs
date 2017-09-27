using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace WebCore_Filter_Test_API.Filters
{
    public class SimplerAuthorFilterAttribute : Attribute, IAuthorizationFilter
    {
        private readonly ILogger<SimplerAuthorFilterAttribute> logger;

        public SimplerAuthorFilterAttribute(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<SimplerAuthorFilterAttribute>();
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            logger.LogInformation("Authorization Executing!");
        }
    }
}
