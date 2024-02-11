using EjadTask.Ejad.Domain.Data.Entities;

namespace EjadTask.Ejad.Aplication.Interfaces
{
    public interface IBattle
    {
        Task<Battle> GetByIdAsync(int id);
        Task<IEnumerable<Battle>> GetAllAsync();
        Task CreateAsync(Battle battle);
        Task UpdateAsync(int id, Battle battle);
        Task DeleteAsync(int id);
    }
}
