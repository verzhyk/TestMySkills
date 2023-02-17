using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestMySkills.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        protected ApplicationContext _context = new ApplicationContext();
        [HttpGet]
        public List<Project> Get()
        {
            return _context.Projects.ToList();
        }
        [HttpPost]
        public Project Post(Project project)
        {
            return project;
        }

    }
}
