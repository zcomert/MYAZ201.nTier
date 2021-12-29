using System.Collections.Generic;

namespace MYAZ201.nTier.Business.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message)
            : this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }
        public string Message { get; }

        public List<IResult> Errors { get; set; } = new List<IResult>();

        public static SuccessResult SuccessResult(string message="")
        {
            return new SuccessResult(message);
        }

        public static ErrorResult ErrorResult(string message="")
        {
            return new ErrorResult(message);
        }

        public static ErrorResult Invalid(List<IResult> errors, 
            string message="")
        {
            return new ErrorResult(message)
            {
                Errors = errors
            };
        }

    }
}