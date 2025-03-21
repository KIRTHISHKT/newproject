using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController: ControllerBase
    {
        public string data;

        [HttpGet]
        public string get() {
            return data; // StyleCop violation: public field
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
            data=value;
        }
    }
}