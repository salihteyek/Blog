using Blog.Core.Utilities.Enums;

namespace Blog.Domain.Dtos.Base
{
    public abstract class DtoBase
    {
        public virtual ResultStatus ResultStatus { get; set; }
    }
}
