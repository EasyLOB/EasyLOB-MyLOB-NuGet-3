using EasyLOB;

namespace MyLOB
{
    public interface IMyLOBGenericApplicationDTO<TEntityDTO, TEntity>
        : IGenericApplicationDTO<TEntityDTO, TEntity>
        where TEntityDTO : class, IZDTOBase<TEntityDTO, TEntity>
        where TEntity : class, IZDataBase
    {
    }
}
