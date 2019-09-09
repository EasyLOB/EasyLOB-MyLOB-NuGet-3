using EasyLOB;
using EasyLOB.Data;

namespace MyLOB.Persistence
{
    public interface IMyLOBGenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class, IZDataBase
    {
    }
}
