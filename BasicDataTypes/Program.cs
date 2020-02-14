using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalVarDeclarations();
            NewingDataTypes();
            ObjectFunctionality();
            DataTypeFunctionality();
            CharFunctionality();
            ParseFromStrings();
            UseDatesAndTimes();
            EscapeChars();
            Console.ReadLine();
        }
        static void LocalVarDeclarations()
        {
            Console.WriteLine("=> Объявление переменных:");
            int myInt=0;
            string myString;
            myString = "Это мои текстовые данные";
            bool b1 = true, b2 = false, b3 = b1;
            Console.WriteLine();
            System.Boolean b4 = false;
            Console.WriteLine("Ваши данные: {0}, {1}, {2}, {3}, {4}, {5}",
                myInt, myString, b1,b2,b3,b4);
            Console.WriteLine();
        }
        static void NewingDataTypes()
        {
            Console.WriteLine("=> Использование new для создания переменных:");
            bool b = new bool();
            int i = new int();
            double d = new double();
            DateTime dt = new DateTime();
            Console.WriteLine("{0}, {1}, {2}, {3}", b,i,d,dt);
            Console.WriteLine();
        }
        static void ObjectFunctionality()
        {
            Console.WriteLine("=> Функциональность System.Object:");
            Console.WriteLine("12.Equals(23) = {0}",12.Equals(23));
            Console.WriteLine("12.Equals(12) = {0}", 12.Equals(12));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            MessageBox.Show("Test "+ 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            Console.WriteLine();
        }
        static void DataTypeFunctionality()
        {
            Console.WriteLine("=> Функциональность типов данных:");
            Console.WriteLine("Максимальное int: {0}", int.MaxValue);
            Console.WriteLine("Минимальное int: {0}", int.MinValue);
            Console.WriteLine("Максимальное double: {0}", double.MaxValue);
            Console.WriteLine("Минимальное double: {0}", double.MinValue);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity: {0}",
                double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}",
                double.NegativeInfinity);
            Console.WriteLine();
        }
        static void CharFunctionality()
        {
            Console.WriteLine("=> Функциональность типов char:");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}",
                char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}",
                char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}",
                char.IsPunctuation('?'));
            Console.WriteLine();
        }
        static void ParseFromStrings()
        {
            Console.WriteLine("=> Парсинг типов данных:");
            bool b = bool.Parse("True");
            Console.WriteLine("Значение b: {0}", b);
            double d = double.Parse("99,884");
            Console.WriteLine("Значение d: {0}", d);
            int i = int.Parse("8");
            Console.WriteLine("Значение i: {0}", i);
            char c = char.Parse("w");
            Console.WriteLine("Значение c: {0}", c);
            Console.WriteLine();
        }
        static void UseDatesAndTimes()
        {
            Console.WriteLine("=> Парсинг типов Дата:");
            DateTime dt = new DateTime(2018, 10, 25);
            Console.WriteLine("Это число {0} будет {1}", dt.Date, dt.DayOfWeek);
            dt = dt.AddMonths(2);
            Console.WriteLine("Летнее время: {0}", dt.IsDaylightSavingTime());
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
            Console.WriteLine();
        }
        static void EscapeChars()
        {
            Console.WriteLine("=> Управляющие последовательности:");
            string strWithTabs = "Модель\tЦвет\tСкорость\tИмя зверя\a";
            Console.WriteLine(strWithTabs);
        }
    }
}
