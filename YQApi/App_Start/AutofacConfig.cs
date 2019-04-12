using Autofac;
using Autofac.Integration.WebApi;
using BLL;
using Commen;
using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace YQApi.App_Start
{
    public class AutofacConfig
    {
        public static void Run()
        {
            SetAutofacWebApi();
        }

        public static void SetAutofacWebApi()
        {
            HttpConfiguration config = GlobalConfiguration.Configuration;
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            

            builder.RegisterType<Orders>().As<IDataservices<Orders>>();
            builder.RegisterType<UserInfosBLL>().As<IDataservices<UserInfos>>();
            builder.RegisterType<RoomsBLL>().As<IDataservices<Money>>();
            builder.RegisterType<RolesBLL>().As<IDataservices<Rooms>>();


            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}