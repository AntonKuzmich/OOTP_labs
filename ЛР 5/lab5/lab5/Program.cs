using System;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using lab5;

namespace lab5
{
    public class Part : IEquatable<Part>
    {
        public string PartName { get; set; }
        public int PartId { get; set; }
        public override string ToString()
        {
            return "ID: " + PartId + "   Name: " + PartName;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Part objAsPart = obj as Part;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public bool Equals(Part other)
        {
            if (other == null) return false;
            return (this.PartId.Equals(other.PartId));
        }
        // Should also override == and != operators.
    }

    class Program
    {
        static void Main(string[] args)
        {
            People B1 = new Client();
            People B2 = new Employee();
            People B3 = new Name();
            Console.WriteLine(B1.Show());
            Console.WriteLine(B2.Show());
            Console.WriteLine(B3.Show());

            Console.WriteLine(B3.Input("status","on"));
            Console.WriteLine(B3.Show());

            Console.WriteLine();

            Console.WriteLine($"B2 is Checktbox: {B2 is Client}");
            Console.WriteLine($"B2 is ControlElem: {B2 is People}");
            IControl pC1 = B2 as IControl;
            if (pC1 != null) Console.WriteLine(pC1);
            else Console.WriteLine("B2 as IControl : Успешное преобразование типов");
            Client pC2 = B2 as Client;
            if (pC2 != null) Console.WriteLine(pC2);
            else Console.WriteLine("B2 as Checktbox : Успешное преобразование типов");

            Console.WriteLine();

            Console.WriteLine();

            People A1 = new Client();
            People A2 = new Employee();
            People A3 = new Name();
            dynamic[] PrinterArray = { A1,A2,A3 };

            Console.WriteLine("Printer");
            //Console.WriteLine(Printer.IAmPrinting(A1));
            //Console.WriteLine(Printer.IAmPrinting(A2));
            //Console.WriteLine(Printer.IAmPrinting(A3));
            LinkedList<string> linkedList = new LinkedList<string>();
            // добавление элементов
            linkedList.AddFirst("History of Belarus");
            //linkedList.Add("Alice");
            //linkedList.Add("Bob");
            //linkedList.Add("Sam");

            // выводим элемент
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            // удаляем элемент
            linkedList.Remove("Math");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            // проверяем наличие элемента
            bool isPresent = linkedList.Contains("History of Belarus");
            Console.WriteLine(isPresent == true ? "History of Belarus присутствует" : "History of Belarus отсутствует");

            // добавляем элемент в начало            
            //linkedList.AppendFirst("Bill");
            List<Part> parts = new List<Part>();

            Console.WriteLine("\nCapacity: {0}", parts.Capacity);

            parts.Add(new Part() { PartName = "History of Belarus", PartId = 1 });
            parts.Add(new Part() { PartName = "Math", PartId = 2 });
            parts.Add(new Part() { PartName = "Geography", PartId = 3 });
            parts.Add(new Part() { PartName = "Biology", PartId = 4 });
            parts.Add(new Part() { PartName = "PE", PartId = 5 }); ;

            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }
            Console.WriteLine("Count: {0}", parts.Count);
            /////////////////////////////////////////////
            try
            {
                PersonAge p = new PersonAge { Age = 17 };
            }
            catch (PersonException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            Console.Read();
            /////////////////////////////////////////////
            try
            {
                PersonAge2 p = new PersonAge2 { Age = 19 };
            }
            catch (PersonException2 ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            Console.Read();
            /////////////////////////////////////////////
            try
            {
                PersonAge3 p = new PersonAge3 { Age = 25 };
            }
            catch (PersonException3 ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            Console.Read();
            /////////////////////////////////////////////
            try
            {
                PersonAge4 p = new PersonAge4 { Age = 3 };
            }
            catch (PersonException4 ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            Console.Read();
            /////////////////////////////////////////////
            try
            {
                PersonAge5 p = new PersonAge5 { Age = 15 };
            }
            catch (PersonException5 ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            Console.Read();
            /////////////////////////////////////////////
            try
            {
                Console.Write("Введите число типа byte: ");
                byte b = byte.Parse(Console.ReadLine());
                int[] myArr = new int[5] { 1, 2, 0, 10, 12 };
                Console.WriteLine("Исходный массив: ");

                for (int j = 0; j <= myArr.Length; j++)
                    Console.WriteLine("{0}\t", myArr[j]);

                int i = 120;
                Console.WriteLine("\nДелим на число: \n");
                foreach (int d in myArr)
                    Console.WriteLine(i / d);
            }
            // Обрабатываем исключение, возникающее
            // при арифметическом переполнении
            catch (OverflowException)
            {
                Console.Write("Данное число не входит в диапазон 0 - 255");
            }
            // Исключение при делении на 0
            catch (DivideByZeroException)
            {
                Console.WriteLine("Делить на ноль нельзя");
            }
            // Исключение при переполнении массива
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Индекс выходит за пределы\n");
            }
            // Все исключения сразу
            finally
            {
                Console.WriteLine("Возникла непредвиденная ошибка");
            }
            Console.ReadLine();
            ///////////////////////////////////////////////////////
            
        }

    }
}
class PersonAge
{
    private int age;
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 18)
                throw new PersonException("Лицам до 18 регистрация запрещена");
            Debug.Assert(value <= 999999, "Mnogo");

        }
    }
}
class PersonAge2
{
    private int age;
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 18)
                throw new PersonException2("Лицам до 18 регистрация запрещена");
            else
                age = value;
        }
    }
}
class PersonAge3
{
    private int age;
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 18)
                throw new PersonException3("Лицам до 18 регистрация запрещена");
            else
                age = value;
        }
    }
}
class PersonAge4
{
    private int age;
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 18)
                throw new PersonException4("Лицам до 18 регистрация запрещена");
            else
                age = value;
        }
    }
}
class PersonAge5
{
    private int age;
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 18)
                throw new PersonException5("Лицам до 18 регистрация запрещена");
            else
                age = value;
        }
    }
}
public class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
    namespace SimpleAlgorithmsApp
{
    public class LinkedList<T> : IEnumerable<T>  // односвязный список
        {
            Node<T> head; // головной/первый элемент
            Node<T> tail; // последний/хвостовой элемент
            int count;  // количество элементов в списке

