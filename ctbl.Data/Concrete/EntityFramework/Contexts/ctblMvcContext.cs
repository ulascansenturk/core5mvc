using ctbl.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ctbl.Data.Concrete.EntityFramework.Contexts
{
    public class ctblMvcContext:DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Comment> Comments { get; set; } 
        public DbSet<Role>  Roles{ get; set; }
        public DbSet<User> Users{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=ctblBlog;User Id=sa;Password=yourStrong(!)Password");
        }
        
    }
}