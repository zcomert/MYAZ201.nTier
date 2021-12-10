using MYAZ201.nTier.DAL.Concrete.EF;
using MYAZ201.nTier.DAL.Entities;
using System;

namespace MYAZ201.nTier.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Book
            {
                Title = "The Epic Of Gilgamesh",
                Price = 120,
                CategoryId = 1
            };

            var _bookDal = new EfBookDal();
            _bookDal.Add(book);

            _bookDal
                .GetAll()
                .ForEach(book =>
                        Console
                        .WriteLine(book.Title));

            Console.ReadLine();
        }
    }
}
