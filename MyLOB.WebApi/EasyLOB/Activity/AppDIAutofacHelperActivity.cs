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
            //ContainerBuilder.RegisterType<AuthorizationManagerMock>().As<IAuthorizationManager>();
            //    .InstancePerRequest();
            ContainerBuilder.RegisterType<AuthorizationManager>().As<IAuthorizationManager>()
                .InstancePerRequest();

            ContainerBuilder.RegisterGeneric(typeof(ActivityGenericApplication<>)).As(typeof(IActivityGenericApplication<>))
                .InstancePerRequest();
            ContainerBuilder.RegisterGeneric(typeof(ActivityGenericApplicationDTO<,>)).As(typeof(IActivityGenericApplicationDTO<,>))
                .InstancePerRequest();

            // Entity Framework
            ContainerBuilder.RegisterType<ActivityUnitOfWorkEF>().As<IActivityUnitOfWork>()
                .InstancePerRequest();
            ContainerBuilder.RegisterGeneric(typeof(ActivityGenericRepositoryEF<>)).As(typeof(IActivityGenericRepository<>))
                .InstancePerRequest();

            // LINQ to DB
            //ContainerBuilder.RegisterType<ActivityUnitOfWorkLINQ2DB>().As<IActivityUnitOfWork>()
            //    .InstancePerRequest();
            //ContainerBuilder.RegisterGeneric(typeof(ActivityGenericRepositoryLINQ2DB<>)).As(typeof(IActivityGenericRepository<>))
            //    .InstancePerRequest();

            // NHibernate
            //ContainerBuilder.RegisterType<ActivityUnitOfWorkEF>().As<IActivityUnitOfWork>()
            //    .InstancePerRequest();
            //ContainerBuilder.RegisterGeneric(typeof(ActivityGenericRepositoryEF<>)).As(typeof(IActivityGenericRepository<>))
            //    .InstancePerRequest();
        }
    }
}