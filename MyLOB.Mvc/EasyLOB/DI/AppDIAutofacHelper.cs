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

            SetupApplication(); // !!!

            //ContainerBuilder.RegisterType<EnvironmentManagerDesktop>().As<IEnvironmentManager>();
            ContainerBuilder.RegisterType<EnvironmentManagerWeb>().As<IEnvironmentManager>();

            ContainerBuilder.RegisterModule(new AutofacWebTypesModule());
            // MVC
            ContainerBuilder.RegisterControllers(Assembly.GetExecutingAssembly());
            // Web API
            ContainerBuilder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            _container = _containerBuilder.Build();

            IMapper mapper = AppHelper.SetupMappers();
            AppHelper.SetupProfiles();

            DIHelper.Setup(new DIManagerAutofac(Container),
                Container.Resolve<IEnvironmentManager>(),
                Container.Resolve<ILogManager>(),
                Container.Resolve<IMailManager>(),
                mapper);

            // MVC
            DependencyResolver.SetResolver(new AutofacDependencyResolver(Container));
            // Web API
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(Container);
        }

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }

        #endregion Methods
    }
}