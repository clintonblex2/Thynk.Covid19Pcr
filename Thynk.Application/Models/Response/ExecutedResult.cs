using System.Collections.Generic;
using Thynk.Covid19Pcr.Domain.Enums;

namespace Thynk.Covid19Pcr.Application.DTOs.Response
{
    public class ExecutedResult
    {
        public ExecutedResult()
        {
            Response = ResponseCode.Success;
        }
        public ResponseCode Response { get; set; }
        public string UserMessage { get; set; }
        public string Message { get; set; }
        public int RetryCount { get; set; }
        public List<string> ValidationMessages { get; set; } = new List<string>();
    }

    public class ExecutedResult<T> : ExecutedResult
    {
        public T Result { get; set; }

        public static ExecutedResult<T> Success(T result, string message = "Request was successful")
        {
            return new ExecutedResult<T> { Response = ResponseCode.Success, Result = result, Message = message };
        }

        public static ExecutedResult<T> Failed(string errorMsg = "Record not found")
        {
            return new ExecutedResult<T> { Message = errorMsg, Response = ResponseCode.ProcessingError };
        }
    }
}
