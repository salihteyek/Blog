using Blog.Core.Dtos.Base;
using Blog.Models;

namespace Blog.Core.Dtos.CategoryDtos
{
    public class CategoryDto : DtoBase
    {
        public Category Category { get; set; }
    }
}
