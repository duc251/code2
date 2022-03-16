﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Extensions
{
    public class AddException : Exception
    {
        public AddException()
        {
        }

        public AddException(string message)
            : base(message)
        {
        }

        public AddException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
