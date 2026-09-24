using System;
using System.Globalization;

namespace SalesWebMvc.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message) : base(message)
        {

        }
    }
}
