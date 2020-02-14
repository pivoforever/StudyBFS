using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationsAndDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            ForEachLoopExample();
            WhileLoopExample();
            SwitchExample();
            SwitchOnEnumExample();
            Console.ReadLine();
        }
        static void ForEachLoopExample()
        {
            string[] carTypes = { "Ford", "BMV", "Yugo", "Honda" };
            foreach(string c in carTypes)
                Console.WriteLine(c);
            int[] myInts = { 10, 20, 30, 40 };
            foreach(int i in myInts)
                Console.WriteLine(i);
        }
        static void WhileLoopExample()
        {
            string userIsDone = "";
            while (userIsDone.ToLower() !="yes")
            {
                Console.WriteLine("В цикле while");
                Console.WriteLine("Ты сделал? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            }
        }
        static void SwitchExample()
        {
            Console.WriteLine("[C#] или [VB]");
            Console.Write("Выберите предпочитаемый язык:");
            string langChoice = Console.ReadLine();
            //int n = int.Parse(langChoice);
            switch (langChoice)
            {
                case "C#":
                    Console.WriteLine("Хороший выбор, C# - замечательный язык");
                break;
                case "VB":
                    Console.WriteLine("VB: ООП, многопоточность и многое другое!");
                break;
                default:
                    Console.WriteLine("Хорошо, удачи!");
                break;
            }

        }
        static void SwitchOnEnumExample()
        {
            Console.WriteLine("Введите ваш любимый день недели: ");
            DayOfWeek favDay;
            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Неправильный ввод!");
                return;
            }
            switch (favDay)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Футбол!!!");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Еще день, еще доллар");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("По крайней мере не понедельник");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Прекрасный день.");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Почти пятница...");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Да, пятница рулит!");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("И правда великий день");
                    break;
            }
        }
    }
}
