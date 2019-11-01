using Autofac;
using MyLOB;
using MyLOB.Application;
using MyLOB.Persistence;

namespace EasyLOB
{
    public static partial class AppDIAutofacHelper
    {
        public static void SetupMyLOB() // !!!
        {
            /*
            Container.RegisterType(typeof(IMyLOBApplication), typeof(MyLOBApplication), AppLifetimeManager);

            Container.RegisterType(typeof(IMyLOBGenericApplication<>), typeof(MyLOBGenericApplication<>), AppLifetimeManager);
            Container.RegisterType(typeof(IMyLOBGenericApplicationDTO<,>), typeof(MyLOBGenericApplicationDTO<,>), AppLifetimeManager);

            // Entity Framework
            Container.RegisterType(typeof(IMyLOBUnitOfWork), typeof(MyLOBUnitOfWorkEF), AppLifetimeManager);
            Container.RegisterType(typeof(IMyLOBGenericRepository<>), typeof(MyLOBGenericRepositoryEF<>), AppLifetimeManager);

            // LINQ to DB
            //Container.RegisterType(typeof(IMyLOBUnitOfWork), typeof(MyLOBUnitOfWorkLINQ2DB), AppLifetimeManager);
            //Container.RegisterType(typeof(IMyLOBGenericRepository<>), typeof(MyLOBGenericRepositoryLINQ2DB<>), AppLifetimeManager);

            // NHibernate
            //Container.RegisterType(typeof(IMyLOBUnitOfWork), typeof(MyLOBUnitOfWorkNH), AppLifetimeManager);
            //Container.RegisterType(typeof(IMyLOBGenericRepository<>), typeof(MyLOBGenericRepositoryNH<>), AppLifetimeManager);
            */
        }
    }
}