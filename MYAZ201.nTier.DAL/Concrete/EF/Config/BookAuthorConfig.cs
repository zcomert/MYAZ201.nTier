using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MYAZ201.nTier.DAL.Entities;
using System;
using System.Collections.Generic;

namespace MYAZ201.nTier.DAL.Concrete.EF.Config
{
    public class BookAuthorConfig : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.HasKey(ba => ba.BookAuthorId);

            builder
                .HasOne(ba => ba.Book)
                .WithMany(b => b.BookAuthors)
                .HasForeignKey(ba => ba.BookId);

            builder
                .HasOne(ba => ba.Author)
                .WithMany(a => a.BookAuthors)
                .HasForeignKey(ba => ba.AuthorId);

            builder
                .HasData(new List<BookAuthor>
                {
                    new BookAuthor{ BookAuthorId=1, BookId=1, AuthorId = 1 },
                    new BookAuthor{ BookAuthorId=2, BookId=2, AuthorId = 1 },
                    new BookAuthor{ BookAuthorId=3, BookId=3, AuthorId = 1 },
                });
        }
    }
}
