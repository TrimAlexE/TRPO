using System;

namespace Trimailov
{
    class TrimailovException : Exception
    {
        public TrimailovException(string message)
        : base(message)
        { }
    }
}
