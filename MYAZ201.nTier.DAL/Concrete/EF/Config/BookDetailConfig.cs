using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MYAZ201.nTier.DAL.Entities;
using System;

namespace MYAZ201.nTier.DAL.Concrete.EF.Config
{
    public class BookDetailConfig : IEntityTypeConfiguration<BookDetail>
    {
        public void Configure(EntityTypeBuilder<BookDetail> builder)
        {
            builder.HasKey(bd => bd.BookDetailId);

            builder.Property(bd => bd.ISSN)
                .HasDefaultValue("0000-0000-0000");

            builder.Property(bd => bd.Year)
                .HasDefaultValue(DateTime.Now.Year);

            builder.HasOne(bd => bd.Book)
                .WithOne(b => b.BookDetail)
                .HasForeignKey<BookDetail>(bd => bd.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new BookDetail
                {
                    BookDetailId=1,
                    BookId=1,
                    Year=1958
                },
                new BookDetail
                {
                    BookDetailId = 2,
                    BookId = 2,
                    Year = 1836
                },
                new BookDetail
                {
                    BookDetailId = 3,
                    BookId = 3,
                    Year = 1315
                }
            );
        }
    }
}
