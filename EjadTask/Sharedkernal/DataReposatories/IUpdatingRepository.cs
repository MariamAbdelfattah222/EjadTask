using EjadTask.Sharedkernal.Data;

namespace EjadTask.Sharedkernal.DataReposatories
{
    public interface IUpdatingRepository<TEntity, TPrimaryKey> where TEntity : IEntity<TPrimaryKey>
    {
        void UpdateAndSaveChanges(TEntity entity);
        void UpdateAndSaveChanges(IEnumerable<TEntity> entities);

        Task UpdateAndSaveChangesAsync(TEntity entity);

        Task UpdateAndSaveChangesAsync(IEnumerable<TEntity> entities);

        void Update(TEntity entity);
        void Update(IEnumerable<TEntity> entities);
    }
}
