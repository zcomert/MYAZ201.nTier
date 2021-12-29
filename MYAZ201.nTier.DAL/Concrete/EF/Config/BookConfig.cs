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
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(b => b.CreatedDate)
                .HasDefaultValueSql("GETDATE()");

            builder.Property(b => b.ImageURL)
                .HasDefaultValue("/images/default.jpg");

            builder.HasData(
                new Book { BookId = 1, Title = "Yazılım Evi", CategoryId = 1, ImageURL= "yazilimEvi.png" },
                new Book { BookId = 2, Title = "Nesne Yönelimli Programlama", CategoryId = 1, ImageURL= "nesneYonelimliProgramlama.png" },
                new Book { BookId = 3, Title = "Yazılım Gereksinimi ve Modelleme", CategoryId = 1, ImageURL= "myaz201.png" }
            );

            builder.HasOne(b => b.Category)
                .WithMany(c => c.Books)
                .HasForeignKey(b => b.CategoryId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
