using EjadTask.Ejad.Aplication.Interfaces;
using EjadTask.Ejad.Domain.Data.Entities;
using EjadTask.Ejad.Domain.Interfaces.Reposatories;

namespace EjadTask.Ejad.Aplication.Services
{
    public class BattleService : IBattle
    {
        private readonly IGenericRepository<Battle> _battleRepository;

        public BattleService(IGenericRepository<Battle> battleRepository)
        {
            _battleRepository = battleRepository;
        }

        public async Task<Battle> GetByIdAsync(int id)
        {
            return await _battleRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Battle>> GetAllAsync()
        {
            return await _battleRepository.GetAllAsync();
        }

        public async Task CreateAsync(Battle battle)
        {
            if (battle == null)
            {
                throw new ArgumentNullException(nameof(battle));
            }

            // You can add additional validation here if needed

            await _battleRepository.AddAsync(battle);
        }

        public async Task UpdateAsync(int id, Battle battle)
        {
            var existingBattle = await _battleRepository.GetByIdAsync(id);
            if (existingBattle == null)
            {
                throw new ArgumentException($"Battle with ID {id} not found.");
            }

            // Update existingBattle properties here

            await _battleRepository.UpdateAsync(existingBattle);
        }

        public async Task DeleteAsync(int id)
        {
            var battle = await _battleRepository.GetByIdAsync(id);
            if (battle == null)
            {
                throw new ArgumentException($"Battle with ID {id} not found.");
            }

            await _battleRepository.DeleteAsync(battle);
        }

      
    }
}
