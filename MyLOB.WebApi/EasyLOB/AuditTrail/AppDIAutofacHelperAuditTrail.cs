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
            //ContainerBuilder.RegisterType<AuditTrailManagerMock>().As<IAuditTrailManager>()
            //    .InstancePerRequest();
            ContainerBuilder.RegisterType<AuditTrailManager>().As<IAuditTrailManager>()
                .InstancePerRequest();

            ContainerBuilder.RegisterGeneric(typeof(AuditTrailGenericApplication<>)).As(typeof(IAuditTrailGenericApplication<>))
                .InstancePerRequest();
            ContainerBuilder.RegisterGeneric(typeof(AuditTrailGenericApplicationDTO<,>)).As(typeof(IAuditTrailGenericApplicationDTO<,>))
                .InstancePerRequest();

            // Entity Framework
            ContainerBuilder.RegisterType<AuditTrailUnitOfWorkEF>().As<IAuditTrailUnitOfWork>()
                .InstancePerRequest();
            ContainerBuilder.RegisterGeneric(typeof(AuditTrailGenericRepositoryEF<>)).As(typeof(IAuditTrailGenericRepository<>))
                .InstancePerRequest();

            // LINQ to DB
            //ContainerBuilder.RegisterType<AuditTrailUnitOfWorkLINQ2DB>().As<IAuditTrailUnitOfWork>()
            //    .InstancePerRequest();
            //ContainerBuilder.RegisterGeneric(typeof(AuditTrailGenericRepositoryLINQ2DB<>)).As(typeof(IAuditTrailGenericRepository<>))
            //    .InstancePerRequest();

            // NHibernate
            //ContainerBuilder.RegisterType<AuditTrailUnitOfWorkEF>().As<IAuditTrailUnitOfWork>()
            //    .InstancePerRequest();
            //ContainerBuilder.RegisterGeneric(typeof(AuditTrailGenericRepositoryEF<>)).As(typeof(IAuditTrailGenericRepository<>))
            //    .InstancePerRequest();
        }
    }
}