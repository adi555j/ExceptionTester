using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace ExceptionTester.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExceptionController : Controller
    {
        private readonly ILogger<ExceptionController> _logger;
        public ExceptionController(ILogger<ExceptionController> logger) 
        {
            _logger = logger;
        }
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

        //simpley threw the exception which was caught by appD
        [HttpGet]
        [Route("DivideByZero")]
        public IActionResult DivideByZero()
        {
            var y = 0;
            var x = 5 / y;
            return View();
        }

        [HttpGet]
        [Route("DivideByZeroTryCatchWithLogger")]
        public IActionResult DivideByZeroTryCatchWithLogger()
        {
            try
            {
                var y = 0;
                var x = 5 / y;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
            }

            return View();
        }

        [HttpGet]
        [Route("DivideByZeroTryCatch")]
        public IActionResult DivideByZeroTryCatch()
        {
            try
            {
                var y = 0;
                var x = 5 / y;
            }
            catch (Exception ex)
            {
                
            }

            return View();
        }


        [HttpGet]
        [Route("DivideByZeroTryCatchThrowException")]
        public IActionResult DivideByZeroTryCatchThrowException()
        {
            try
            {
                var y = 0;
                var x = 5 / y;
            }
            catch (Exception ex)
            {
                throw new DivideByZeroException();
            }

            return View();
        }
    }
}
