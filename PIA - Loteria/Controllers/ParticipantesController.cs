using Microsoft.AspNetCore.Mvc;
using PIA___Loteria.Entidades;

namespace PIA___Loteria.Controllers
{
    [ApiController]
    [Route("api/participates")]

    public class ParticipantesController : ControllerBase
    {
        [HttpGet]

        public ActionResult<List<Participante>> Get()
        {
            return new List<Participante>()
            {
                new Participante() { Id = 1, Nombre = "Brenda", Direccion = "Guadalupe" },
                new Participante() { Id = 2, Nombre = "Sergio", Direccion = "Apodafica" }
            };
        }
    }
}
