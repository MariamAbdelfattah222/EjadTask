using EjadTask.Ejad.Aplication.Interfaces;
using EjadTask.Ejad.Domain.Data.Entities;
using EjadTask.Ejad.Domain.Interfaces.Reposatories;

namespace EjadTask.Ejad.Aplication.Services
{
    public class HorseService : IHorse
    {
        private readonly IGenericRepository<Horse> _horseRepository;

        public HorseService(IGenericRepository<Horse> horseRepository)
        {
            _horseRepository = horseRepository;
        }

        public async Task<Horse> GetByIdAsync(int id)
        {
            return await _horseRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Horse>> GetAllAsync()
        {
            return await _horseRepository.GetAllAsync();
        }

        public async Task CreateAsync(Horse horse)
        {
            await _horseRepository.AddAsync(horse);
        }

        public async Task UpdateAsync(int id, Horse horse)
        {
            var existingHorse = await _horseRepository.GetByIdAsync(id);
            if (existingHorse == null)
            {
                
                return ;
            }

            existingHorse.Name = horse.Name;

            await _horseRepository.UpdateAsync(existingHorse);
        }

        public async Task DeleteAsync(int id)
        {
            var horse = await _horseRepository.GetByIdAsync(id);
            if (horse == null)
            {
                // Handle not found scenario
                return;
            }

            await _horseRepository.DeleteAsync(horse);
        }
    }
}