using Microsoft.AspNetCore.Mvc;
using MYAZ201.nTier.Business.Interfaces;
using MYAZ201.nTier.Business.Services;
using MYAZ201.nTier.DAL.Concrete.EF;

namespace MYAZ201.nTier.MVCApp.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            var result = _bookService.GetAll();
            if (result.Success)
            {
                return View(result.Data);
            }
            return View();
        }
    }
}
