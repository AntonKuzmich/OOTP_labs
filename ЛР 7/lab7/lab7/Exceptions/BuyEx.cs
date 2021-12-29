using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7.Exceptions
{
    class BuyEx : Exception
    {
        public BuyEx(string message) : base(message) { }
    }
}
