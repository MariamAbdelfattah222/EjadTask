using EjadTask.Sharedkernal.Data;

namespace EjadTask.Sharedkernal.DataReposatories
{
    public interface IDeleteRepository<TEntity, PrimaryKey> : IEntity<PrimaryKey>
    {

        Task DeleteAndSaveChangesAsync(PrimaryKey key);
    }
}
