using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class UI<T> : ICloneable, IGeneric<T> where T:Goods
    {
        private float _square = 0;
        public List<T> list;

        public UI()
        {
            list = new List<T>();
        }
        public object Clone()
        {
            return MemberwiseClone();
        }
        public void Sort()
        {
            list = list.OrderByDescending(w => w.Weight()).ToList();
        }
        public void Input(T item)
        {
            list.Add(item);
            _square += item.Square();
        }

        public void Input(T item, int count)
        {
            for (int i = 0; i < count - 1; i++)
            {
                list.Add(item);
                _square += item.Square();
            }
        }

        public void Delete(int index)
        {
            try
            {
                _square -= list[index].Square();
                list.RemoveAt(index);
            }
            catch
            {
                Console.WriteLine("Incorrect index!");
            }
        }

        public void Show()
        {
            foreach (T item in list)
                Console.WriteLine(item.ToString());
        }
        public void ShowSquare()
        {
            Console.WriteLine($"Current Square: {_square}$");
        }
    }
}
