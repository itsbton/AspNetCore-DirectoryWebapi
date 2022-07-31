using Microsoft.AspNetCore.Mvc;

namespace DirectoryWebApi.Controllers
{
    [Route("api/")]
    [ApiController]
    public class RootController : Controller
    {
        [HttpGet(Name = nameof(GetRoot))]
        public ActionResult GetRoot()
        {
            var response = new
            {
                href = Url.Link(nameof(GetRoot), null),
                esds = new
                {
                    href = Url.Link(nameof(EsdsController.GetEsds), null)
                },
                districts  = new
                {
                    href = Url.Link(nameof(DistrictsController.GetDistricts), null)
                },
                schools = new
                {
                    href = Url.Link(nameof(SchoolsController.GetSchools),null)
                }
            };

            return Ok(response);
        }
    }
}
