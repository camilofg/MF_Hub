using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using BusinessLogic_MF;
using Mf_Hub.Controllers;
using Mf_Hub.Resolver;
using Services_MF;
using Unity;
using Unity.Lifetime;

namespace Mf_Hub
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var container = new UnityContainer();
            container.RegisterType<IUserService, UserService>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserLogic, UserLogic>(new HierarchicalLifetimeManager());
            container.RegisterType<IItemService, ItemService>(new HierarchicalLifetimeManager());
            container.RegisterType<IPriorityService, PriorityService>(new HierarchicalLifetimeManager());
            container.RegisterType<IStatusService, StatusService>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);
            // Web API routes
            config.MapHttpAttributeRoutes();
            config.MessageHandlers.Add(new TokenValidationHandler());

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
