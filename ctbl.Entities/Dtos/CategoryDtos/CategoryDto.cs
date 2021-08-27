using ctbl.Entities.Concrete;
using ctbl.Shared.Entities.Abstract;

namespace ctbl.Entities.Dtos.CategoryDtos
{
    public class CategoryDto:DtoGetBase
    {
        public Category Category { get; set; }
    }
}