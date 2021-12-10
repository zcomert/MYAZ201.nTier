using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MYAZ201.nTier.DAL.Entities;

namespace MYAZ201.nTier.DAL.Concrete.EF.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId);

            builder.Property(c => c.CategoryName)
                .IsRequired();

            builder.HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName ="Action and Adventure"
                },
                new Category
                {
                    CategoryId=2,
                    CategoryName = "Classic"
                },
                new Category
                {
                    CategoryId =3,
                    CategoryName = "Computer Science"
                }
            );

        }
    }
}
