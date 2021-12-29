using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book("Minsk");
            Book book3 = new Book(3);
            book1.GetInfo();
            book2.GetInfo();
            book3.GetInfo();

            
        }
    }
    class Book
    {
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != this.GetType()) return false;
            Book airl = (Book)obj;
            return (this.id == airl.id && this.name == airl.name && this.Author == airl.Author && this.Izdatelstvo == airl.Izdatelstvo && this.year == airl.year && this.str == airl.str && this.cost == airl.cost);
        }

        public void list_of_Tos(Book[] arr, ref string Tos)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].name.Equals(Tos))
                {
                    Console.WriteLine($"id:{id} name:{name} Author:{Author} Izdatelstvo:{Izdatelstvo} year:{year} str:{str} cost:{cost} type:{type}");
                }
            }
        }
        public void list_of_Days(Book[] arr, string dd)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].year.Equals(dd))
                {
                    Console.WriteLine($"id:{id} name:{name} Author:{Author} Izdatelstvo:{Izdatelstvo} year:{year} str:{str} cost:{cost} type:{type}");
                }
            }
        }
        public int id;
        public string name;
        static public string secondname;
        public string Author;
        public string Izdatelstvo;
        public int year;
        public int str;
        public double cost;
        public string type;
        public const int cost_to_pirnt = 5;//поле константа 
        public Book() { id = 1; name = "Brest"; Author = "Me"; Izdatelstvo = "Brest"; year = 2021; str = 50; cost = 15.99; type = "strong"; }//Конструктор 1
        public readonly double id1 = 1;//id 1 книги
        static int count1 = 1;
        public Book(string n) { id = 2; name = n; Author = "Me"; Izdatelstvo = "Brest"; year = 2021; str = 50; cost = 15.99; type = "strong"; }//Конструктор 2
        public readonly double id2 = 2;//id 2 книги
        static int count2 = count1 + 1;
        public Book(int m) { id = m; name = "Grodno"; Author = "Me"; Izdatelstvo = "Brest"; year = 2021; str = 50; cost = 15.99; type = "strong"; }//Конструктор 3
        public readonly double id3 = 3;//id 3 книги
        static int count3 = count2 + 1;
        private Book(double a) { id = 4; name = "Grodno"; Author = "Me"; Izdatelstvo = "Brest"; year = 2020; str = 50; cost = a; type = "strong"; }//Конструктор 4 закрытый
        public readonly double id4 = 4;//id 4 книги
        static int count4 = count3 + 1;
        public Book(double _id1, double _id2, double _id3, double _id4)//поля для чтения
        {
            id1 = _id1;
            id2 = _id2;
            id3 = _id3;
            id4 = _id4;
        }
        private int Age
        {
            get
            {
                return Age;
            }
            set
            {
            var n = Console.ReadLine();
            int n1 = Convert.ToInt32(n);
            Age = n1;
            }
        }
        public int Act
        {
            get
            {
                return Act;
            }
            private set
            {
                var n = Console.ReadLine();
                int n1 = Convert.ToInt32(n);
                Act = n1;
            }
        }
        static void proga(string[] args)
        {
            int x = 10;
            int y = 15;
            Addition(ref x, y); // вызов метода
            Console.WriteLine(x);   // 25

            Console.ReadLine();
        }
        // параметр x передается по ссылке
        static void Addition(ref int x, int y)
        {
            x += y;
        }


        public void GetInfo()
        {
            Console.WriteLine($"id:{id} name:{name} Author:{Author} Izdatelstvo:{Izdatelstvo} year:{year} str:{str} cost:{cost} type:{type}");
        }
        
        static Book()
        {
            secondname = "Belarus";
        }

    }
    class People
    {
        public partial class Sotrudnik
        {
            public int SotId { get; set; }
            public string Name { get; set; }
        }
        public partial class Sotrudnik
        {
            //constructor
            public Sotrudnik(int id, string name)
            {
                this.SotId = id;
                this.Name = name;
            }

            public void GetInfo()
            {
                Console.WriteLine($"SotId:{SotId} Name:{Name}");
            }
        }
    }
}
