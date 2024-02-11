using EjadTask.Sharedkernal.Data;
using System.Data;

namespace EjadTask.Sharedkernal.DataReposatories
{
    public interface IBaseRepository
    {
        public interface IBaseRepository<TEntity, TPrimaryKey> : IInsertRepository<TEntity, TPrimaryKey>,
                                                           IUpdatingRepository<TEntity, TPrimaryKey>,
                                                           IDeleteRepository<TEntity, TPrimaryKey>,
                                                           IRetrievingRepository<TEntity, TPrimaryKey>
                                                           where TEntity : IEntity<TPrimaryKey>
        {

           
            void SaveChanges();
            Task SaveChangesAsync();

        }
    }
}

