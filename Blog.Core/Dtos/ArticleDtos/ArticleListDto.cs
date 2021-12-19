using Blog.Core.Dtos.Base;
using Blog.Models;
using System.Collections.Generic;

namespace Blog.Core.Dtos.ArticleDtos
{
    public class ArticleListDto : DtoBase
    {
        public IList<Article> Articles { get; set; }
    }
}
