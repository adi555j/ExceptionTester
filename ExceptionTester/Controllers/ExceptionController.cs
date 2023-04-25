using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.ComponentModel;

namespace ExceptionTester.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExceptionController : Controller
    {
        [HttpGet]
        [Route("NotImplementedException")]
        public IActionResult Index()
        {
            throw new NotImplementedException();
            return View();
        }
        [HttpGet]
        [Route("InvalidCastException")]
        public IActionResult InvalidCastException()
        {
            throw new InvalidCastException();
            return View();
        }
        [HttpGet]
        [Route("InvalidOperationException")]
        public IActionResult InvalidOperationException()
        {
            throw new InvalidOperationException();
            return View();
        }

        [HttpGet]
        [Route("InvalidDataException")]
        public IActionResult InvalidDataException()
        {
            throw new InvalidDataException();
            return View();
        }

        [HttpGet]
        [Route("InvalidAsynchronousStateException")]
        public IActionResult InvalidAsynchronousStateException()
        {
            throw new InvalidAsynchronousStateException();
            return View();
        }

        [HttpGet]
        [Route("DivideByZero")]
        public IActionResult DivideByZero()
        {
            var y = 0;
            var x = 5 / y;
            return View();
        }
    }
}
