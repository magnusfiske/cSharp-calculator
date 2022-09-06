using System;

namespace kalkylator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate cal1 = new Calculate();

            Console.WriteLine("Miniräknare");
            Console.WriteLine("");


            cal1.NumberOne = cal1.GetNumber();
            cal1.NumberTwo = cal1.GetNumber();
            cal1.Op = cal1.GetOperator();
            cal1.Answer = cal1.Compute(cal1.NumberOne, cal1.NumberTwo, cal1.Op);

            Console.WriteLine("{0} {1} {2} = {3}", cal1.NumberOne, cal1.Op, cal1.NumberTwo, cal1.Answer);

            





        }

    }
}
