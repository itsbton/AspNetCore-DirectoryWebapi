using DirectoryWebApi.Models.Entities;
using DirectoryWebApi.Models.Resources;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DirectoryWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictsController : ControllerBase
    {
        private readonly DirectoryApiDbContext _dbContext;

        public DistrictsController(DirectoryApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/<DistrictsController>
        [HttpGet(Name = nameof(GetDistricts))]
        public async Task<ActionResult<IEnumerable<District>>> GetDistricts()
        {
            var entities = await _dbContext.Districts.ToListAsync();

            if(entities == null)
            {
                return NotFound();
            }

            List<District> districts = new List<District>();
            foreach (var entity in entities)
            {
                districts.Add(new District(entity));
            }

            return districts;
        }

        // GET api/<DistrictsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<District>> GetDistrict(int id)
        {
            var entity = await _dbContext.Districts.FindAsync(id);

            if(entity == null)
            {
                return BadRequest();
            }

            return new District(entity);
           
        }

        // POST api/<DistrictsController>
        [HttpPost]
        public async Task<ActionResult<District>> CreateDistrict(District district)
        {
            var entity = new DistrictEntity(district);

            if(entity == null)
            {
                return BadRequest();
            }

            var createdDistrict = await _dbContext.Districts.AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDistrict), new {id = entity.Id}, district);

        }

        // PUT api/<DistrictsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<District>> UpdateDistrict(int id, District district)
        {
            if(id == null)
            {
                return BadRequest();
            }

            var entity = await _dbContext.Districts.FindAsync(id);

            if(entity == null)
            {
                return NotFound();
            }

            entity.Name = district.Name;
            entity.Code = district.Code;
            entity.AddressLine1 = district.AddressLine1;
            entity.AddressLine2 = district.AddressLine2;
            entity.State = district.State;
            entity.ZipCode = district.ZipCode;
            entity.Phone = district.Phone;
            entity.Email = district.Email;

            entity.City = district.City;
            entity.AdministratorName = district.AdministratorName;
            entity.EsdCode = district.EsdCode;
            entity.EsdName = district.EsdName;

            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/<DistrictsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<District>> Delete(int id)
        {
            if(id == null)
            {
                return BadRequest();
            }

            var entity = await _dbContext.Districts.FindAsync(id);

            if (entity == null)
            {
                return NotFound();
            }

            _dbContext.Districts.Remove(entity);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
