using System;
using ctbl.Shared.Utilities.Results.ComplexTypes;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ctbl.Shared.Utilities.Results.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get;  }
        public string Message { get; }
        public Exception Exception { get; }
        
    }
}