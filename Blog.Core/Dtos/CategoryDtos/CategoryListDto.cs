using Blog.Core.Dtos.Base;
using Blog.Models;
using System.Collections.Generic;

namespace Blog.Core.Dtos.CategoryDtos
{
    public class CategoryListDto : DtoBase
    {
        public IList<Category> Categories { get; set; }
    }
}
