using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Nikita";
        }
        
        [HttpGet("{id:int}")]
        public ActionResult<string> Get(int id)
        {
            return "Les Jackson";
        }
    }
}