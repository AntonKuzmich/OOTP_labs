using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class MyCollection : IDictionary<int,Book>
    {
        private int _count;
        public SortedSet<Book> books;

        public MyCollection()
        {
            _count = 0;
            books = new SortedSet<Book>(new Comparer());
        }

        public int Count => _count;

        public void Show()
        {
            Console.Write(" || List:   ");
            foreach (var book in books)
            {
                Console.Write(book.Name + "   ");
            }
            Console.WriteLine();
        }

        public bool Add(Book item)
        {
            return books.Add(item);
        }

        public void Clear()
        {
            books.Clear();
        }

        public bool Contains(Book item)
        {
            return books.Contains(item);
        }

        public void CopyTo(Book[] array, int arrayIndex)
        {
            books.CopyTo(array, arrayIndex);
        }

        public void ExceptWith(IEnumerable<Book> other)
        {
            books.ExceptWith(other);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return books.GetEnumerator();
        }

        public void IntersectWith(IEnumerable<Book> other)
        {
            books.IntersectWith(other);
        }

        public bool IsProperSubsetOf(IEnumerable<Book> other)
        {
            return books.IsProperSubsetOf(other);
        }

        public bool IsProperSupersetOf(IEnumerable<Book> other)
        {
            return books.IsProperSupersetOf(other);
        }

        public bool IsSubsetOf(IEnumerable<Book> other)
        {
            return books.IsProperSupersetOf(other);
        }

        public bool IsSupersetOf(IEnumerable<Book> other)
        {
            return books.IsProperSupersetOf(other);
        }

        public bool Overlaps(IEnumerable<Book> other)
        {
            return books.IsProperSupersetOf(other);
        }

        public bool Remove(Book item)
        {
            return books.Remove(item);
        }

        public bool ListEquals(IEnumerable<Book> other)
        {
            return books.SetEquals(other);
        }

        public void SymmetricExceptWith(IEnumerable<Book> other)
        {
            books.SymmetricExceptWith(other);
        }

        public void UnionWith(IEnumerable<Book> other)
        {
            books.UnionWith(other);
        }
        public bool IsReadOnly => false;
       
    }
}
