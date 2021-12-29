using lab7.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Printer
    {
        public void IAmPrinting(Control obj)
        {
            Console.WriteLine($"Type: {obj.ToString()}");
        }
    }

    abstract class GeometricFigure
    {
        protected int countOfFigures = 0;

        public override string ToString() => GetType().Name;
        public override int GetHashCode() => countOfFigures;
        public override bool Equals(object obj) => GetType().Name == obj.ToString();
    }

    abstract class Goods : GeometricFigure
    {
        protected float _square = 150.75f;

        public void TopUp(float value)
        {
            if (value < 0) throw new TopUpEx("You can not top up negative value", value);
            if (value > 999999) throw new TopUpEx("Too much...", value);

            Debug.Assert(value <= 999999, "Mnogo");
            _square += value;
            ShowSquare();
        }
        public void ShowSquare()
        {
            Console.WriteLine($"Now you have {_square}");
        }
        public abstract float Square();
        public abstract float Weight();
        public abstract void Buy(int amount = 1);
    }

    class Circle : Goods
    {
        private float _cost = 2.5f;
        private int _weight = 80;

        public override void Buy(int amount = 1)
        {
            if (_square >= amount * _cost)
            {
                _square -= amount * _cost;
                ShowSquare();
                countOfFigures++;
            }
            else
                throw new BuyEx("You don't have enough square");
        }
        public override float Square() => _cost;
        public override float Weight() => _weight;
    }

    class Rectangle : Goods
    {
        private float _cost = 149.55f;
        private int _weight = 300;

        public override void Buy(int amount = 1)
        {
            if (_square >= amount * _cost)
            {
                _square -= amount * _cost;
                ShowSquare();
                countOfFigures++;
            }
            else
                throw new BuyEx("You don't have enough square");
        }

        public override float Square() => _cost;
        public override float Weight() => _weight;
    }

    abstract class Control
    {
        public override string ToString() => GetType().Name;
        public abstract void Print();
    }

    sealed class Cake : Control, IControl
    {
        public override void Print()
        {
            Console.WriteLine($"|Abstract|\tType of this object: {ToString()}");
        }

        void IControl.Print()
        {
            Console.WriteLine($"|Interface|\tType of this object: {ToString()}");
        }
    }

    sealed class Sweets : Control, IControl
    {

        public enum Type {
            Roshen = 0,
            Kommunarka,
            Spartak
        }

        public Info[] companies;

        public struct Info
        {
            private float _square;
            private Type _type;

            public float Square {
                get => _square;
                set => _square = value;
            }
            public Type Type
            {
                get => _type;
                set => _type = value;
            }
        }

        public Sweets()
        {
            companies = new Info[3];
            companies[0].Type = Type.Roshen;
            companies[0].Square = 1.2f;
            companies[1].Type = Type.Kommunarka;
            companies[1].Square = 0.8f;
            companies[2].Type = Type.Spartak;
            companies[2].Square = 0.7f;
        }

        public override void Print()
        {
            Console.WriteLine($"|Abstract|\tType of this object: {ToString()}");
        }

        void IControl.Print()
        {
            Console.WriteLine($"|Interface|\tType of this object: {ToString()}");
        }
    }
}
