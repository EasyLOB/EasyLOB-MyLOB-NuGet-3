using EasyLOB;
using EasyLOB.Application;

namespace MyLOB.Application
{
    public class MyLOBGenericApplication<TEntity>
        : GenericApplication<TEntity>, IMyLOBGenericApplication<TEntity>
        where TEntity : class, IZDataBase
    {
        #region Methods

        public MyLOBGenericApplication(IMyLOBUnitOfWork unitOfWork,
            IAuditTrailManager auditTrailManager,
            IAuthorizationManager authorizationManager)
            : base(unitOfWork, auditTrailManager, authorizationManager)
        {
        }

        #endregion Methods
    }
}