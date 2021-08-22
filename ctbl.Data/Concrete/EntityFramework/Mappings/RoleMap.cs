using System;
using ctbl.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ctbl.Data.Concrete.EntityFramework.Mappings
{
    public class RoleMap:IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedOnAdd();
            builder.Property(r => r.Name).IsRequired();
            builder.Property(r => r.Name).HasMaxLength(50);
            builder.Property(r => r.Description).IsRequired();
            builder.Property(r => r.Description).HasMaxLength(250);
            builder.Property(r => r.CreatedBy).IsRequired();
            builder.Property(r => r.CreatedBy).HasMaxLength(50); 
            builder.Property(r => r.ModifiedBy).IsRequired(); 
            builder.Property(r => r.ModifiedBy).HasMaxLength(50);
            builder.Property(r => r.IsActive).IsRequired();
            builder.Property(r => r.IsDeleted).IsRequired();
            builder.Property(r => r.Note).HasMaxLength(500);

            builder.ToTable("Roles");

            builder.HasData(new Role
            {
                Id = 1,
                Name = "Root",
                Description = "Root privilige",
                IsActive = true,
                IsDeleted = false,
                CreatedBy = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedBy = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "Root User"
            });
        }
    }
}