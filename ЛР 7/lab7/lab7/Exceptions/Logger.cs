using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7.Exceptions
{
    class Logger
    {
        public static void WriteLog(Exception ex, bool infile = true, string filePath = @"D:\study\2 курс\ООП\ЛР 7\lab7\lab7\LOG.txt") 
        {
            if (infile)
            {
                DateTime time = DateTime.Now;
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine($"Time: {time}");
                    sw.Write($"ERROR: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
