using System;

namespace BusinessLayer.Model.UnitOfWork
{
    public class UnitOfWorkOperationResult : BusinessOperationResult
    {
        public UnitOfWorkOperationResult(bool isOk, string message = "", Exception exception = null) : base(isOk, message, exception)
        {
        }

        public bool IsOk { get; private set; }

        public string Message { get; private set; }

        public Exception Exception { get; private set; }

        public static UnitOfWorkOperationResult Ok(string message = "")
        {
            return new UnitOfWorkOperationResult(true, message);
        }

        public static UnitOfWorkOperationResult Warning(string message = "")
        {
            return new UnitOfWorkOperationResult(false, message);
        }

        public static UnitOfWorkOperationResult Error(string message = "")
        {
            return new UnitOfWorkOperationResult(false, message);
        }

        public static UnitOfWorkOperationResult Error(Exception exception, string message = "")
        {
            return new UnitOfWorkOperationResult(false, message, exception);
        }

        public bool HasException => this.Exception != null;
    }
}
