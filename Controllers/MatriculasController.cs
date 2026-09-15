using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EscolaApi.Data;
using EscolaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EscolaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatriculasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MatriculasController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Matricula>>> GetMatriculas()
        {
            return await _context.Matriculas.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> CriarMatricula(Matricula matricula)
        {
            _context.Matriculas.Add(matricula);
            await _context.SaveChangesAsync();

            return Ok("Matricula salva com sucesso");
        }
    }
}