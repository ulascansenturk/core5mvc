using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AutoMapper;
using ctbl.Data.Abstract;
using ctbl.Entities.Concrete;
using ctbl.Entities.Dtos.ArticleDtos;
using ctbl.Services.Abstract;
using ctbl.Shared.Utilities.Results.Abstract;
using ctbl.Shared.Utilities.Results.ComplexTypes;
using ctbl.Shared.Utilities.Results.Concrete;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ctbl.Services.Concrete
{
    public class ArticleManager:IArticleService
    {
        
        private readonly IMapper _mapper;
        public ArticleManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
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

        public async Task<IResult> Add(ArticleAddDto articleAddDto, string createdBy)
        {
            var article = _mapper.Map<Article>(articleAddDto);
            article.CreatedBy = createdBy;
            article.ModifiedBy = createdBy;
            article.UserId = 1;
            await _unitOfWork.Articles.AddAsync(article).ContinueWith(t => _unitOfWork.SaveAsync());
            return new Result(ResultStatus.Success, $"{articleAddDto.Title} baslikli makale basariyla eklenmistir");
            


        }

        public async Task<IResult> Update(ArticleUpdateDto articleUpdateDto, string modifiedBy)
        {
            var article = _mapper.Map<Article>(articleUpdateDto);
            article.ModifiedBy = modifiedBy;
            await _unitOfWork.Articles.UpdateAsync(article).ContinueWith(t => _unitOfWork.SaveAsync());
            
            return new Result(ResultStatus.Success, $"{articleUpdateDto.Title} baslikli makale basariyla eklenmistir");
            
        }
        

        public async Task<IResult> Delete(int articleId, string modifiedBy)
        {
            var result = await _unitOfWork.Articles.AnyAsync(a => a.Id == articleId);
            if (result)
            {
                var article = await _unitOfWork.Articles.GetAsync(a => a.Id == articleId);
                article.IsDeleted = true;
                article.ModifiedBy = modifiedBy;
                article.ModifiedDate = DateTime.Now;
                await _unitOfWork.Articles.UpdateAsync(article).ContinueWith(t => _unitOfWork.SaveAsync());
                
            return new Result(ResultStatus.Success, $"{article.Title} baslikli makale basariyla silinmistir" );
            }
            
            return new Result(ResultStatus.Error, "Boyle bir makale bulunamadi");
        }

        public async Task<IResult> HardDelete(int articleId)
        {
            
            var result = await _unitOfWork.Articles.AnyAsync(a => a.Id == articleId);
            if (result)
            {
                var article = await _unitOfWork.Articles.GetAsync(a => a.Id == articleId);
                await _unitOfWork.Articles.DeleteAsync(article).ContinueWith(t => _unitOfWork.SaveAsync());
                
            return new Result(ResultStatus.Success, $"{article.Title} baslikli makale basariyla veritabanindan silinmistir ");
            }
            
            return new Result(ResultStatus.Error, "Boyle bir makale bulunamadi");
        }
    }
}
