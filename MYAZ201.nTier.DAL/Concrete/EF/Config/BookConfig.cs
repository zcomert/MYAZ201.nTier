using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MYAZ201.nTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ201.nTier.DAL.Concrete.EF.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.BookId);

            builder.Property(b => b.Title)
                .IsRequired();

            builder.Property(b => b.Price)
                .HasDefaultValue(0);

            builder.Property(b => b.CreatedDate)
                .HasDefaultValue(DateTime.Now);

            builder.HasOne(b => b.Category)
                .WithMany(c => c.Books)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasData(
                new Book
                {
                    BookId=1,
                    Title = "Things Fall Apart",
                    ImageURL = "things-fall-apart.jpg",
                    CategoryId = 1,
                },
                new Book
                {
                    BookId = 2,
                    Title = "Fairy tales",
                    ImageURL = "fairy-tales.jpg",
                    CategoryId = 1
                },
                new Book
                {
                    BookId = 3,
                    Title = "The Divine Comedy",
                    ImageURL = "the-divine-comedy.jpg",
                    CategoryId = 1
                }
            );
        }
    }
}
