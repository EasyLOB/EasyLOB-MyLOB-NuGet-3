using Autofac;
using EasyLOB.Activity;
using EasyLOB.Activity.Application;
using EasyLOB.Activity.Persistence;
using EasyLOB.Security;

namespace EasyLOB
{
    public static partial class AppDIAutofacHelper
    {
        public static void SetupActivity()
        {
            ContainerBuilder.RegisterType<AuthorizationManagerMock>().As<IAuthorizationManager>(); // InstancePerDependency();
            //ContainerBuilder.RegisterType<AuthorizationManager>().As<IAuthorizationManager>(); // InstancePerDependency();

            ContainerBuilder.RegisterGeneric(typeof(ActivityGenericApplication<>)).As(typeof(IActivityGenericApplication<>)); // InstancePerDependency();
            ContainerBuilder.RegisterGeneric(typeof(ActivityGenericApplicationDTO<,>)).As(typeof(IActivityGenericApplicationDTO<,>)); // InstancePerDependency();

            // Entity Framework
            ContainerBuilder.RegisterType<ActivityUnitOfWorkEF>().As<IActivityUnitOfWork>(); // InstancePerDependency();
            ContainerBuilder.RegisterGeneric(typeof(ActivityGenericRepositoryEF<>)).As(typeof(IActivityGenericRepository<>)); // InstancePerDependency();

            // LINQ to DB
            //ContainerBuilder.RegisterType<ActivityUnitOfWorkLINQ2DB>().As<IActivityUnitOfWork>(); // InstancePerDependency();
            //ContainerBuilder.RegisterGeneric(typeof(ActivityGenericRepositoryLINQ2DB<>)).As(typeof(IActivityGenericRepository<>)); // InstancePerDependency();

            // NHibernate
            //ContainerBuilder.RegisterType<ActivityUnitOfWorkEF>().As<IActivityUnitOfWork>(); // InstancePerDependency();
            //ContainerBuilder.RegisterGeneric(typeof(ActivityGenericRepositoryEF<>)).As(typeof(IActivityGenericRepository<>)); // InstancePerDependency();
        }
    }
}