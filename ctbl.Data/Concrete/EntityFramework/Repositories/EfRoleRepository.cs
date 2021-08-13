using ctbl.Data.Abstract;
using ctbl.Entities.Concrete;
using ctbl.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace ctbl.Data.Concrete.EntityFramework.Repositories
{
    public class EfRoleRepository:EfEntityRepositoryBase<Role>,IRoleRepository

    {
        public EfRoleRepository(DbContext context) : base(context)
        {
        }
    }
}