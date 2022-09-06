using System;
using System.Data.SqlTypes;

namespace kalkylator
{
    public class Calculate
    {
        public Calculate()
        {
           
        }
        
        //fields & properties

        public int numberOne;
        public int NumberOne
        { get; set; }

        public int numberTwo;
        public int NumberTwo
        { get; set; }
        public string op;
        public string Op
        { get; set; }
        public int answer;
        public int Answer
        { get; set; }

       

        public int GetNumber()
        {
            int number;
            bool success = false;
            do
            {
                Console.Write("Ange ett nummer ");
                string numberAsString = Console.ReadLine();
                success = Int32.TryParse(numberAsString, out number);
                if (!success)
                
                    Console.WriteLine("Det där var inte ett nummer, försök igen!");
                
            
                
            } while (success == false);

            return number;
            
        }

      
        
        public string GetOperator()
        {
            bool success = false;
            string op;
            do
            {
                Console.Write("Ange ett tecken ");
                op = Console.ReadLine();
                if ((op == "+") || (op == "-") || (op == "*") || (op == "/") || (op == "%"))
                {
                    success = true;
                }
                else
                {
                    Console.WriteLine("Felaktig inmatning, försök igen!");
                }
            }
            while (success == false);

            return op;
        }

        public int Compute(int one, int two, string op)
        {
            int answer = 0;
            switch (op)
            {
                case "+":
                    answer = one + two;
                    break;
                case "-":
                    answer = one - two;
                    break;
                case "*":
                    answer = one * two;
                    break;
                case "/":
                    answer = one / two;
                    break;
                case "%":
                    answer = one % two;
                    break;
                default:
                    break;
            }

            return answer;
        }
    }
}

