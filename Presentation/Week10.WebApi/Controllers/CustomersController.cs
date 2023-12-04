using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week10.Infrastructure.Services;

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
            ConfigurationService.GetInstance().GetValue(name);
        }
    }
}
