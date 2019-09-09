using MyLOB.Persistence;
using EasyLOB;
using EasyLOB.Application;
using EasyLOB.Data;

namespace MyLOB.Application
{
    public class MyLOBGenericApplicationDTO<TEntityDTO, TEntity>
        : GenericApplicationDTO<TEntityDTO, TEntity>, IMyLOBGenericApplicationDTO<TEntityDTO, TEntity>
        where TEntityDTO : class, IZDTOBase<TEntityDTO, TEntity>
        where TEntity : class, IZDataBase
    {
        #region Methods

        public MyLOBGenericApplicationDTO(IMyLOBUnitOfWork unitOfWork, IDIManager diManager)
            : base(unitOfWork, diManager)
        {
        }

        #endregion Methods
    }
}