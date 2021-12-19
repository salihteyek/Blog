using Blog.Domain.Dtos.Base;
using Blog.Models;

namespace Blog.Domain.Dtos.CategoryDtos
{
    public class CategoryDto : DtoBase
    {
        public Category Category { get; set; }
    }
}
