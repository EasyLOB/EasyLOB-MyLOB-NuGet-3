using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using AutoMapper;
using EasyLOB.Environment;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;

namespace EasyLOB
{
    public static partial class AppDIAutofacHelper
    {
        #region Methods

        public static void Setup(ContainerBuilder containerBuilder)
        {
            SetupActivity(containerBuilder);
            SetupAuditTrail(containerBuilder);
            SetupEasyLOB(containerBuilder);
            SetupExtensions(containerBuilder);
            SetupIdentity(containerBuilder);
            SetupLog(containerBuilder);

            SetupApplication(containerBuilder); // !!!

            //containerBuilder.RegisterType<EnvironmentManagerDesktop>().As<IEnvironmentManager>();
            containerBuilder.RegisterType<EnvironmentManagerWeb>().As<IEnvironmentManager>();

            containerBuilder.RegisterModule(new AutofacWebTypesModule());
            // MVC
            containerBuilder.RegisterControllers(Assembly.GetExecutingAssembly());
            // Web API
            containerBuilder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            IContainer container = containerBuilder.Build();

            IMapper mapper = AppHelper.SetupMappers();
            AppHelper.SetupProfiles();

            DIHelper.Setup(new DIManagerAutofac(container), mapper);

            // MVC
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            // Web API
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        #endregion Methods
    }
}