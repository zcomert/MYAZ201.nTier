using CsvHelper;
using CsvHelper.Configuration;
using MYAZ201.nTier.DAL.Concrete.EF;
using MYAZ201.nTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;

namespace MYAZ201.BookCSVImporter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                NewLine = Environment.NewLine
            };

            using (var reader = new StreamReader(Path.Combine("D:","DataSources","EditedBook","books.csv")))
            using (var csv = new CsvReader(reader,CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<BookCsv>();
                
                var context = new nTierBookDbContext();

                foreach (var item in records)
                {
                    var book = new Book
                    {
                        Title = item.Title,
                        Price = item.NumberOfPage * 125,
                        ImageURL = item.ImageURL,
                        CategoryId = 2,
                        BookDetail = new BookDetail
                        {
                            Description = item.Description,
                            Language = item.Language,
                            Country = item.Country,
                            Year = item.Year,
                            NumberOfPage = item.NumberOfPage,
                            Link = item.Link
                        },
                        BookAuthors = new List<BookAuthor>
                        {
                            new BookAuthor
                            {
                                Author = context.Authors.Where(a => a.FullName.Equals(item.Author)).Any() ?
                                         context.Authors.Where(a => a.FullName.Equals(item.Author)).FirstOrDefault() :
                                         new Author {FullName = item.Author},
                            }
                        }
                    };
                    context.Add(book);
                }
                context.SaveChanges();
            }
            Console.WriteLine("Importing has been completed.");
            Console.ReadKey();
        }
    }
}
