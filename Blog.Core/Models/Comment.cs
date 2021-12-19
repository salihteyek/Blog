using Blog.Core.Models.Base;

namespace Blog.Models
{
    public class Comment : EntityBase, IEntity
    {
        public string Text { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
    }
}
