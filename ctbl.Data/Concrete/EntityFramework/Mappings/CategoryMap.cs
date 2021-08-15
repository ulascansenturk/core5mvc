using ctbl.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ctbl.Data.Concrete.EntityFramework.Mappings
{
    public class CategoryMap:IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Name).HasMaxLength(50);
            builder.Property(c => c.Description).HasMaxLength(500);
            builder.Property(c => c.CreatedBy).IsRequired();
            builder.Property(c=> c.CreatedBy).HasMaxLength(50); 
            builder.Property(c=> c.ModifiedBy).IsRequired(); 
            builder.Property(c=> c.ModifiedBy).HasMaxLength(50);
            builder.Property(c=> c.IsActive).IsRequired();
            builder.Property(c=> c.IsDeleted).IsRequired();
            builder.Property(c=> c.Note).HasMaxLength(500);


            builder.ToTable("Categories");
            
            
        }
        
    }
        
    }
    

    
                                