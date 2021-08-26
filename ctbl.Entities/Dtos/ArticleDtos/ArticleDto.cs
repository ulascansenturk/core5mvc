using ctbl.Entities.Concrete;
using ctbl.Shared.Entities.Abstract;
using ctbl.Shared.Utilities.Results.ComplexTypes;

namespace ctbl.Entities.Dtos.ArticleDtos
{
    public class ArticleDto:DtoGetBase
    {
 
        public Article Article { get; set; }
    }
}