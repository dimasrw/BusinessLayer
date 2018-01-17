using System;

namespace BusinessLayer.Model.Repository
{
    public class DataOperationResult<T> : BusinessOperationResult
    {
        private DataOperationResult(bool isOk, T value = default(T), string message = null, Exception exception = null)
            : base(isOk, message, exception)
        {
            this.Value = value;
        }

        public T Value { get; private set; }

        public static DataOperationResult<T> Ok(T value = default(T), string message = null)
        {
            return new DataOperationResult<T>(true, value, message);
        }

        public static DataOperationResult<T> Warning(T value = default(T), string message = null)
        {
            return new DataOperationResult<T>(false, value, message);
        }

        public static DataOperationResult<T> Error(Exception exception, T value = default(T), string message = null)
        {
            return new DataOperationResult<T>(false, value, message, exception);
        }
        public static DataOperationResult<T> Error(T value = default(T), string message = null)
        {
            return new DataOperationResult<T>(false, value, message, null);
        }
    }
}
