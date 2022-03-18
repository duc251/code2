using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class CodeException : Exception
    {
        public CodeException()
        {

        }
        public CodeException(string message)
            : base(message)
        { 

        }
        public CodeException(string message, Exception inner)
            : base(message, inner) 
        { 

        }
    }
}
