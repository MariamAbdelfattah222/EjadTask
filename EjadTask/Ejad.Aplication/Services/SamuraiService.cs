using EjadTask.Ejad.Domain.Data.Entities;
using EjadTask.Ejad.Domain.Interfaces.Reposatories;

namespace EjadTask.Ejad.Aplication.Services
{
    public class SamuraiService
    {
        private readonly IGenericRepository<samurai> _samuraiRepository;

        public SamuraiService(IGenericRepository<samurai> samuraiRepository)
        {
            _samuraiRepository = samuraiRepository;
        }

        public async Task<samurai> GetByIdAsync(int id)
        {
            return await _samuraiRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<samurai>> GetAllAsync()
        {
            return await _samuraiRepository.GetAllAsync();
        }

        public async Task CreateAsync(samurai samurai)
        {
            if (samurai == null)
            {
                throw new ArgumentNullException(nameof(samurai));
            }

            // You can add additional validation here if needed

            await _samuraiRepository.AddAsync(samurai);
        }

        public async Task UpdateAsync(int id, samurai samurai)
        {
            var existingSamurai = await _samuraiRepository.GetByIdAsync(id);
            if (existingSamurai == null)
            {
                throw new ArgumentException($"Samurai with ID {id} not found.");
            }

            // Update existingSamurai properties here

            await _samuraiRepository.UpdateAsync(existingSamurai);
        }

        public async Task DeleteAsync(int id)
        {
            var samurai = await _samuraiRepository.GetByIdAsync(id);
            if (samurai == null)
            {
                throw new ArgumentException($"Samurai with ID {id} not found.");
            }

            await _samuraiRepository.DeleteAsync(samurai);
        }
    }


}

