using System;

namespace BusinessLayer.Model.UnitOfWork
{
    public class UnitOfWorkOperationResult : BusinessOperationResult
    {
        public UnitOfWorkOperationResult(bool isOk, string message = "", Exception exception = null) : base(isOk, message, exception)
        {
        }
    }
}
