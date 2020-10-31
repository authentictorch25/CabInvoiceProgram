using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class CabInvoiceCustomException : Exception
    {
        // <summary>
        /// Enum class Exception Type
        /// </summary>
        public enum ExceptionType
        {
            INVALID_DISTANCE,
            INVALID_TIME
        }

        public ExceptionType exceptionType;

        /// <summary>
        /// Initializes a new instance of the <see cref="CabInvoiceCustomException"/> class.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        public CabInvoiceCustomException(ExceptionType exception, string message) : base(message)
        {
            this.exceptionType = exception;
        }
    }
}
