using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Model.Repository
{
    public class RepositoryOperationResult<T> : BusinessOperationResult
    {
        private RepositoryOperationResult(bool isOk, T value = default(T), string message = null, Exception exception = null)
            : base(isOk, message, exception)
        {
            this.Value = value;
        }

        public T Value { get; private set; }

        public static RepositoryOperationResult<T> Ok(T value = default(T), string message = null)
        {
            return new RepositoryOperationResult<T>(true, value, message);
        }

        public static RepositoryOperationResult<T> Warning(T value = default(T), string message = null)
        {
            return new RepositoryOperationResult<T>(false, value, message);
        }

        public static RepositoryOperationResult<T> Error(Exception exception, T value = default(T), string message = null)
        {
            return new RepositoryOperationResult<T>(false, value, message, exception);
        }
        public static RepositoryOperationResult<T> Error(T value = default(T), string message = null)
        {
            return new RepositoryOperationResult<T>(false, value, message, null);
        }
    }
}
