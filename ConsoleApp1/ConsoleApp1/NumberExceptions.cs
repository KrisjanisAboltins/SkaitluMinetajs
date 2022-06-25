using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NumberExceptions : Exception
    {
        public NumberExceptions() 
        {

        }

        public NumberExceptions(string message) : base(message)
        {

        }

        public NumberExceptions(string message, Exception innerException)
            : base(message, innerException)
        {

        }

    }

}

