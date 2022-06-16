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
    [Route("api/[controller]es")]
    [ApiController]
    public class OperacionController : ControllerBase
    {
        private readonly AplicationDbContext _context;
        private readonly OperacionNegocio OperacionNegocio;

        public OperacionController(AplicationDbContext context, OperacionNegocio operacionNegocio)
        {
            _context = context;
            this.OperacionNegocio = operacionNegocio;
        }

        // GET: api/Operacion
        [HttpGet]
        public async Task<ActionResult<List<Operacion>>> GetAll()
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var listaOperaciones = OperacionNegocio.GetAll();
                    if (listaOperaciones.Count() == 0)
                    {
                        return NoContent();
                    }
                    return Ok(listaOperaciones);
                }
                catch (Exception)
                {

                    return StatusCode(500, ModelState);
                }
            }
            return BadRequest();
        }

        //GET api/Operaciones/tarjeta/1
        [HttpGet("Tarjeta/{idTarjeta}")]
        public async Task<ActionResult<List<Operacion>>> GetListaByIdTarjeta(int idTarjeta)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var listaOperaciones = OperacionNegocio.GetListaByIdTarjeta(idTarjeta);
                    if (listaOperaciones.Count() == 0)
                    {
                        return NoContent();
                    }
                    return Ok(listaOperaciones);
                }
                catch (Exception)
                {

                    return StatusCode(500, ModelState);
                }
            }
            return BadRequest();
        }

        // GET: api/Operacion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Operacion>> GetById(int id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var operacion = OperacionNegocio.GetById(id);
                    if (operacion == null)
                    {
                        return NotFound();
                    }
                    return Ok(operacion);
                }
                catch (Exception)
                {
                    return StatusCode(500, ModelState);
                }
            }
            return BadRequest();
        }


        [HttpGet("exists/{operacion}")]
        public async Task<ActionResult<bool>> Exists(int operacion)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var exist = OperacionNegocio.Exists(operacion);
                    if (!exist)
                    {
                        return NotFound();
                    }
                    return Ok(true);
                }
                catch (Exception)
                {
                    return StatusCode(500, ModelState);
                }
            }
            return BadRequest(); ;
        }



        // PUT: api/Operacion/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Operacion operacion)
        {
            if (id == operacion.IdOperacion)
            {
                try
                {
                    if (OperacionNegocio.Update(operacion))
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

        // POST: api/Operacion
        [HttpPost]
        public async Task<ActionResult<Operacion>> Insert(Operacion operacion)
        {
            if (operacion != null)
            {
                try
                {
                    var rta = OperacionNegocio.Insert(operacion);
                    if (rta == false)
                    {
                        return BadRequest();

                    }
                    return StatusCode(201, operacion);
                }
                catch (Exception ex)
                {
                    return StatusCode(500, ModelState);
                }
            }
            return BadRequest();
        }

        //// DELETE: api/Operacion/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteOperacion(int id)
        //{
        //    var operacion = await _context.operaciones.FindAsync(id);
        //    if (operacion == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.operaciones.Remove(operacion);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool OperacionExists(int id)
        //{
        //    return _context.operaciones.Any(e => e.IdOperacion == id);
        //}
    }
}
