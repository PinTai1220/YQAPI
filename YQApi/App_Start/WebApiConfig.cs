using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using YQApi.Filters;

namespace YQApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // 注册Api 接口验证过滤器
            config.Filters.Add(new ApiSecurityFilter());

            // 注册异常日志写入过滤器
            config.Filters.Add(new ApiHandleErrorAttribute());

            // Web API 配置和服务

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
