using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EscolaApi.Data;
using EscolaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EscolaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CursosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Curso>>> GetCursos()
        {
            return await _context.Cursos.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> AddCurso(Curso curso)
        {
            _context.Cursos.Add(curso);
            await _context.SaveChangesAsync();

            return Ok("Curso salvo com sucesso");
        }
    }
}