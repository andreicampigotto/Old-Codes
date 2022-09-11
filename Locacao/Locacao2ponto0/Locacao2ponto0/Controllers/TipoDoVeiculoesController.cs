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
    public class TipoDoVeiculoesController : ApiController
    {
        private Locacao2ponto0Context db = new Locacao2ponto0Context();

        // GET: api/TipoDoVeiculoes
        public IQueryable<TipoDoVeiculo> GetTipoDoVeiculoes()
        {
            return db.TipoDoVeiculoes;
        }

        // GET: api/TipoDoVeiculoes/5
        [ResponseType(typeof(TipoDoVeiculo))]
        public async Task<IHttpActionResult> GetTipoDoVeiculo(int id)
        {
            TipoDoVeiculo tipoDoVeiculo = await db.TipoDoVeiculoes.FindAsync(id);
            if (tipoDoVeiculo == null)
            {
                return NotFound();
            }

            return Ok(tipoDoVeiculo);
        }

        // PUT: api/TipoDoVeiculoes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTipoDoVeiculo(int id, TipoDoVeiculo tipoDoVeiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipoDoVeiculo.Id)
            {
                return BadRequest();
            }

            db.Entry(tipoDoVeiculo).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoDoVeiculoExists(id))
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

        // POST: api/TipoDoVeiculoes
        [ResponseType(typeof(TipoDoVeiculo))]
        public async Task<IHttpActionResult> PostTipoDoVeiculo(TipoDoVeiculo tipoDoVeiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TipoDoVeiculoes.Add(tipoDoVeiculo);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = tipoDoVeiculo.Id }, tipoDoVeiculo);
        }

        // DELETE: api/TipoDoVeiculoes/5
        [ResponseType(typeof(TipoDoVeiculo))]
        public async Task<IHttpActionResult> DeleteTipoDoVeiculo(int id)
        {
            TipoDoVeiculo tipoDoVeiculo = await db.TipoDoVeiculoes.FindAsync(id);
            if (tipoDoVeiculo == null)
            {
                return NotFound();
            }

            db.TipoDoVeiculoes.Remove(tipoDoVeiculo);
            await db.SaveChangesAsync();

            return Ok(tipoDoVeiculo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TipoDoVeiculoExists(int id)
        {
            return db.TipoDoVeiculoes.Count(e => e.Id == id) > 0;
        }
    }
}