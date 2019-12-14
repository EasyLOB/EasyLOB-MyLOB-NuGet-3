using Autofac;
using EasyLOB.Identity;
using EasyLOB.Identity.Application;
using EasyLOB.Identity.Persistence;

namespace EasyLOB
{
    public static partial class AppDIAutofacHelper
    {
        public static void SetupIdentity()
        {
            //ContainerBuilder.RegisterType<AuthenticationManagerMock>().As<IAuthenticationManager>()
            //    .InstancePerRequest();
            ContainerBuilder.RegisterType<AuthenticationManager>().As<IAuthenticationManager>().InstancePerDependency()
                .InstancePerRequest();

            ContainerBuilder.RegisterGeneric(typeof(IdentityGenericApplication<>)).As(typeof(IIdentityGenericApplication<>))
                .InstancePerRequest();
            ContainerBuilder.RegisterGeneric(typeof(IdentityGenericApplicationDTO<,>)).As(typeof(IIdentityGenericApplicationDTO<,>))
                .InstancePerRequest();

            // Entity Framework
            ContainerBuilder.RegisterType<IdentityUnitOfWorkEF>().As<IIdentityUnitOfWork>()
                .InstancePerRequest();
            ContainerBuilder.RegisterGeneric(typeof(IdentityGenericRepositoryEF<>)).As(typeof(IIdentityGenericRepository<>))
                .InstancePerRequest();

            // NHibernate
            //ContainerBuilder.RegisterType<IdentityUnitOfWorkEF>().As<IIdentityUnitOfWork>()
            //    .InstancePerRequest();
            //ContainerBuilder.RegisterGeneric(typeof(IdentityGenericRepositoryEF<>)).As(typeof(IIdentityGenericRepository<>))
            //    .InstancePerRequest();
        }
    }
}