namespace MYAZ201.nTier.Business.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message)
            : base(success, message)
        {
            Data = data;
        }

        public DataResult(T data, bool success)
            : base(success)
        {
            Data = data;
        }

        public T Data { get; }

        public static SuccessDataResult<T> SuccessDataResult(T data, string message="")
        {
            return new SuccessDataResult<T>(data, message);
        }

        public static ErrorDataResult<T> ErrorDataResult(T data, string message = "")
        {
            return new ErrorDataResult<T>(data, message);
        }
    }
}