using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicStringFunctionality();
            FanWithStringBuilder();
            Console.ReadLine();
        }

        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Базовый функционал строк:");
            string firstName = "Freddy";
            Console.WriteLine("Значение firstName: {0}", firstName);
            Console.WriteLine("firstName длинной {0} символов", firstName.Length);
            Console.WriteLine("firstName в верхнем регистре: {0}", firstName.ToUpper());
            Console.WriteLine("firstName в нижнем регистре: {0}", firstName.ToLower());
            Console.WriteLine("Содержит ли firstName букву y?: {0}", firstName.Contains("y"));
            Console.WriteLine("firstName после замены: {0}", firstName.Replace("dy",""));
            Console.WriteLine(@"C:\MyApp\bin\Debug");
            Console.WriteLine(@"Это очень            очень             
                очень              длинная строка");
            Console.WriteLine("Это очень            очень                           очень              длинная строка");
            Console.WriteLine();
        }
        static void FanWithStringBuilder()
        {
            Console.WriteLine("=> Использование StringBuilder:");
            StringBuilder sb=new StringBuilder("****Фантастические Игры****");
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowwind");
            sb.AppendLine("Deus Ex "+"2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());
            sb.Replace("2", "Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("В sb {0} символов.", sb.Length);
            Console.WriteLine();
        }
    }
}