using EjadTask.Ejad.Domain.Data.Entities;

namespace EjadTask.Ejad.Aplication.Interfaces
{
    public interface IHorse
    {
        Task<Horse> GetByIdAsync(int id);
        Task<IEnumerable<Horse>> GetAllAsync();
        Task CreateAsync(Horse horse);
        Task UpdateAsync(int id, Horse horse);
        Task DeleteAsync(int id);

    }
}
