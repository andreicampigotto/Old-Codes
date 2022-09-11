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
    public class TermosLocacaosController : ApiController
    {
        private Locacao2ponto0Context db = new Locacao2ponto0Context();

        // GET: api/TermosLocacaos
        public IQueryable<TermosLocacao> GetTermosLocacaos()
        {
            return db.TermosLocacaos;
        }

        // GET: api/TermosLocacaos/5
        [ResponseType(typeof(TermosLocacao))]
        public async Task<IHttpActionResult> GetTermosLocacao(int id)
        {
            TermosLocacao termosLocacao = await db.TermosLocacaos.FindAsync(id);
            if (termosLocacao == null)
            {
                return NotFound();
            }

            return Ok(termosLocacao);
        }

        // PUT: api/TermosLocacaos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTermosLocacao(int id, TermosLocacao termosLocacao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != termosLocacao.Id)
            {
                return BadRequest();
            }

            db.Entry(termosLocacao).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TermosLocacaoExists(id))
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

        // POST: api/TermosLocacaos
        [ResponseType(typeof(TermosLocacao))]
        public async Task<IHttpActionResult> PostTermosLocacao(TermosLocacao termosLocacao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TermosLocacaos.Add(termosLocacao);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = termosLocacao.Id }, termosLocacao);
        }

        // DELETE: api/TermosLocacaos/5
        [ResponseType(typeof(TermosLocacao))]
        public async Task<IHttpActionResult> DeleteTermosLocacao(int id)
        {
            TermosLocacao termosLocacao = await db.TermosLocacaos.FindAsync(id);
            if (termosLocacao == null)
            {
                return NotFound();
            }

            db.TermosLocacaos.Remove(termosLocacao);
            await db.SaveChangesAsync();

            return Ok(termosLocacao);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TermosLocacaoExists(int id)
        {
            return db.TermosLocacaos.Count(e => e.Id == id) > 0;
        }
    }
}