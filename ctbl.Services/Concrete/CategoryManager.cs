using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Threading.Tasks;
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

        public CategoryManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        public async Task<IDataResult<Category>> Get(int categoryId)
        {
            var category = await _unitOfWork.Categories.GetAsync(c => c.Id == categoryId, c => c.Articles);
            if (category != null)
            {
                return new DataResult<Category>(ResultStatus.Success, category);
            }

            return new DataResult<Category>(ResultStatus.Error, "Kategori bulunamadi", null);


        }

        public async Task<IDataResult<IList<Category>>> GetAll()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(null, c => c.Articles);
            if (categories.Count > -1)
            {
                return new DataResult<IList<Category>>(ResultStatus.Success, categories);
            }

            {
                return new DataResult<IList<Category>>(ResultStatus.Error, "Kategori bulunamadi", null);
            }
        }

        public async Task<IDataResult<IList<Category>>> GetAllByNonDeleted()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(c => !c.IsDeleted, c => c.Articles);

            if (categories.Count > -1)
            {
                return new DataResult<IList<Category>>(ResultStatus.Success, categories);
            }

            {
                return new DataResult<IList<Category>>(ResultStatus.Error, "Kategori bulunamadi", null);

            }

        }
       
        public async Task<IResult> Add(CategoryAddDto categoryAddDto, string createdBy)
        {
            await _unitOfWork.Categories.AddAsync(new Category()
            {
                Name = categoryAddDto.Name,
                Description = categoryAddDto.Description,
                Note = categoryAddDto.Note,
                IsActive = categoryAddDto.IsActive,
                CreatedBy = createdBy,
                CreatedDate = DateTime.Now,
                ModifiedBy = createdBy,
                ModifiedDate = DateTime.Now,
                IsDeleted = false
            }).ContinueWith(t => _unitOfWork.SaveAsync());
            return new Result(ResultStatus.Success, $"{categoryAddDto.Name} isimli kategori eklenmistir");
        }

        public async Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifiedBy)
        {
            var category = await _unitOfWork.Categories.GetAsync(c => c.Id == categoryUpdateDto.Id);
            if (category !=null)
            {
                category.Name = categoryUpdateDto.Name;
                category.Description = categoryUpdateDto.Description;
                category.Note = categoryUpdateDto.Note;
                category.IsActive = categoryUpdateDto.IsActive;
                category.IsDeleted = categoryUpdateDto.IsDeleted;
                category.ModifiedBy = modifiedBy;
                 category.ModifiedDate = DateTime.Now;

                 await _unitOfWork.Categories.UpdateAsync(category).ContinueWith(t => _unitOfWork.SaveAsync());
                 return new Result(ResultStatus.Success, $"{categoryUpdateDto.Name} isimli kategori eklenmistir");
            }

            return new Result(ResultStatus.Error, "Boyle bir kategori bulunamamistir");
              
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