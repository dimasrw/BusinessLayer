using System;

namespace BusinessLayer.Model
{
    public class BusinessOperationResult<T> : BusinessOperationResult
    {
        private BusinessOperationResult(bool isOk, T value = default(T), string message = null, Exception exception = null)
            : base(isOk, message, exception)
        {
            this.Value = value;
        }

        public T Value { get; private set; }

        public static BusinessOperationResult<T> Ok(T value = default(T), string message = null)
        {
            return new BusinessOperationResult<T>(true, value, message);
        }

        public static BusinessOperationResult<T> Warning(T value = default(T), string message = null)
        {
            return new BusinessOperationResult<T>(false, value, message);
        }

        public static BusinessOperationResult<T> Error(Exception exception, T value = default(T), string message = null)
        {
            return new BusinessOperationResult<T>(false, value, message, exception);
        }
        public static BusinessOperationResult<T> Error(T value = default(T), string message = null)
        {
            return new BusinessOperationResult<T>(false, value, message, null);
        }
    }
}
