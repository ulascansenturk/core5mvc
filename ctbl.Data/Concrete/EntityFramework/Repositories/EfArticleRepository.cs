using ctbl.Data.Abstract;
using ctbl.Entities.Concrete;
using ctbl.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace ctbl.Data.Concrete.EntityFramework.Repositories
{
    public class EfArticleRepository:EfEntityRepositoryBase<Article>,IArticleRepository
    {
        public EfArticleRepository(DbContext context) : base(context)
        {
        }
        
    }
}