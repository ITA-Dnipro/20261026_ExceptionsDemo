using System;
using System.Collections.Generic;
using System.Text;

namespace _20261026_ExceptionsDemo
{
    public class WrongArgumentException : Exception
    {
        public WrongArgumentException()
            : base("Error: Divide by zerro!!!")
        {
            
        }

        public WrongArgumentException(Exception innerException)
            : base("Error: Divide by zerro!!!", innerException)
        {

        }
    }
}
