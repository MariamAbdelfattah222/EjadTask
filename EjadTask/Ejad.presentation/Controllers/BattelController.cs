using EjadTask.Ejad.Aplication.Interfaces;
using EjadTask.Ejad.Aplication.Services;
using EjadTask.Ejad.Domain.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjadTask.Ejad.presentation
{
    [Route("api/[controller]")]
    [ApiController]
    public class BattelController : ControllerBase
    {
        private readonly IBattle _battleService;

        public BattelController(IBattle battleService)
        {
            _battleService = battleService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Battle>> GetById(int id)
        {
            var battle = await _battleService.GetByIdAsync(id);
            if (battle == null)
            {
                return NotFound();
            }
            return battle;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Battle>>> GetAll()
        {
            var battles = await _battleService.GetAllAsync();
            return Ok(battles);
        }

        [HttpPost]
        public async Task<ActionResult> Create(Battle battle)
        {
            await _battleService.CreateAsync(battle);
            return CreatedAtAction(nameof(GetById), new { id = battle.Id }, battle);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Battle battle)
        {
            await _battleService.UpdateAsync(id, battle);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _battleService.DeleteAsync(id);
            return NoContent();
        }

    }
}
