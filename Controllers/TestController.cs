using System.Collections.Generic;
using Microsoft.AspNet.Mvc;

namespace ASPNET5_EF7_Test.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        private readonly TestContext _testContext;
        public TestController(TestContext testContext)
        {
            _testContext = testContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { _testContext.Users });
        }
    }
}
