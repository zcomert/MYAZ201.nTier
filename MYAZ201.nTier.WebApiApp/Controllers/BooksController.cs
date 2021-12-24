using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MYAZ201.nTier.Business.Interfaces;

namespace MYAZ201.nTier.WebApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _bookService.GetAll();
            return Ok(result.Data);
        }
    }
}
