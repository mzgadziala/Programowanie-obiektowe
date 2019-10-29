using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia3
{
    class WrongPESELException : Exception
    {
        public WrongPESELException()
        {
            Console.WriteLine("Pesel nieprawidlowy");
        }
    }
}
