using EjadTask.Ejad.Aplication.Interfaces;
using EjadTask.Ejad.Domain.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjadTask.Ejad.presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HorsesController : ControllerBase
    {
        private readonly IHorse _horseService;

        public HorsesController(IHorse horseService)
        {
            _horseService = horseService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Horse>> GetById(int id)
        {
            var horse = await _horseService.GetByIdAsync(id);
            if (horse == null)
            {
                return NotFound();
            }
            return horse;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Horse>>> GetAll()
        {
            var horses = await _horseService.GetAllAsync();
            return Ok(horses);
        }

        [HttpPost]
        public async Task<ActionResult> Create(Horse horse)
        {
            await _horseService.CreateAsync(horse);
            return CreatedAtAction(nameof(GetById), new { id = horse.Id }, horse);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Horse horse)
        {
            await _horseService.UpdateAsync(id, horse);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _horseService.DeleteAsync(id);
            return NoContent();
        }
    }
}
