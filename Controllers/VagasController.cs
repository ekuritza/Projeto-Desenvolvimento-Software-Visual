using System.Collections.Generic;
using System.Linq;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/vagas")]
    public class VagasController : ControllerBase
    {
        private readonly DataContext _context;

        public VagasController(DataContext context) =>
            _context = context;
        

        // GET: /api/vagas/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar() => Ok(_context.Vagas.ToList());

        // POST: /api/vagas/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Vagas vagas)
        {
            _context.Vagas.Add(vagas);
            _context.SaveChanges();
            return Created("", vagas);
        }

        // GET: /api/vagas/buscar/{id}
        [HttpGet]
        [Route("buscar/{id}")]
        public IActionResult Buscar([FromRoute] int id)
        {
            Vagas vagas = _context.Vagas.
                FirstOrDefault(f => f.Id.Equals(id));
            return vagas != null ? Ok(vagas) : NotFound();
        }
    }
}