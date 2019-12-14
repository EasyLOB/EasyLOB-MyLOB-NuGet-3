using Autofac;
using MyLOB;
using MyLOB.Application;
using MyLOB.Persistence;

namespace EasyLOB
{
    public static partial class AppDIAutofacHelper
    {
        public static void SetupApplication() // !!!
        {
            /*
            ContainerBuilder.RegisterType<MyLOBApplication>().As<IMyLOBApplication>()
                .InstancePerRequest();

            ContainerBuilder.RegisterGeneric(typeof(MyLOBGenericApplication<>)).As(typeof(IMyLOBGenericApplication<>))
                .InstancePerRequest();
            ContainerBuilder.RegisterGeneric(typeof(MyLOBGenericApplicationDTO<,>)).As(typeof(IMyLOBGenericApplicationDTO<,>))
                .InstancePerRequest();

            // Entity Framework
            ContainerBuilder.RegisterType<MyLOBUnitOfWorkEF>().As<IMyLOBUnitOfWork>()
                .InstancePerRequest();
            ContainerBuilder.RegisterGeneric(typeof(MyLOBGenericRepositoryEF<>)).As(typeof(IMyLOBGenericRepository<>))
                .InstancePerRequest();

            // LINQ to DB
            //ContainerBuilder.RegisterType<MyLOBUnitOfWorkLINQ2DB>().As<IMyLOBUnitOfWork>()
            //    .InstancePerRequest();
            //ContainerBuilder.RegisterGeneric(typeof(MyLOBGenericRepositoryLINQ2DB<>)).As(typeof(IMyLOBGenericRepository<>))
            //    .InstancePerRequest();

            // NHibernate
            //ContainerBuilder.RegisterType<MyLOBUnitOfWorkEF>().As<IMyLOBUnitOfWork>()
            //    .InstancePerRequest();
            //ContainerBuilder.RegisterGeneric(typeof(MyLOBGenericRepositoryEF<>)).As(typeof(IMyLOBGenericRepository<>))
            //    .InstancePerRequest();
            */
        }
    }
}