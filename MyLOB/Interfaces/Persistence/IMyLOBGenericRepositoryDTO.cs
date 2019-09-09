using EasyLOB;
using EasyLOB.Data;

namespace MyLOB.Persistence
{
    public interface IMyLOBGenericRepositoryDTO<TEntityDTO, TEntity> : IGenericRepositoryDTO<TEntityDTO, TEntity>
        where TEntityDTO : class, IZDTOBase<TEntityDTO, TEntity>
        where TEntity : class, IZDataBase
    {
    }
}
