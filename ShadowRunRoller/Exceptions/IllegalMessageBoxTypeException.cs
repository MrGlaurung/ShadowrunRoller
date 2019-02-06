using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowRunRoller.Exceptions
{
    class IllegalMessageBoxTypeException : Exception
    {
        public IllegalMessageBoxTypeException()
        {
        }

        public IllegalMessageBoxTypeException(string message) : base(message)
        {
        }

        public IllegalMessageBoxTypeException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
