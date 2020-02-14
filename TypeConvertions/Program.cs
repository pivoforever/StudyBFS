using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConvertions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Веселье с преобразованием типов*****");
            short numb1 = 30000, numb2 = 30000;
            short answer = (short)Add(numb1, numb2);
            Console.WriteLine("{0} + {1} = {2}", numb1,numb2,answer);
            NarrowingAttempt();
            ProcessByte();
            Console.ReadLine();
        }
        
        static int Add(int x, int y)
        {
            return x + y;
        }

        static void NarrowingAttempt()
        {
            byte myByte = 0;
            int myInt = 200;
            myByte = (byte)myInt;
            Console.WriteLine("Значение myByte: {0}", myByte);
        }
        static void ProcessByte()
        {
            byte b1 = 100;
            byte b2 = 250;
            try
            {
                byte sum = checked((byte)Add(b1, b2));
                Console.WriteLine("sum = {0}", sum);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
