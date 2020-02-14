using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitlyTypedLocalVars
{
    class Program
    {
        static void Main(string[] args)
        {
            DeclareImplicitVars();
            LinqQueryOverInts();
            Console.ReadLine();
        }

        static void DeclareImplicitVars()
        {
            var myInt = 0;
            var myBool = true;
            var myString = "Время, шагом...";
            Console.WriteLine("myInt это: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool это: {0}", myBool.GetType().Name);
            Console.WriteLine("myString это: {0}", myString.GetType().Name);
        }
        static void LinqQueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            var subset = from i in numbers where i < 10 select i;
            Console.WriteLine("Значения в subset:");
            foreach (var i in subset)
            {
                Console.WriteLine("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine("subset это: {0}", subset.GetType().Name);
            Console.WriteLine("subset определен в: {0}", subset.GetType().Namespace);
        }
    }
}
