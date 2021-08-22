using System;
using System.Collections.Generic;
using ctbl.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ctbl.Data.Concrete.EntityFramework.Mappings
{
    public class ArticleMap:IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Title).HasMaxLength(100);
            builder.Property(a => a.Title).IsRequired();
            builder.Property(a => a.Content).IsRequired();
            builder.Property(a => a.Content).HasColumnType("NVARCHAR(MAX)");
            builder.Property(a => a.Date).IsRequired();
            builder.Property(a => a.SeoAuthor).IsRequired();
            builder.Property(a => a.SeoAuthor).HasMaxLength(50);
            builder.Property(a => a.SeoDescription).HasMaxLength(150);
            builder.Property(a => a.SeoDescription).IsRequired();
            builder.Property(a => a.SeoTags).IsRequired();
            builder.Property(a => a.SeoTags).HasMaxLength(70);
            builder.Property(a => a.ViewsCount).IsRequired(); 
            builder.Property(a => a.CommentCount).IsRequired();
            builder.Property(a => a.Thumbnail).IsRequired();
            builder.Property(a => a.Thumbnail).HasMaxLength(250);
            builder.Property(a => a.CreatedBy).IsRequired();
            builder.Property(a => a.CreatedBy).HasMaxLength(50); 
            builder.Property(a => a.ModifiedBy).IsRequired(); 
            builder.Property(a => a.ModifiedBy).HasMaxLength(50);
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.Note).HasMaxLength(500);
    
            builder.HasOne<Category>(a => a.Category).WithMany(c => c.Articles).HasForeignKey(a=>a.CategoryId);
            builder.HasOne<User>(a => a.User).WithMany(u => u.Articles).HasForeignKey(a => a.UserId);
            builder.ToTable("Articles");
            builder.HasData(new Article
            {
                Id = 1,
                CategoryId = 1,
                Title = "C# Testing article",
                Content =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." +
                    " Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Thumbnail = "Default.jpg",
                SeoDescription = "C# Testing article",
                SeoTags = "C#,Javascript,.NetCore,.Net,.NetFramework",
                SeoAuthor = "ulasdev",
                Date = DateTime.Now,
                IsActive = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
                ModifiedBy = "InitialCreate",
                ModifiedDate = DateTime.Now,
                CreatedBy = "InitialCreate",
                Note = "C# article",
                UserId = 1,
                ViewsCount = 100,
                CommentCount = 1


            }, new Article
            {
                Id = 2,
                CategoryId = 2,
                Title = "C++ Testing article",
                Content =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." +
                    " Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Thumbnail = "Default.jpg",
                SeoDescription = "C++ Testing article",
                SeoTags = "C#,Javascript,.NetCore,.Net,.NetFramework",
                SeoAuthor = "ulasdev",
                Date = DateTime.Now,
                IsActive = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
                ModifiedBy = "InitialCreate",
                ModifiedDate = DateTime.Now,
                CreatedBy = "InitialCreate",
                Note = "C++ article",
                UserId = 1,
                ViewsCount = 123,
                CommentCount = 1
            }, new Article
            {
                Id = 3,
                CategoryId = 3,
                Title = "Javascript Testing article",
                Content =
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." +
                    " Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Thumbnail = "Default.jpg",
                SeoDescription = "Javascript Testing article",
                SeoTags = "C#,Javascript,.NetCore,.Net,.NetFramework",
                SeoAuthor = "ulasdev",
                Date = DateTime.Now,
                IsActive = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
                ModifiedBy = "InitialCreate",
                ModifiedDate = DateTime.Now,
                CreatedBy = "InitialCreate",
                Note = "Javascript article",
                UserId = 1,
                ViewsCount = 150,
                CommentCount = 1

            });
        }
    }
}