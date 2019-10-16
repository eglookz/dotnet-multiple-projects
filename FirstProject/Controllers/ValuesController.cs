using Microsoft.AspNetCore.Mvc;
using SecondProject;

namespace FirstProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return new Class1().GetString();
        }
    }
}
