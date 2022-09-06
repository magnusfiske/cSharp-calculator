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
            //En metod av klassen cal1 för att hämta båda talen
            cal1.Op = cal1.GetOperator();
            //hämtar vilket räknesätt som ska användas
            cal1.Answer = cal1.Compute(cal1.NumberOne, cal1.NumberTwo, cal1.Op);
            //gör själva beräkningen

            Console.WriteLine("{0} {1} {2} = {3}", cal1.NumberOne, cal1.Op, cal1.NumberTwo, cal1.Answer);

            Console.ReadKey();
            





        }

    }
}
