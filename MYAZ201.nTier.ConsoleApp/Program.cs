using MYAZ201.nTier.Business.Services;
using MYAZ201.nTier.DAL.Concrete.EF;
using MYAZ201.nTier.DAL.Entities;
using System;

namespace MYAZ201.nTier.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _bookService = new BookService(new EfBookDal());
            var result = _bookService.GetAll();

            if (result.Success)
            {
                result
                    .Data
                    .ForEach(b => Console.WriteLine(b.Title));
            }
            
            Console.ReadLine();
        }
    }
}
