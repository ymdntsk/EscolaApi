using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EscolaApi.Data;
using EscolaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EscolaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessoresController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProfessoresController(AppDbContext context)
        {
            _context = context;
        }
        //os Professor controlers depende de appDbContent

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Professor>>> GetProfessores() 
        { 
            return await _context.Professores.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> AddProfessor(Professor professor)
        {
            _context.Professores.Add(professor);
            await _context.SaveChangesAsync();

            return Ok("Professor salvo com sucesso");
        }
    }
}
