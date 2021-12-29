using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7.Exceptions
{
    class TopUpEx : Exception
    {
        public float Top { get; set; }

        public TopUpEx (string message, float TopUp) : base (message)
        {
            this.Top = TopUp;
        }
    }
}