            // добавление элемента
            public void Add(T data)
            {
                Node<T> node = new Node<T>(data);

                if (head == null)
                    head = node;
                else
                    tail.Next = node;
                tail = node;

                count++;
            }
            // удаление элемента
            public bool Remove(T data)
            {
                Node<T> current = head;
                Node<T> previous = null;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        // Если узел в середине или в конце
                        if (previous != null)
                        {
                            // убираем узел current, теперь previous ссылается не на current, а на current.Next
                            previous.Next = current.Next;

                            // Если current.Next не установлен, значит узел последний,
                            // изменяем переменную tail
                            if (current.Next == null)
                                tail = previous;
                        }
                        else
                        {
                            // если удаляется первый элемент
                            // переустанавливаем значение head
                            head = head.Next;

                            // если после удаления список пуст, сбрасываем tail
                            if (head == null)
                                tail = null;
                        }
                        count--;
                        return true;
                    }

                    previous = current;
                    current = current.Next;
                }
                return false;
            }

            public int Count { get { return count; } }
            public bool IsEmpty { get { return count == 0; } }
            // очистка списка
            public void Clear()
            {
                head = null;
                tail = null;
                count = 0;
            }
            // содержит ли список элемент
            public bool Contains(T data)
            {
                Node<T> current = head;
                while (current != null)
                {
                    if (current.Data.Equals(data))
                        return true;
                    current = current.Next;
                }
                return false;
            }
            // добвление в начало
            public void AppendFirst(T data)
            {
                Node<T> node = new Node<T>(data);
                node.Next = head;
                head = node;
                if (count == 0)
                    tail = head;
                count++;
            }
            // реализация интерфейса IEnumerable
            IEnumerator IEnumerable.GetEnumerator()
            {
                return ((IEnumerable)this).GetEnumerator();
            }

            IEnumerator<T> IEnumerable<T>.GetEnumerator()
            {
                Node<T> current = head;
                while (current != null)
                {
                    yield return current.Data;
                    current = current.Next;
                }
            }

        }
    }

