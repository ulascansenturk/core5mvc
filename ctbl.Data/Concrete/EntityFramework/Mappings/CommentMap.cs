using System;
using ctbl.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ctbl.Data.Concrete.EntityFramework.Mappings
{
    public class CommentMap:IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Text).IsRequired();
            builder.Property(c => c.Text).HasMaxLength(1000);
            builder.HasOne<Article>(c => c.Article).WithMany(a => a.Comments).HasForeignKey(c => c.ArticleId);
            builder.Property(c => c.CreatedBy).IsRequired();
            builder.Property(c => c.CreatedBy).HasMaxLength(50); 
            builder.Property(c => c.ModifiedBy).IsRequired(); 
            builder.Property(c => c.ModifiedBy).HasMaxLength(50);
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c=> c.Note).HasMaxLength(500);

            builder.ToTable("Comments");
            builder.HasData(new Comment
            {
                Id = 1,
                ArticleId = 1,
                Text =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." +
                    " Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                IsActive = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
                ModifiedBy = "InitialCreate",
                ModifiedDate = DateTime.Now,
                CreatedBy = "InitialCreate",
                Note = "C# comment"
            }, new Comment
            {
                Id = 2,
                ArticleId = 2,
                Text =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." +
                    " Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                IsActive = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
                ModifiedBy = "InitialCreate",
                ModifiedDate = DateTime.Now,
                CreatedBy = "InitialCreate",
                Note = "C++ comment"
            }, new Comment
            {
                Id = 3,
                ArticleId = 3,
                Text =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." +
                    " Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                IsActive = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
                ModifiedBy = "InitialCreate",
                ModifiedDate = DateTime.Now,
                CreatedBy = "InitialCreate",
                Note = "Javascript comment"
            });
        }
    }
}