using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7{
    public interface IGeneric<T>
    {
        void Input(T item);
        void Delete(int index);
        void Show();
       // void Print();
        //void Resize();


    }

    public interface IControl
    {
        void Print();
        //void Input();
        //void Resize();
    }

    public interface ICloneable
    {
        object Clone();
        void Sort();
    }
}
