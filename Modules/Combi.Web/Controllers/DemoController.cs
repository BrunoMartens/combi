using Combi.Domain.Entities;
using Combi.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Combi.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly IDemoService _demoService;

        public DemoController(IDemoService demoService)
        {
            _demoService = demoService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Demo>> GetDemos()
        {
            return Ok(_demoService.GetAll());
        }
    }
}
