using Blog.Core.Utilities.Enums;
using Blog.Core.Utilities.Results;
using System;

namespace Blog.Service.Results
{
    public class DataResult<T> : IDataResult<T>
    {
        public DataResult(ResultStatus resultStatus, T data)
        {
            ResultStatus = resultStatus;
            Data = data;
        }

        public DataResult(ResultStatus resultStatus, T data, string message)
        {
            ResultStatus = resultStatus;
            Data = data;
            Message = message;
        }

        public DataResult(ResultStatus resultStatus, T data, string message, Exception exception)
        {
            ResultStatus = resultStatus;
            Data = data;
            Message = message;
            Exception = exception;
        }

        public T Data { get; }

        public ResultStatus ResultStatus { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }
    }
}
