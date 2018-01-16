using System;

namespace BusinessLayer.Model.Service
{
    public class ServiceOperationResult<T>: BusinessOperationResult
    {
        private ServiceOperationResult(bool isOk, T value = default(T), string message = null, Exception exception = null)
            : base(isOk, message, exception)
        {
            this.Value = value;
        }

        public T Value { get; private set; }

        public static ServiceOperationResult<T> Ok(T value = default(T), string message = null)
        {
            return new ServiceOperationResult<T>(true, value, message);
        }

        public static ServiceOperationResult<T> Warning(T value = default(T), string message = null)
        {
            return new ServiceOperationResult<T>(false, value, message);
        }

        public static ServiceOperationResult<T> Error(Exception exception, T value = default(T), string message = null)
        {
            return new ServiceOperationResult<T>(false, value, message, exception);
        }
        public static ServiceOperationResult<T> Error(T value = default(T), string message = null)
        {
            return new ServiceOperationResult<T>(false, value, message, null);
        }
    }
}
