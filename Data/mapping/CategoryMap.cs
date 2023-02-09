using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings{

    public class CategoryMap : IEntityTypeConfiguration<CategoryMap>
    {
        public void Configure(EntityTypeBuilder<CategoryMap> builder)
        {
          builder.ToTable("Category");
        }
    }

}
