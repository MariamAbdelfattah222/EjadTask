using EjadTask.Ejad.Domain.Data.Entities;

namespace EjadTask.Ejad.Aplication.Interfaces
{
    public interface ISamurai
    {
        Task<samurai> GetByIdAsync(int id);
        Task<IEnumerable<samurai>> GetAllAsync();
        Task CreateAsync(samurai samurai);
        Task UpdateAsync(int id, samurai samurai);
        Task DeleteAsync(int id);
    }
}
