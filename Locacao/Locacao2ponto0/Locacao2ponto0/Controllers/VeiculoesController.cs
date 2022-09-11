using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Locacao2ponto0.Models;

namespace Locacao2ponto0.Controllers
{
    public class VeiculoesController : ApiController
    {
        private Locacao2ponto0Context db = new Locacao2ponto0Context();

        // GET: api/Veiculoes
        public IQueryable<Veiculo> GetVeiculoes()
        {
            return db.Veiculoes;
        }

        // GET: api/Veiculoes/5
        [ResponseType(typeof(Veiculo))]
        public async Task<IHttpActionResult> GetVeiculo(int id)
        {
            Veiculo veiculo = await db.Veiculoes.FindAsync(id);
            if (veiculo == null)
            {
                return NotFound();
            }

            return Ok(veiculo);
        }

        // PUT: api/Veiculoes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutVeiculo(int id, Veiculo veiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != veiculo.Id)
            {
                return BadRequest();
            }

            db.Entry(veiculo).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VeiculoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Veiculoes
        [ResponseType(typeof(Veiculo))]
        public async Task<IHttpActionResult> PostVeiculo(Veiculo veiculo)
        {
			
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Veiculoes.Add(veiculo);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = veiculo.Id }, veiculo);
        }

        // DELETE: api/Veiculoes/5
        [ResponseType(typeof(Veiculo))]
        public async Task<IHttpActionResult> DeleteVeiculo(int id)
        {
            Veiculo veiculo = await db.Veiculoes.FindAsync(id);
            if (veiculo == null)
            {
                return NotFound();
            }

            db.Veiculoes.Remove(veiculo);
            await db.SaveChangesAsync();

            return Ok(veiculo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VeiculoExists(int id)
        {
            return db.Veiculoes.Count(e => e.Id == id) > 0;
        }
    }
}