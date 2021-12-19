using Blog.Core.Dtos.CategoryDtos;
using Blog.Core.Utilities.Results;
using System.Threading.Tasks;

namespace Blog.Core.Services
{
    public interface ICategoryService
    {
        Task<IDataResult<CategoryDto>> Get(int categoryId);
        Task<IDataResult<CategoryListDto>> GetAll();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeleted();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAndActive();
        Task<IResult> Add(CategoryAddDto categoryAddDto, string createdUser);
        Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifiedUser);
        Task<IResult> Delete(int categoryId, string modifiedUser);
        Task<IResult> HardDelete(int categoryId);
    }
}
