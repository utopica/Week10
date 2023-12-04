using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Week10.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public ValuesController() { }

        [HttpGet]
        public void Get(string name)
        {
            //ConfigurationService.GetInstance().GetValue(name);
        }
    }
}
