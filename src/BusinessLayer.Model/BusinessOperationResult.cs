using System;

namespace BusinessLayer.Model
{
    public class BusinessOperationResult
    {
        protected BusinessOperationResult(bool isOk, string message = "", Exception exception = null)
        {
            this.IsOk = isOk;
            this.Message = message;
            this.Exception = exception;
        }

        public bool IsOk { get; private set; }

        public string Message { get; private set; }

        public Exception Exception { get; private set; }

        public static BusinessOperationResult Ok(string message = "")
        {
            return new BusinessOperationResult(true, message);
        }

        public static BusinessOperationResult Warning(string message = "")
        {
            return new BusinessOperationResult(false, message);
        }

        public static BusinessOperationResult Error(string message = "")
        {
            return new BusinessOperationResult(false, message);
        }

        public static BusinessOperationResult Error(Exception exception, string message = "")
        {
            return new BusinessOperationResult(false, message, exception);
        }

        public static implicit operator bool(BusinessOperationResult value)
        {
            return value.IsOk;
        }

        public bool HasException => this.Exception != null;
    }
}
