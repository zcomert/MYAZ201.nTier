using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MYAZ201.nTier.DAL.Entities;
using System;

namespace MYAZ201.nTier.DAL.Concrete.EF.Config
{
    public class AuthorConfig : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a => a.AuthorId);

            builder.Property(a => a.CreatedDate)
                .HasDefaultValueSql("GETDATE()");

            builder.HasData(
                new Author
                {
                    AuthorId = 1,
                    FullName = "Zafer CÖMERT"
                },
                new Author
                {
                    AuthorId = 2,
                    FullName = "Ahmet Can"
                },
                new Author
                {
                    AuthorId = 3,
                    FullName = "Fatih Mehmet Çelik"
                }
            );
        }
    }
}
