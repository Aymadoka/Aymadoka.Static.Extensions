using System;
using System.Collections.Generic;
using System.Text;

namespace Aymadok.Static.ExceptionExtension
{
    public static class ExceptionExtensions
    {
        public static Exception? InnerException(this Exception exception)
        {
            if (exception != null && exception.InnerException != null)
            {
                return exception.InnerException.InnerException();
            }

            return exception;
        }
    }
}
