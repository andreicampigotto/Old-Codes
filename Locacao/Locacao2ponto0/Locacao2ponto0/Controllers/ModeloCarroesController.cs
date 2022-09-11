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
    public class ModeloCarroesController : ApiController
    {
        private Locacao2ponto0Context db = new Locacao2ponto0Context();

        // GET: api/ModeloCarroes
        public IQueryable<ModeloCarro> GetModeloCarroes()
        {
            return db.ModeloCarroes;
        }

        // GET: api/ModeloCarroes/5
        [ResponseType(typeof(ModeloCarro))]
        public async Task<IHttpActionResult> GetModeloCarro(int id)
        {
            ModeloCarro modeloCarro = await db.ModeloCarroes.FindAsync(id);
            if (modeloCarro == null)
            {
                return NotFound();
            }

            return Ok(modeloCarro);
        }

        // PUT: api/ModeloCarroes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutModeloCarro(int id, ModeloCarro modeloCarro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != modeloCarro.Id)
            {
                return BadRequest();
            }

            db.Entry(modeloCarro).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModeloCarroExists(id))
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

        // POST: api/ModeloCarroes
        [ResponseType(typeof(ModeloCarro))]
        public async Task<IHttpActionResult> PostModeloCarro(ModeloCarro modeloCarro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ModeloCarroes.Add(modeloCarro);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = modeloCarro.Id }, modeloCarro);
        }

        // DELETE: api/ModeloCarroes/5
        [ResponseType(typeof(ModeloCarro))]
        public async Task<IHttpActionResult> DeleteModeloCarro(int id)
        {
            ModeloCarro modeloCarro = await db.ModeloCarroes.FindAsync(id);
            if (modeloCarro == null)
            {
                return NotFound();
            }

            db.ModeloCarroes.Remove(modeloCarro);
            await db.SaveChangesAsync();

            return Ok(modeloCarro);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ModeloCarroExists(int id)
        {
            return db.ModeloCarroes.Count(e => e.Id == id) > 0;
        }
    }
}