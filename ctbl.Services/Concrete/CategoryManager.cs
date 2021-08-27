using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Threading.Tasks;
using AutoMapper;
using ctbl.Data.Abstract;
using ctbl.Entities.Concrete;
using ctbl.Entities.Dtos.CategoryDtos;
using ctbl.Services.Abstract;
using ctbl.Shared.Utilities.Results.Abstract;
using ctbl.Shared.Utilities.Results.ComplexTypes;
using ctbl.Shared.Utilities.Results.Concrete;

namespace ctbl.Services.Concrete
{
    public class CategoryManager : ICategoryService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }



        public async Task<IDataResult<CategoryDto>> Get(int categoryId)
        {
            var category = await _unitOfWork.Categories.GetAsync(c => c.Id == categoryId, c => c.Articles);
            if (category != null)
            {
                return new DataResult<CategoryDto>(ResultStatus.Success, new CategoryDto()
                {
                    Category = category,
                    ResultStatus = ResultStatus.Success
                });
            }

            return new DataResult<CategoryDto>(ResultStatus.Error, "Kategori bulunamadi", null);


        }

        public async Task<IDataResult<CategoryListDto>> GetAll()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(null, c => c.Articles);
            if (categories.Count > -1)
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto()
                {
                    Categories = categories,
                    ResultStatus = ResultStatus.Success
                });
            }

            {
                return new DataResult<CategoryListDto>(ResultStatus.Error, "Kategori bulunamadi", null);
            }
        }

        public async Task<IDataResult<CategoryListDto>> GetAllByNonDeleted()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(c => !c.IsDeleted, c => c.Articles);

            if (categories.Count > -1)
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto()
                {
                    Categories = categories,
                    ResultStatus = ResultStatus.Success
                });
            }

            {
                return new DataResult<CategoryListDto>(ResultStatus.Error, "Kategori bulunamadi", null);

            }

        }

        public async Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAndActive()
        {
            
            var categories = await _unitOfWork.Categories.GetAllAsync(c => !c.IsDeleted && c.IsActive);
            
            if (categories.Count > -1 )
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto()
                {
                    Categories = categories,
                    ResultStatus = ResultStatus.Success
                });
            }
            
            return new DataResult<CategoryListDto>(ResultStatus.Error, " makaleler bulunamadi", null); 
        }

        public async Task<IResult> Add(CategoryAddDto categoryAddDto, string createdBy)
        {
            var category = _mapper.Map<Category>(categoryAddDto);
            category.CreatedBy = createdBy;
            category.ModifiedBy = createdBy;
            await  _unitOfWork.Categories.AddAsync(category).ContinueWith(t => _unitOfWork.SaveAsync());
            return new Result(ResultStatus.Success, $"{categoryAddDto.Name} isimli kategori eklenmistir");
        }

        public async Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifiedBy)
        {
            var category = _mapper.Map<Category>(categoryUpdateDto);
            category.ModifiedBy = modifiedBy;
            category.ModifiedDate = DateTime.Now;
            
 
            await _unitOfWork.Categories.UpdateAsync(category).ContinueWith(t => _unitOfWork.SaveAsync());
            return new Result(ResultStatus.Success, $"{categoryUpdateDto.Name} isimli kategori eklenmistir");
            
        }
        public async  Task<IResult> Delete(int categoryId, string modifiedBy)
        {
            var category = await _unitOfWork.Categories.GetAsync(c => c.Id == categoryId);
            if (category !=null)
            {
                category.IsDeleted = true;
                category.ModifiedBy = modifiedBy;
                category.ModifiedDate = DateTime.Now;
                
            await _unitOfWork.Categories.UpdateAsync(category).ContinueWith(t => _unitOfWork.SaveAsync());
            return new Result(ResultStatus.Success, $"{category.Name} isimli kategori silinmistir");
            
            }

            return new Result(ResultStatus.Error, "Boyle bir kategori bulunamamistir");
        }

        public async Task<IResult> HardDelete(int categoryId)
        {
             var category = await _unitOfWork.Categories.GetAsync(c => c.Id == categoryId);
             if (category !=null)
             { 
                 
                 await _unitOfWork.Categories.DeleteAsync(category).ContinueWith(t => _unitOfWork.SaveAsync());
                 return new Result(ResultStatus.Success, $"{category.Name} isimli kategori veritbanindan silinmistir");
             
             }
 
             return new Result(ResultStatus.Error, "Boyle bir kategori bulunamamistir");
  
        }
        
    }

    
    }