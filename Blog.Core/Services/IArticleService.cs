using Blog.Core.Dtos.ArticleDtos;
using Blog.Core.Utilities.Results;
using System.Threading.Tasks;

namespace Blog.Core.Services
{
    public interface IArticleService
    {
        Task<IDataResult<ArticleDto>> Get(int articleId);
        Task<IDataResult<ArticleListDto>> GetAll();
        Task<IDataResult<ArticleListDto>> GetAllByNonDeleted();
        Task<IDataResult<ArticleListDto>> GetAllByNonDeletedAndActive();
        Task<IDataResult<ArticleListDto>> GetAllByCategory(int categoryId);
        Task<IResult> Add(ArticleAddDto articleAddDto, string createdUser);
        Task<IResult> Update(ArticleUpdateDto articleUpdateDto, string modifiedUser);
        Task<IResult> Delete(int articleId, string modifiedUser);
        Task<IResult> HardDelete(int articleId);
    }
}
