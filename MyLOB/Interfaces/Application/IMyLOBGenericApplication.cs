using EasyLOB;
using EasyLOB.Data;

namespace MyLOB.Application
{
    public interface IMyLOBGenericApplication<TEntity>
        : IGenericApplication<TEntity>
        where TEntity : class, IZDataBase
    {
    }
}
