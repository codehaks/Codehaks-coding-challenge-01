using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class BookController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateBook()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult RemoveBook()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateBook()
        {
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetBook(Guid id)
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok();
        }
    }
}
