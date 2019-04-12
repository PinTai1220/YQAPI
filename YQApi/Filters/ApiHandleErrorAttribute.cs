using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Http.Filters;
using YQApi.Models;

namespace YQApi.Filters
{
    public class ApiHandleErrorAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            LoggerFactory.CreateLog().LogError("发生了错误信息", actionExecutedContext.Exception);
        }
    }
}