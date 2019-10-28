using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using EasyLOB.Environment;
using MyLOB.WebApi;
using System.Web.Http;
using System.Web.Mvc;

namespace EasyLOB
{
    public static partial class AppDIAutofacHelper
    {
        #region Properties

        private static ContainerBuilder _containerBuilder;

        public static ContainerBuilder ContainerBuilder
        {
            get { return _containerBuilder; }
        }

        private static IContainer _container;

        public static IContainer Container
        {
            get { return _container; }
        }

        #endregion Properties

        #region Methods

        public static void Setup(ContainerBuilder containerBuilder)
        {
            _containerBuilder = containerBuilder;

            SetupActivity();
            SetupAuditTrail();
            SetupEasyLOB();
            SetupExtensions();
            SetupIdentity();
            SetupLog();

            SetupMyLOB(); // !!!

            //ContainerBuilder.RegisterType<EnvironmentManagerDesktop>().As<IEnvironmentManager>().SingleInstance();
            ContainerBuilder.RegisterType<EnvironmentManagerWeb>().As<IEnvironmentManager>().SingleInstance();

            ContainerBuilder.RegisterControllers(typeof(WebApiApplication).Assembly);
            ContainerBuilder.RegisterApiControllers(typeof(WebApiApplication).Assembly);

            _container = _containerBuilder.Build();

            // MVC
            DependencyResolver.SetResolver(new AutofacDependencyResolver(Container));
            // Web API
            var config = GlobalConfiguration.Configuration;
            config.DependencyResolver = new AutofacWebApiDependencyResolver(Container);

            ManagerHelper.Setup(new DIManagerAutofac(Container),
                Container.Resolve<IEnvironmentManager>(),
                Container.Resolve<ILogManager>());
        }

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }

        #endregion Methods
    }
}