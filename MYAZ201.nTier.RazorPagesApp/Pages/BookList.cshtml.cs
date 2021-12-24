using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MYAZ201.nTier.Business.Interfaces;
using MYAZ201.nTier.DAL.Entities;
using System.Collections.Generic;

namespace MYAZ201.nTier.RazorPagesApp.Pages
{
    public class BookListModel : PageModel
    {
        public List<Book> BookList { get; set; }

        private readonly IBookService _bookService;

        public BookListModel(IBookService bookService)
        {
            _bookService = bookService;
        }

        public void OnGet()
        {
            var result = _bookService.GetAll();
            if (result.Success)
            {
                BookList = result.Data;
            }
            else
            {
                BookList = new List<Book>();
            }
            
        }
    }
}
