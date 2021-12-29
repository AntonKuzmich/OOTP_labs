using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace test
{
    interface Operation
    {
        void Add(int info);
        void Delete(int info);
        object View { get; }
    }
    public class Test : Operation
    {
        int _info;
        public Test(int i)
        {
            _info = i;
        }

        public Test()
        {
        }

        public void Add(int info)
        {
            _info += info;
        }
        public void Delete(int info)
        {
            _info -= info;
        }
        public object View { get { return _info; } }
    }
    public class Collection : Operation
    {
        int _info;
        public Collection(int i)
        {
            _info = i;
        }
        public Collection()
        {
        }
        public void Add(int info)
        {
            _info += info;
        }
        public void Delete(int info)
        {
            _info -= info;
        }
        public object View { get { return _info; } }
        public int chislo { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
    [Serializable]
    class Library<T>
    {
        public T _book;
        public T Book { get { return _book; } set { _book = value; } }
        public void Display()
        {
            Console.WriteLine(Book);
        }
    }
    [Serializable]
    class Employee : Library<string>
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test(1);
            t.Add(6);
            Console.WriteLine(t.View);
            t.Delete(3);
            Console.WriteLine(t.View);
            Console.WriteLine("Текущее состояние:" + t.View);
            List<Collection> people = new List<Collection>(3);
            people.Add(new Collection() { Name = "Дмитрий", Age = 35 });
            people.Add(new Collection() { Name = "Сергей", Age = -19 });

            foreach (Collection p in people)
            {
                Console.WriteLine(p.Name);
            }
            Console.WriteLine("\nFind: Part where name contains \"Сергей\": {0}",
            people.Find(x => x.Name.Contains("Сергей")));
            try
            {
                foreach (Collection c in people)
                {
                    if (c.Age < 0)
                    {
                        throw new Exception("Age is less than zero.");
                    }
                }


            }
            catch (Exception e)
            {
                Console.WriteLine("Got Exception. Message: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Finally...");
            }
            Library<string> b = new Library<string> { Book = "Alice" };
            b.Display();
            b = new Employee { Book = "History of Belarus" };
            b.Display();
            // создаем объект BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("book.txt", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, b);

                Console.WriteLine("Объект сериализован");
            }
            using (FileStream fs = new FileStream("book.txt", FileMode.OpenOrCreate))
            {
                Library<string> newPerson = (Library<string>)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Книга:{newPerson.Book}");
            }

            Console.ReadLine();
        }
    }
}
