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
            

            builder.RegisterType<OrdersBLL>().As<IDataservices<Orders>>();
            builder.RegisterType<UserInfosBLL>().As<IDataservices<UserInfos>>();
            builder.RegisterType<RoomsBLL>().As<IDataservices<Rooms>>();
            builder.RegisterType<RolesBLL>().As<IDataservices<Roles>>();
            builder.RegisterType<MoneyBLL>().As<IDataservices<Money>>();
            builder.RegisterType<AdminBLL>().As<IDataservices<Admin>>();
            builder.RegisterType<RoomTypeBLL>().As<IDataservices<RoomType>>();

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}