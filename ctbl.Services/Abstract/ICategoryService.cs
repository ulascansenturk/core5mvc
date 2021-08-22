using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using ctbl.Entities.Concrete;
using ctbl.Entities.Dtos.CategoryDtos;
using ctbl.Shared.Utilities.Results.Abstract;

namespace ctbl.Services.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<Category>> Get(int categoryId);
        Task<IDataResult<IList<Category>>> GetAll();
        Task<IDataResult<IList<Category>>> GetAllByNonDeleted();
        
        Task<IResult> Add(CategoryAddDto categoryAddDto, string createdBy);
        Task<IResult> Update(CategoryUpdateDto categoryUpdateDto,string modifiedBy);
        Task<IResult> Delete(int categoryId);
        Task<IResult> HardDelete(int categoryId);
           





    }
}