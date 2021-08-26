using System.Threading.Tasks;
using ctbl.Data.Abstract;
using ctbl.Entities.Concrete;
using ctbl.Entities.Dtos.ArticleDtos;
using ctbl.Services.Abstract;
using ctbl.Shared.Utilities.Results.Abstract;
using ctbl.Shared.Utilities.Results.ComplexTypes;
using ctbl.Shared.Utilities.Results.Concrete;

namespace ctbl.Services.Concrete
{
    public class ArticleManager:IArticleService
    {
        public ArticleManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        private readonly IUnitOfWork _unitOfWork;
        
        public async Task<IDataResult<ArticleDto>> Get(int articleId)
        {
            var article = await _unitOfWork.Articles.GetAsync(a => a.Id == articleId, a => a.User, a => a.Category);

            if (article !=null)
            {
                return new DataResult<ArticleDto>(ResultStatus.Success, new ArticleDto
                {
                    Article = article,
                    ResultStatus = ResultStatus.Success
                });
            }

            return new DataResult<ArticleDto>(ResultStatus.Error, "Boyle bir makale bulunamadi", null); 
        }
        

        public async Task<IDataResult<ArticleListDto>> GetAll()
        {
            var articles  = await _unitOfWork.Articles.GetAllAsync(null, a=> a.User,a=> a.Category);
            if (articles.Count>-1)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto()
                {
                    Articles = articles,
                    ResultStatus = ResultStatus.Success
                });
            }
            
            return new DataResult<ArticleListDto>(ResultStatus.Error, " makaleler bulunamadi", null); 
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByNonDeleted()
        {
            var articles = await _unitOfWork.Articles.GetAllAsync(a => !a.IsDeleted, ar => ar.User, ar => ar.Category);
            
            if (articles.Count > -1)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto()
                {
                    Articles = articles,
                    ResultStatus = ResultStatus.Success
                });
            }
            
            return new DataResult<ArticleListDto>(ResultStatus.Error, " makaleler bulunamadi", null); 
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByNonDeletedAndActive(int categoryId)
        {
            var articles = await _unitOfWork.Articles.GetAllAsync(a => !a.IsDeleted && a.IsActive, ar => ar.User, ar=> ar.Category);
            
            if (articles.Count > -1 )
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto()
                {
                    Articles = articles,
                    ResultStatus = ResultStatus.Success
                });
            }
            
            return new DataResult<ArticleListDto>(ResultStatus.Error, " makaleler bulunamadi", null); 
        }

        public  async Task<IDataResult<ArticleListDto>> GetAllByCategory(int categoryId)
        {
            var result = await _unitOfWork.Categories.AnyAsync(c => c.Id == categoryId);
            if (result)
            {
            var articles = await _unitOfWork.Articles.GetAllAsync(
                a => a.CategoryId == categoryId && !a.IsDeleted && a.IsActive, ar => ar.User, ar => ar.Category);
                
            if (articles.Count > -1 )
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto()
                {
                    Articles = articles,
                    ResultStatus = ResultStatus.Success
                });
            }
            
            return new DataResult<ArticleListDto>(ResultStatus.Error, " makaleler bulunamadi", null); 
            } 
            return new DataResult<ArticleListDto>(ResultStatus.Error, " Boyle bir kategori bulunamadi", null); 
            
        }

        public Task<IResult> Add(ArticleAddDto articleAddDto, string createdBy)
        {
            throw new System.NotImplementedException();
        }

        public Task<IResult> Update(ArticleUpdateDto articleUpdateDto, string modifiedBy)
        {
            throw new System.NotImplementedException();
        }

        public Task<IResult> Delete(int articleId, string modifiedBy)
        {
            throw new System.NotImplementedException();
        }

        public Task<IResult> HardDelete(int articleId)
        {
            throw new System.NotImplementedException();
        }
    }
}