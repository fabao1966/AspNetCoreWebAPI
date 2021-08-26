using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        public ProfessorController(){ }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Professores: bob esponja, lula molusco, penélope charmosa, manda chuva");
        }
    }
}