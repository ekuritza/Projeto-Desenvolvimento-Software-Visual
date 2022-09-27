using System.Collections.Generic;
using System.Linq;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/morador")]
    public class MoradorController : ControllerBase
    {
        private readonly DataContext _context;

        public MoradorController(DataContext context) =>
            _context = context;
        

        // GET: /api/morador/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar() => Ok(_context.Morador.ToList());

        // POST: /api/morador/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Morador morador)
        {
            _context.Morador.Add(morador);
            _context.SaveChanges();
            return Created("", morador);
        }

        // GET: /api/morador/buscar/{cpf}
        [HttpGet]
        [Route("buscar/{cpf}")]
        public IActionResult Buscar([FromRoute] string cpf)
        {
            Morador morador = _context.Morador.
                FirstOrDefault(f => f.Cpf.Equals(cpf));
            return morador != null ? Ok(morador) : NotFound();
        }

        // DELETE: /api/morador/deletar/{cpf}
        [HttpDelete]
        [Route("deletar/{id}")]
        public IActionResult Deletar([FromRoute] int id)
        {
            Morador morador = _context.Morador.Find(id);
            if(morador != null)
            {
                _context.Morador.Remove(morador);
                _context.SaveChanges();
                return Ok(morador);
            }
            return NotFound();
        }

        // PATCH: /api/morador/alterar
        [HttpPatch]
        [Route("alterar")]
        public IActionResult Alterar([FromBody] Morador morador)
        {
            try
            {
                _context.Morador.Update(morador);
                _context.SaveChanges();
                return Ok(morador);
            }
            catch
            {
                return NotFound();
            }  
               
        }
    }
}