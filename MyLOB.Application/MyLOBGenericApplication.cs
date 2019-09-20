using MyLOB.Persistence;
using EasyLOB;
using EasyLOB.Application;
using EasyLOB.Data;

namespace MyLOB.Application
{
    public class MyLOBGenericApplication<TEntity>
        : GenericApplication<TEntity>, IMyLOBGenericApplication<TEntity>
        where TEntity : class, IZDataBase
    {
        #region Methods

        public MyLOBGenericApplication(IMyLOBUnitOfWork unitOfWork)
            : base(unitOfWork)            
        {
        }

        #endregion Methods
    }
}