using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EscolaApi.Data;
using EscolaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EscolaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModulosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ModulosController(AppDbContext context)
        {
            _context = context;
        }

        // O ModulosController depende do AppDbContext

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Modulo>>> GetModulos()
        {
            return await _context.Modulos.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> CriarModulo(Modulo modulo)
        {
            _context.Modulos.Add(modulo);
            await _context.SaveChangesAsync();

            return Ok("Modulo salvo com sucesso");
        }
    }
}