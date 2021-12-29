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

            var book = new Book
            {
                Title ="C#",
                Price = 120
            };

            var result = _bookService.Add(book);
            
            if (!result.Success)
            {
                Console.WriteLine(result.Message);
                foreach (var err in result.Errors)
                {
                    Console.WriteLine(err.Message);
                }
            }
            else
            {
                Console.WriteLine("Ok...");
            }
            
            
            
            Console.ReadLine();
        }
    }
}
