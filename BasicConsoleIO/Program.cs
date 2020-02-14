using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Базовый консольный Ввод/Вывод*****");
            GetUserData();
            FormatNumericalData();
            DisplayMessage();
            Console.ReadLine();
        }
        static void GetUserData()
        {
            Console.WriteLine("Пожалуйста, введите ваше имя: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Пожалуйста, введите ваш возраст: ");
            string userAge = Console.ReadLine();
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Привет {0}! Тебе {1} лет.", userName, userAge);
            Console.ForegroundColor = prevColor;
        }
        static void FormatNumericalData()
        {
            Console.WriteLine("Число 99999 в разных форматах:");
            Console.WriteLine("Формат c: {0:c}", 99999);
            Console.WriteLine("Формат d9: {0:d9}", 99999);
            Console.WriteLine("Формат f3: {0:f3}", 99999);
            Console.WriteLine("Формат n: {0:n}", 99999);
            Console.WriteLine("Формат E: {0:E}", 99999);
            Console.WriteLine("Формат e: {0:e}", 99999);
            Console.WriteLine("Формат X: {0:X}", 99999);
            Console.WriteLine("Формат x: {0:x}", 99999);
        }
        static void DisplayMessage()
        {
            string userMessage = string.Format
                ("100000 в шестнадцатиричной сисеме это {0:x}", 100000);
            System.Windows.MessageBox.Show(userMessage);
        }

    }
}
