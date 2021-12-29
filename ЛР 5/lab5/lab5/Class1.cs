using System;
using System.Linq;

namespace lab5
{
    public class Container
    {
        class Text
        {
            public int type { get; set; }
            public virtual string ToString()
            {
                return "lab5.Text";
            }
        }
    }
        class Text
    {
        public int type { get; set; }
        public virtual string ToString()
        {
            return "lab5.Text";
        }
    }
    sealed class Magazine : Text

    {
        public string name = "Журнал";
        public int type { get; set; }
        public Magazine(int type)
        {
            this.type = type;
        }
        public override string ToString()
        {
            return ($"Класс - {this.name}");
        }

    }

    sealed class Book : Text
    {
        public string name = "Книга";
        public int type { get; set; }
        public Book(int type)
        {
            this.type = type;
        }

        public override string ToString()
        {
            return ($"Класс - {this.name}");
        }
    }
    sealed class PrintEdition : Text
    {
        public string name = "Книга";
        public int type { get; set; }
        public PrintEdition(int type)
        {
            this.type = type;
        }

        public override string ToString()
        {
            return ($"Класс - {this.name}");
        }
    }
    sealed class Textbook : Text
    {
        public string name = "Учебник";
        public int type { get; set; }
        public Textbook(int type)
        {
            this.type = type;
        }

        public override string ToString()
        {
            return ($"Класс - {this.name}");
        }
    }
    sealed class Person : Text
    {
        public string name = "Персона";
        public int type { get; set; }
        public Person(int type)
        {
            this.type = type;
        }

        public override string ToString()
        {
            return ($"Класс - {this.name}");
        }
    }
    sealed class Author : Text
    {
        public string name = "Автор";
        public int type { get; set; }
        public Author(int type)
        {
            this.type = type;
        }

        public override string ToString()
        {
            return ($"Класс - {this.name}");
        }
    }
    sealed class PublishingHouse : Text
    {
        public string name = "Книга";
        public int type { get; set; }
        public PublishingHouse(int type)
        {
            this.type = type;
        }

        public override string ToString()
        {
            return ($"Класс - {this.name}");
        }
    }
    abstract class People
    {
        public static int Nums = 0;
        public string type { get; set; }
        public int size { get; set; }
        public bool status { get; set; }
        public string Name { get; set; }

        public People(string name)
        {
            Name = name;
        }

        protected People()
        {
        }

        public void Display()
        {
            Console.WriteLine(Name);
        }
        public string Show()
        {
            return ($"");
        }
        public virtual string ToString()
        {
            return "People.Client";
        }
        public int Resize()
        {
            Console.Write("Элемент №");
            return size++;
        }
        public string Input(string obj, string param)
        {
            if (obj == "status") { if (param == "on") this.status = true; if (param == "off") this.status = false; }
            return $"Добавлен {obj}";
        }
    }

    class Client : People
    {
        public int Sum { get; set; }    // сумма на счету
        public Client()
            : base()
        {
        }
        public override string ToString()
        {
            return $"People.{type}";
        }
    }

    class Employee : People
    {
        public string Position { get; set; } // должность
        public Employee()
            : base()
        {
        }
        public override string ToString()
        {
            return $"People.{type}";
        }
    }
    class Name : People
    {
        public string FIO { get; set; } // имя
        public Name() : base()
        { 
        }
        public override string ToString()
        {
            return $"People.{type}";
        }
    }

    static partial class Printer
    {
        static internal string IAmPrinting(object someobj)
        {
            if (someobj is People)
            {
                if (someobj is Client)
                {
                    People chbox = someobj as Client;
                    return chbox.ToString();
                }
                if (someobj is Employee)
                {
                    People rb = someobj as Employee;
                    return rb.ToString();
                }
                if (someobj is Name)
                {
                    People chb = someobj as Name;
                    return chb.ToString();
                }
                People el = someobj as People;
                return Convert.ToString(el);
            }
            return "Неизвестная ошибка";
        }
    }
    class PersonException : Exception
    {
        public PersonException(string message)
            : base(message)
        { }
    }
    class PersonException2 : ArgumentException
    {
        public int Value { get; }
        public PersonException2(string message)
            : base(message)
        { }
        
    }
    class PersonException3 : ArgumentException
    {
        public int Value { get; }
        public PersonException3(string message)
            : base(message)
        { }

    }
    class PersonException4 : ArgumentException
    {
        public int Value { get; }
        public PersonException4(string message)
            : base(message)
        { }

    }
    class PersonException5 : ArgumentException
    {
        public int Value { get; }
        public PersonException5(string message)
            : base(message)
        { }

    }
}
 