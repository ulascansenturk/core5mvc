using System.Collections.Generic;
using System.Threading.Tasks;
using ctbl.Entities.Concrete;
using ctbl.Entities.Dtos.ArticleDtos;
using ctbl.Entities.Dtos.CategoryDtos;
using ctbl.Shared.Utilities.Results.Abstract;

namespace ctbl.Services.Abstract
{
    public interface IArticleService
    {
        
        Task<IDataResult<ArticleDto>> Get(int articleyId);
        Task<IDataResult<ArticleListDto>> GetAll();
        Task<IDataResult<ArticleListDto>> GetAllByNonDeleted();
        Task<IDataResult<ArticleListDto>> GetAllByNonDeletedAndActive(int articleId);
        Task<IDataResult<ArticleListDto>> GetAllByCategory(int articleId);

        Task<IResult> Add(ArticleAddDto articleAddDto, string createdBy);
        Task<IResult> Update(ArticleUpdateDto  articleUpdateDto,string modifiedBy);
        Task<IResult> Delete(int articleId,string modifiedBy);
        Task<IResult> HardDelete(int articleId);
     }
}