using EjadTask.Ejad.Aplication.Interfaces;
using EjadTask.Ejad.Domain.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjadTask.Ejad.presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SamuraiController : ControllerBase
    {
        private readonly ISamurai _samuraiService;

        public SamuraiController(ISamurai samuraiService)
        {
            _samuraiService = samuraiService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<samurai>> GetById(int id)
        {
            var samurai = await _samuraiService.GetByIdAsync(id);
            if (samurai == null)
            {
                return NotFound();
            }
            return samurai;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<samurai>>> GetAll()
        {
            var samurais = await _samuraiService.GetAllAsync();
            return Ok(samurais);
        }

        [HttpPost]
        public async Task<ActionResult> Create(samurai samurai)
        {
            await _samuraiService.CreateAsync(samurai);
            return CreatedAtAction(nameof(GetById), new { id = samurai.Id }, samurai);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, samurai samurai)
        {
            await _samuraiService.UpdateAsync(id, samurai);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _samuraiService.DeleteAsync(id);
            return NoContent();
        }

    }
}
