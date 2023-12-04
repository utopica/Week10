using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Week10.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        public CustomersController() { }

        [HttpGet]
        public void Get(string name)
        {
            //ConfigurationService.GetInstance().GetValue(name);
        }
    }
}
