using Autofac;
using MyLOB;
using MyLOB.Application;
using MyLOB.Persistence;

namespace EasyLOB
{
    public static partial class AppDIAutofacHelper
    {
        public static void SetupApplication(ContainerBuilder containerBuilder) // !!!
        {
            /*
            containerBuilder.RegisterType<MyLOBApplication>().As<IMyLOBApplication>()
                .InstancePerRequest();

            containerBuilder.RegisterGeneric(typeof(MyLOBGenericApplication<>)).As(typeof(IMyLOBGenericApplication<>))
                .InstancePerRequest();
            containerBuilder.RegisterGeneric(typeof(MyLOBGenericApplicationDTO<,>)).As(typeof(IMyLOBGenericApplicationDTO<,>))
                .InstancePerRequest();

            // Entity Framework
            containerBuilder.RegisterType<MyLOBUnitOfWorkEF>().As<IMyLOBUnitOfWork>()
                .InstancePerRequest();
            containerBuilder.RegisterGeneric(typeof(MyLOBGenericRepositoryEF<>)).As(typeof(IMyLOBGenericRepository<>))
                .InstancePerRequest();

            // LINQ to DB
            //containerBuilder.RegisterType<MyLOBUnitOfWorkLINQ2DB>().As<IMyLOBUnitOfWork>()
            //    .InstancePerRequest();
            //containerBuilder.RegisterGeneric(typeof(MyLOBGenericRepositoryLINQ2DB<>)).As(typeof(IMyLOBGenericRepository<>))
            //    .InstancePerRequest();

            // NHibernate
            //containerBuilder.RegisterType<MyLOBUnitOfWorkEF>().As<IMyLOBUnitOfWork>()
            //    .InstancePerRequest();
            //containerBuilder.RegisterGeneric(typeof(MyLOBGenericRepositoryEF<>)).As(typeof(IMyLOBGenericRepository<>))
            //    .InstancePerRequest();
            */
        }
    }
}