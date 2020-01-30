﻿using Autofac;
using EasyLOB.Identity;
using EasyLOB.Identity.Application;
using EasyLOB.Identity.Persistence;

namespace EasyLOB
{
    public static partial class AppDIAutofacHelper
    {
        public static void SetupIdentity(ContainerBuilder containerBuilder)
        {
            //containerBuilder.RegisterType<AuthenticationManagerMock>().As<IAuthenticationManager>()
            //    .InstancePerLifetimeScope();
            containerBuilder.RegisterType<AuthenticationManager>().As<IAuthenticationManager>().InstancePerDependency()
                .InstancePerLifetimeScope();

            containerBuilder.RegisterGeneric(typeof(IdentityGenericApplication<>)).As(typeof(IIdentityGenericApplication<>))
                .InstancePerLifetimeScope();
            containerBuilder.RegisterGeneric(typeof(IdentityGenericApplicationDTO<,>)).As(typeof(IIdentityGenericApplicationDTO<,>))
                .InstancePerLifetimeScope();

            // Entity Framework
            containerBuilder.RegisterType<IdentityUnitOfWorkEF>().As<IIdentityUnitOfWork>()
                .InstancePerLifetimeScope();
            containerBuilder.RegisterGeneric(typeof(IdentityGenericRepositoryEF<>)).As(typeof(IIdentityGenericRepository<>))
                .InstancePerLifetimeScope();

            // NHibernate
            //containerBuilder.RegisterType<IdentityUnitOfWorkEF>().As<IIdentityUnitOfWork>()
            //    .InstancePerLifetimeScope();
            //containerBuilder.RegisterGeneric(typeof(IdentityGenericRepositoryEF<>)).As(typeof(IIdentityGenericRepository<>))
            //    .InstancePerLifetimeScope();
        }
    }
}