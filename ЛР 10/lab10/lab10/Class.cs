using System;
using System.Collections.Generic;
using System.Text;

namespace lab10
{
    class Book
    {
        private string _name;
        public string Name
        {
            get => _name;
        }
        private int _index;
        public int Index
        {
            get => _index;
        }

        public Book(int a, string name)
        {
            _name = name;
            _index = a;
        }

        public override string ToString() => "Book";
    }
}
