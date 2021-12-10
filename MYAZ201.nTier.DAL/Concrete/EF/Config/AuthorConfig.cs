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

            builder.Property(a => a.FirstName)
                .IsRequired();

            builder.Property(a => a.LastName)
                .IsRequired();

            builder.Ignore(a => a.FullName);

            builder.Property(a => a.CreatedDate)
                .HasDefaultValue(DateTime.Now);

            builder.HasData(
                new Author
                {
                    AuthorId=1,
                    FirstName = "Chinua",
                    LastName = "Achebe"
                },
                new Author
                {
                    AuthorId = 2,
                    FirstName = "Hans Christian",
                    LastName = "Andersen"
                },
                new Author
                {
                    AuthorId = 3,
                    FirstName = "Dante",
                    LastName = "Alighieri"
                }
            );
        }
    }
}
