using Autofac;
using EasyLOB.AuditTrail;
using EasyLOB.AuditTrail.Application;
using EasyLOB.AuditTrail.Persistence;

namespace EasyLOB
{
    public static partial class AppDIAutofacHelper
    {
        public static void SetupAuditTrail()
        {
            //ContainerBuilder.RegisterType<AuditTrailManagerMock>().As<IAuditTrailManager>(); // InstancePerDependency();
            ContainerBuilder.RegisterType<AuditTrailManager>().As<IAuditTrailManager>(); // InstancePerDependency();

            ContainerBuilder.RegisterGeneric(typeof(AuditTrailGenericApplication<>)).As(typeof(IAuditTrailGenericApplication<>)); // InstancePerDependency();
            ContainerBuilder.RegisterGeneric(typeof(AuditTrailGenericApplicationDTO<,>)).As(typeof(IAuditTrailGenericApplicationDTO<,>)); // InstancePerDependency();

            // Entity Framework
            ContainerBuilder.RegisterType<AuditTrailUnitOfWorkEF>().As<IAuditTrailUnitOfWork>(); // InstancePerDependency();
            ContainerBuilder.RegisterGeneric(typeof(AuditTrailGenericRepositoryEF<>)).As(typeof(IAuditTrailGenericRepository<>)); // InstancePerDependency();

            // LINQ to DB
            //ContainerBuilder.RegisterType<AuditTrailUnitOfWorkLINQ2DB>().As<IAuditTrailUnitOfWork>(); // InstancePerDependency();
            //ContainerBuilder.RegisterGeneric(typeof(AuditTrailGenericRepositoryLINQ2DB<>)).As(typeof(IAuditTrailGenericRepository<>)); // InstancePerDependency();

            // NHibernate
            //ContainerBuilder.RegisterType<AuditTrailUnitOfWorkEF>().As<IAuditTrailUnitOfWork>(); // InstancePerDependency();
            //ContainerBuilder.RegisterGeneric(typeof(AuditTrailGenericRepositoryEF<>)).As(typeof(IAuditTrailGenericRepository<>)); // InstancePerDependency();
        }
    }
}