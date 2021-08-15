using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using ctbl.Data.Abstract;
using ctbl.Data.Concrete.EntityFramework.Contexts;
using ctbl.Data.Concrete.EntityFramework.Repositories;

namespace ctbl.Data.Concrete
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly ctblMvcContext _context;
        private EfArticleRepository _articleRepository;
        private EfCategoryRepository _categoryRepository;
        private EfCommentRepository _commentRepository;
        private EfRoleRepository _roleRepository;
        private EfUserRepository _userRepository;
        
        public UnitOfWork(ctblMvcContext context)
        {
            _context = context;
        }
       
        public IArticleRepository Articles => _articleRepository ?? new EfArticleRepository(_context);
        public ICategorRepository Categories => _categoryRepository?? new EfCategoryRepository(_context);
        public ICommentRepository Comments => _commentRepository ?? new EfCommentRepository(_context);
        public IRoleRepository Roles => _roleRepository ?? new EfRoleRepository(_context);
        public IUserRepository Users => _userRepository ?? new EfUserRepository(_context);
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
         public async  ValueTask DisposeAsync()
         {
             await _context.DisposeAsync();
        
         }

    }
}