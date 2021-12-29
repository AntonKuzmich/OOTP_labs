using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lab5
    {

        //GeometricShape, Circle, Rectangle, IControl (interface with show, input, resize, etc.), Control, Checktbox, Radiobutton, Button
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

                Console.WriteLine(B3.Input("status", "on"));
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
                dynamic[] PrinterArray = { A1, A2, A3 };

                Console.WriteLine("Printer");
            //Console.WriteLine(Printer.IAmPrinting(A1));
            //Console.WriteLine(Printer.IAmPrinting(A2));
            //Console.WriteLine(Printer.IAmPrinting(A3));
            try
            {
                Age p = new Age { Name = "Tom", Age = 13 };
            }
            catch (AgeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine($"Некорректное значение: {ex.Value}");
            }
            Console.Read();
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
