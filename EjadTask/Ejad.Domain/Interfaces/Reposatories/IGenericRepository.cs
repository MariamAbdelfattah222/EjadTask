using EjadTask.Sharedkernal.Data;
using static EjadTask.Sharedkernal.DataReposatories.IBaseRepository;

namespace EjadTask.Ejad.Domain.Interfaces.Reposatories
{

       
        public interface IGenericRepository<T> where T : class
        {
            Task<T> GetByIdAsync(int id);
            Task<IEnumerable<T>> GetAllAsync();
            Task AddAsync(T entity);
            Task UpdateAsync(T entity);
            Task DeleteAsync(T entity);
        }

    }


