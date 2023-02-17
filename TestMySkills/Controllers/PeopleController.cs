using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestMySkills.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        protected ApplicationContext _context = new ApplicationContext();
        [HttpGet]
        public List<Person> Get()
        {
            return _context.People.ToList();
        }
    }
}
