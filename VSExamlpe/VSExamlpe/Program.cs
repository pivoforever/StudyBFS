using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSExamlpe
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (String arg in args)
            {

            }
            //Настроить консольный интерфейс
            ConfigCUI();
            //Ожидаем ентер
            Console.ReadLine();
        }

        private static void ConfigCUI()
        {
            Console.Title = "My Rockin App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("*************************************************");
            Console.WriteLine("********Welcom to my rockin app!!!***************");
            Console.WriteLine("*************************************************");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
