using System;

namespace Shared.Types
{
    public class GeneralException : Exception
    {
        public string Code { get; }

        public GeneralException()
        {
        }

        public GeneralException(string code)
        {
            Code = code;
        }

        public GeneralException(string message, params object[] args) 
            : this(string.Empty, message, args)
        {
        }

        public GeneralException(string code, string message, params object[] args) 
            : this(null, code, message, args)
        {
        }

        public GeneralException(Exception innerException, string message, params object[] args)
            : this(innerException, string.Empty, message, args)
        {
        }

        public GeneralException(Exception innerException, string code, string message, params object[] args)
            : base(string.Format(message, args), innerException)
        {
            Code = code;
        }        
    }
}