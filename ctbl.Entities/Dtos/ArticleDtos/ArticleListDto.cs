using System.Collections.Generic;
using ctbl.Entities.Concrete;
using ctbl.Shared.Entities.Abstract;
using ctbl.Shared.Utilities.Results.ComplexTypes;

namespace ctbl.Entities.Dtos.ArticleDtos
{
    public class ArticleListDto:DtoGetBase
    {
        public IList<Article> Articles { get; set; }
    }
}