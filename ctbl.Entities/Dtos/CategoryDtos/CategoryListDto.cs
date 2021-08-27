using System.Collections.Generic;
using ctbl.Entities.Concrete;
using ctbl.Shared.Entities.Abstract;

namespace ctbl.Entities.Dtos.CategoryDtos
{
    public class CategoryListDto:DtoGetBase
    {
        public IList<Category> Categories { get; set; }
    }
}