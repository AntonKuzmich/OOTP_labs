using System;
using System.Collections.Generic;
using System.Text;

namespace lab10
{
    class MyList<T> : List<T>
    {
        public void Show()
        {
            Console.Write(" || List: ");
            foreach (T i in this)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
