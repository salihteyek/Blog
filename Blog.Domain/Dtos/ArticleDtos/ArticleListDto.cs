using Blog.Domain.Dtos.Base;
using Blog.Models;
using System.Collections.Generic;

namespace Blog.Domain.Dtos.ArticleDtos
{
    public class ArticleListDto : DtoBase
    {
        public IList<Article> Articles { get; set; }
    }
}
