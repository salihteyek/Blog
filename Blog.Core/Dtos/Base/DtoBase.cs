using Blog.Core.Utilities.Enums;

namespace Blog.Core.Dtos.Base
{
    public abstract class DtoBase
    {
        public virtual ResultStatus ResultStatus { get; set; }
    }
}
