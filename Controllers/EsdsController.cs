using DirectoryWebApi.Models.Entities;
using DirectoryWebApi.Models.Resources;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DirectoryWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EsdsController : ControllerBase
    {
        private readonly DirectoryApiDbContext _dbContext;

        public EsdsController(DirectoryApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/<EsdsController>
        [HttpGet(Name = nameof(GetEsds))]
        [ProducesResponseTypeAttribute(404)]
        public async Task<ActionResult<IEnumerable<Esd>>> GetEsds()
        {
            var entities = await _dbContext.Esds.ToListAsync();

            if(entities == null)
            {
                return NotFound();
            }

            List<Esd> esds = new List<Esd>();
            foreach (var entity in entities)
            {
                esds.Add(new Esd(entity));
            }

            return esds;
        }

        // GET api/<EsdsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Esd>> GetEsd(int id)
        {
            var entity = await _dbContext.Esds.FindAsync(id);

            if(entity == null)
            {
                return BadRequest();
            }

            return new Esd(entity);
           
        }

        // POST api/<EsdsController>
        [HttpPost]
        public async Task<ActionResult<Esd>> CreateEsd(Esd esd)
        {
            var entity = new EsdEntity(esd);

            if(entity == null)
            {
                return BadRequest();
            }

            var createdEsd = await _dbContext.Esds.AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEsd), new {id = entity.Id}, esd);

        }

        // PUT api/<EsdsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Esd>> UpdateEsd(int id, Esd esd)
        {
            if(id == null)
            {
                return BadRequest();
            }

            var entity = await _dbContext.Esds.FindAsync(id);

            if(entity == null)
            {
                return NotFound();
            }

            entity.Name = esd.Name;
            entity.Code = esd.Code;
            entity.AddressLine1 = esd.AddressLine1;
            entity.AddressLine2 = esd.AddressLine2;
            entity.State = esd.State;
            entity.ZipCode = esd.ZipCode;
            entity.Phone = esd.Phone;
            entity.Email = esd.Email;
            entity.AdministratorName = esd.AdministratorName;

            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/<EsdsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Esd>> Delete(int id)
        {
            if(id == null)
            {
                return BadRequest();
            }

            var entity = await _dbContext.Esds.FindAsync(id);

            if (entity == null)
            {
                return NotFound();
            }

            _dbContext.Esds.Remove(entity);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
