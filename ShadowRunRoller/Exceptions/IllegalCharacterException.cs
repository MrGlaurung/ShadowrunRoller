using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowRunRoller.Exceptions
{
    class IllegalCharacterException : Exception
    {
        public IllegalCharacterException()
        {
        }

        public IllegalCharacterException(string message) : base(message)
        {
        }

        public IllegalCharacterException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
