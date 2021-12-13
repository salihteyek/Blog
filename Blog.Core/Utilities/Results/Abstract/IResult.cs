using Blog.Core.Utilities.Enums;
using System;

namespace Blog.Core.Utilities.Results
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }
    }
}
