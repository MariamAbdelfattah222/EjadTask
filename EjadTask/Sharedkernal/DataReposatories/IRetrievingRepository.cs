using EjadTask.Sharedkernal.Data;

namespace EjadTask.Sharedkernal.DataReposatories
{
    public interface IRetrievingRepository<TEntity, TPrimaryKey> where TEntity : IEntity<TPrimaryKey>
    {
        Task<TEntity?> GetAsync(TPrimaryKey id);
        TEntity? Get(TPrimaryKey id);
        IQueryable<TEntity> GetAllAsQueryable();
    }
    }
