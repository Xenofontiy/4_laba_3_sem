using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_laba_3_sem
{
    class Program
    {
        public struct Infk_struct
        {
            public string category { get; set; }
            public int name { get; set; }
            public int pries { get; set; }
            public int usefulness { get; set; }

        }

        static void Main(string[] args)
        {
            string Path_inf = @"C:\Users\Xeno\Desktop\C#\4_laba_3_sem\4_laba_3_sem\Data.txt"; //забор инфы с файла
            string readText = File.ReadAllText(Path_inf);
            Console.WriteLine(readText);
            Console.ReadLine();
            
        }
    }
}
