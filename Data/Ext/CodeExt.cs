using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Ext
{
    public class CodeExt: Exception
    {
        public CodeExt()
        {

        }
        public CodeExt(string message) :
           base(message)
        {

        }
        public CodeExt(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}
