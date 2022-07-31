using DirectoryWebApi.Models.Entities;
using DirectoryWebApi.Models.Resources;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

/**
 * This is the Schools Controller
 * This is designed with REST api in mind.
**/

namespace DirectoryWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolsController : ControllerBase
    {
        private readonly DirectoryApiDbContext _dbContext;

        public SchoolsController(DirectoryApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/<SchoolsController>
        [HttpGet(Name = nameof(GetSchools))]
        public async Task<ActionResult<IEnumerable<School>>> GetSchools()
        {
            var entities = await _dbContext.Schools.ToListAsync();

            if(entities == null)
            {
                return NotFound();
            }

            List<School> schools = new List<School>();
            foreach (var entity in entities)
            {
                schools.Add(new School(entity));
            }

            return schools;
        }

        // GET api/<SchoolsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<School>> GetSchool(int id)
        {
            var entity = await _dbContext.Schools.FindAsync(id);

            if(entity == null)
            {
                return BadRequest();
            }

            return new School(entity);
           
        }

        // POST api/<SchoolsController>
        [HttpPost]
        public async Task<ActionResult<School>> CreateSchool(School school)
        {
            var entity = new SchoolEntity(school);

            if(entity == null)
            {
                return BadRequest();
            }

            var createdSchool = await _dbContext.Schools.AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSchool), new {id = entity.Id}, school);

        }

        // PUT api/<SchoolsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<School>> UpdateSchool(int id, School school)
        {
            if(id == null)
            {
                return BadRequest();
            }

            var entity = await _dbContext.Schools.FindAsync(id);

            if(entity == null)
            {
                return NotFound();
            }

            entity.Name = school.Name;
            entity.Code = school.Code;
            entity.AddressLine1 = school.AddressLine1;
            entity.AddressLine2 = school.AddressLine2;
            entity.State = school.State;
            entity.ZipCode = school.ZipCode;
            entity.Phone = school.Phone;
            entity.Email = school.Email;

            entity.PrincipalName = school.PrincipalName;
            entity.City = school.City;
            entity.EsdCode = school.EsdCode;
            entity.EsdName = school.EsdName;
            entity.LeaCode = school.LeaCode;
            entity.LeaName = school.LeaName;
            entity.AypCode = school.AypCode;
            entity.GradeCategory = school.GradeCategory;
            entity.OrgCategoryList = school.OrgCategoryList;
            entity.HighestGrade = school.HighestGrade;
            entity.LowestGrade = school.LowestGrade;

            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/<SchoolsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<School>> Delete(int id)
        {
            if(id == null)
            {
                return BadRequest();
            }

            var entity = await _dbContext.Schools.FindAsync(id);

            if (entity == null)
            {
                return NotFound();
            }

            _dbContext.Schools.Remove(entity);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
