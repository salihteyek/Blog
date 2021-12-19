using Blog.Core.Dtos.Base;
using Blog.Models;

namespace Blog.Core.Dtos.ArticleDtos
{
    public class ArticleDto : DtoBase
    {
        public Article Article { get; set; }
    }
}
