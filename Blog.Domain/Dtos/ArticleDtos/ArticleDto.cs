using Blog.Domain.Dtos.Base;
using Blog.Models;

namespace Blog.Domain.Dtos.ArticleDtos
{
    public class ArticleDto : DtoBase
    {
        public Article Article { get; set; }
    }
}
