using EjadTask.Sharedkernal.Data;

namespace EjadTask.Sharedkernal.DataReposatories
{
    public interface IInsertRepository<TEntity, TPrimaryKey> where TEntity : IEntity<TPrimaryKey>
    {
        Task<TEntity> InsertAndSaveChangesAsync(TEntity entity);
        Task InsertAndSaveChangesAsync(IEnumerable<TEntity> entity);
        Task<bool> InsertAndSaveAsync(TEntity entity);
        TEntity InsertAndSaveChanges(TEntity entity);
        void InsertAndSaveChanges(IEnumerable<TEntity> entity);

        void InsertAdd(TEntity entity);
        Task<bool> InsertAsync(TEntity entity);

        void InsertAdd(IEnumerable<TEntity> entity);
        Task InsertAsync(IEnumerable<TEntity> entity);
    }
}
