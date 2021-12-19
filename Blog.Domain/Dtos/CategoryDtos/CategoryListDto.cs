using Blog.Domain.Dtos.Base;
using Blog.Models;
using System.Collections.Generic;

namespace Blog.Domain.Dtos.CategoryDtos
{
    public class CategoryListDto : DtoBase
    {
        public IList<Category> Categories { get; set; }
    }
}
