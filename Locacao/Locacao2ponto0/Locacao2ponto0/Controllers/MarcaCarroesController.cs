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
    public class MarcaCarroesController : ApiController
    {
        private Locacao2ponto0Context db = new Locacao2ponto0Context();

        // GET: api/MarcaCarroes
        public IQueryable<MarcaCarro> GetMarcaCarroes()
        {
            return db.MarcaCarroes;
        }

        // GET: api/MarcaCarroes/5
        [ResponseType(typeof(MarcaCarro))]
        public async Task<IHttpActionResult> GetMarcaCarro(int id)
        {
            MarcaCarro marcaCarro = await db.MarcaCarroes.FindAsync(id);
            if (marcaCarro == null)
            {
                return NotFound();
            }

            return Ok(marcaCarro);
        }

        // PUT: api/MarcaCarroes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutMarcaCarro(int id, MarcaCarro marcaCarro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != marcaCarro.Id)
            {
                return BadRequest();
            }

            db.Entry(marcaCarro).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MarcaCarroExists(id))
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

        // POST: api/MarcaCarroes
        [ResponseType(typeof(MarcaCarro))]
        public async Task<IHttpActionResult> PostMarcaCarro(MarcaCarro marcaCarro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.MarcaCarroes.Add(marcaCarro);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = marcaCarro.Id }, marcaCarro);
        }

        // DELETE: api/MarcaCarroes/5
        [ResponseType(typeof(MarcaCarro))]
        public async Task<IHttpActionResult> DeleteMarcaCarro(int id)
        {
            MarcaCarro marcaCarro = await db.MarcaCarroes.FindAsync(id);
            if (marcaCarro == null)
            {
                return NotFound();
            }

            db.MarcaCarroes.Remove(marcaCarro);
            await db.SaveChangesAsync();

            return Ok(marcaCarro);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MarcaCarroExists(int id)
        {
            return db.MarcaCarroes.Count(e => e.Id == id) > 0;
        }
    }
}