using System;
using ctbl.Shared.Utilities.Results.Abstract;
using ctbl.Shared.Utilities.Results.ComplexTypes;

namespace ctbl.Shared.Utilities.Results.Concrete
{
    public class Result:IResult
    {
        public Result(ResultStatus resultStatus)
        {
            ResultStatus = resultStatus;

        }
        public Result(ResultStatus resultStatus,string message,Exception exception)
        {
            ResultStatus = resultStatus;
            Message = message;
            Exception = exception;
        }
        public ResultStatus ResultStatus { get; }
        public string Message { get; }
        public Exception Exception { get; }
    }
}