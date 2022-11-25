using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PIA___Loteria.Entidades;

namespace PIA___Loteria.Controllers
{
    [ApiController]
    [Route("api/participates")]

    public class ParticipantesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public ParticipantesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Participante>>> Get()
        {
            return await dbContext.Participantes.ToListAsync();
 
        }

        [HttpPost]

        public async Task<ActionResult> Post(Participante participante)
        {
            dbContext.Add(participante);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")] // api/participantes/1
        public async Task<ActionResult> Put(Participante participante, int id)
        { 

            if (participante.Id != id)
            {
                return BadRequest("El id del participante no coincide con el establecido en la url.");
            }

            dbContext.Update(participante);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exist = await dbContext.Participantes.AnyAsync(x => x.Id == id);
            if (!exist)
            {
                return NotFound("La informacion a sido borrada");
            }
            dbContext.Remove(new Participante()
            {
                Id = id

            });
            await dbContext.SaveChangesAsync();
            return Ok();

        }
    }
}
