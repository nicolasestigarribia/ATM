using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BancoApi.Data;
using BancoApi.Models;
using BancoApi.Negocios;

namespace BancoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarjetasController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        private readonly TarjetaNegocio TarjetaNegocio; 

        public TarjetasController(AplicationDbContext context, TarjetaNegocio tarjetaNegocio)
        {
            _context = context;
            this.TarjetaNegocio = tarjetaNegocio;
        }

        // GET: api/Tarjetas
        [HttpGet]
        public ActionResult<IEnumerable<Tarjeta>> GetAll()
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var listaTarjeta = TarjetaNegocio.GetAll();
                    if (listaTarjeta.Count() == 0)
                    {
                        return NoContent();
                    }
                    return Ok(listaTarjeta);
                }
                catch (Exception)
                {

                    return StatusCode(500, ModelState);
                }
            }
            return BadRequest();
        }

        // GET: api/Tarjetas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tarjeta>> GetById(int id)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var tarjeta = TarjetaNegocio.GetById(id);
                    if (tarjeta == null)
                    {
                        return NotFound();
                    }
                    return Ok(tarjeta);
                }
                catch (Exception)
                {
                    return StatusCode(500, ModelState);
                }
            }
            return BadRequest(); ;
        }

        // GET: api/Tarjetas/numero/5
        [HttpGet("numero/{numeroTarjeta}")]
        public async Task<ActionResult<Tarjeta>> GetById(string numeroTarjeta)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var tarjeta = TarjetaNegocio.GetByNumTarjeta(numeroTarjeta);
                    if (tarjeta == null)
                    {
                        return NotFound();
                    }
                    return Ok(tarjeta);
                }
                catch (Exception)
                {
                    return StatusCode(500, ModelState);
                }
            }
            return BadRequest(); ;
        }


        // GET: api/Tarjetas/exists/5
        [HttpGet("exists/{tarjeta}")]
        public async Task<ActionResult<bool>> Exists(string tarjeta)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var exist = TarjetaNegocio.Exists(tarjeta);
                    if (!exist)
                    {
                        return NotFound(false);
                    }
                    return Ok(true);
                }
                catch (Exception)
                {
                    return StatusCode(500, ModelState);
                }
            }
            return BadRequest(false); ;
        }

        // PUT: api/Tarjetas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Tarjeta tarjeta)
        {
            if(id == tarjeta.IdTarjeta)
            {
                try
                {
                    if(TarjetaNegocio.Update(tarjeta))
                    {
                        return NoContent();
                    }
                    return NotFound();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return StatusCode(500, ModelState);
                }
            }
            return BadRequest();
        }

        //// POST: api/Tarjetas
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Tarjeta>> PostTarjeta(Tarjeta tarjeta)
        //{
        //    _context.tarjetas.Add(tarjeta);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetTarjeta", new { id = tarjeta.IdTarjeta }, tarjeta);
        //}

        // DELETE: api/Tarjetas/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteTarjeta(int id)
        //{
        //    var tarjeta = await _context.tarjetas.FindAsync(id);
        //    if (tarjeta == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.tarjetas.Remove(tarjeta);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

    }
}
