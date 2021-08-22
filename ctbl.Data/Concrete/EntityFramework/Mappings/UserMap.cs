using System;
using System.Text;
using ctbl.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ctbl.Data.Concrete.EntityFramework.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Property(u => u.EmailAdress).IsRequired();
            builder.Property(u => u.EmailAdress).HasMaxLength(50);
            builder.HasIndex(u => u.EmailAdress).IsUnique();
            builder.Property(u => u.Username).IsRequired();
            builder.Property(u => u.Username).HasMaxLength(20);
            builder.HasIndex(u => u.Username).IsUnique();
            builder.Property(u => u.PasswordHash).IsRequired();
            builder.Property(u => u.PasswordHash).HasColumnType("VARBINARY(500)");
            builder.Property(u => u.Description).HasMaxLength(500);
            builder.Property(u => u.FirstName).IsRequired();
            builder.Property(u => u.FirstName).HasMaxLength(30);
            builder.Property(u => u.LastName).IsRequired();
            builder.Property(u => u.LastName).HasMaxLength(30);
            builder.Property(u => u.Picture).IsRequired();
            builder.Property(u => u.Picture).HasMaxLength(250);
            builder.Property(r => r.CreatedBy).IsRequired();
            builder.Property(r => r.CreatedBy).HasMaxLength(50); 
            builder.Property(r => r.ModifiedBy).IsRequired(); 
            builder.Property(r => r.ModifiedBy).HasMaxLength(50);
            builder.Property(r => r.IsActive).IsRequired();
            builder.Property(r => r.IsDeleted).IsRequired();
            builder.Property(r => r.Note).HasMaxLength(500);


            builder.HasOne<Role>(u => u.Role).WithMany(r => r.Users).HasForeignKey(u => u.RoleId);
            builder.ToTable("Users");

            builder.HasData(new User
            {
                Id = 1,
                RoleId = 1,
                 FirstName = "Ulas",
                 LastName = "Senturk",
                 Username = "ulasdev",
                 EmailAdress = "ulascansenturk@hotmail.com",
                IsActive = true,
                IsDeleted = false,
                CreatedBy = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedBy = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Description = "First root user",
                Note = "Root user",
                PasswordHash =Encoding.ASCII.GetBytes("95f44e0321ed96ba9d2961a54daab05e"),
                Picture ="User.jpg" 
                    
                    
                    
                
            });
        }
    }
}