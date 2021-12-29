using System;
using System.Collections.Generic;
using System.Text;

namespace lab10
{
    class Comparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
