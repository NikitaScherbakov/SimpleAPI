using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController
    {
        [HttpGet("{id:int}")]
        public ActionResult<string> Get(int id)
        {
            return "Les Jackson";
        }
    }
}