using System;
using System.Runtime.Serialization;

namespace Uppgift_3_OOP
{
    /// <summary>
    /// Custom exception used for assignment 3.4.10
    /// </summary>
    [Serializable]
    internal class CustomException : Exception
    {

        private UserError errorInfo;
        internal UserError ErrorInfo { get => errorInfo; set => errorInfo = value; }

        public CustomException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomException class.
        /// </summary>
        /// <param name="errorInfo">A UserError object with the appropriate error message</param>
        public CustomException(UserError errorInfo) : base(errorInfo.UEMessage())
        {
            ErrorInfo = errorInfo;
        }

        public CustomException(string message) : base(message)
        {
        }

        public CustomException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CustomException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }


    }
}