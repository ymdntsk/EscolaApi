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

        [HttpGet("buscar")]
        public async Task<ActionResult<IEnumerable<Curso>>> BuscarCurso([FromQuery] string termo)
        {
            var cursos = await _context.Cursos.Where(c => c.Titulo.ToLower().Contains(termo.ToLower())).ToListAsync();

            if (cursos.Count == 0) 
            { 
                return NotFound("Nenhum curso encontrado com o termo informado.");
            }
            return Ok(cursos);
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