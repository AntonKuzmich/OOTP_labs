using System;
using System.Collections.Generic;
using System.Text;

namespace lab9
{
    public class User
    {
        public delegate void UserHandler(string message);
        public event UserHandler notify;
        public string name;
        public int move = 0;
        public int compress = 0;
        public string[] ToMove = new string[5] { "OnlyRead", "OnlyAddFiles", "ChangeFilesAndFolders", "Limit", "Full" };
        public void Increase()
        {
            Console.WriteLine($" || Increase {this.name}");
            Console.WriteLine($" | {name} права доступа {ToMove[move]}, текущий размер доступных данных {compress}");

            move++;
            compress = compress * 5;
            notify?.Invoke($" | {name} права доступа изменены на {ToMove[move]}");
            notify?.Invoke($" | {name} текущий размер доступных данных {compress}");

            Console.WriteLine();
        }
        public void Decrease()
        {
            Console.WriteLine($" || Decrease {this.name}");
            Console.WriteLine($" | {name} права доступа {ToMove[move]}, текущий размер доступных данных {compress}");

            move--;
            compress = compress / 5;
            if (move >= 0)
            {
                notify?.Invoke($" | {name} права доступа изменены на {ToMove[move]}");
                notify?.Invoke($" | {name} текущий размер доступных данных {compress}");
            }
            else
            {
                move++;
            }

            Console.WriteLine();
        }
    }
}
