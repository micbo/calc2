using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTst1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string hej = "Hello WIRDO";
            //Console.BackgroundColor = (red);
            //Console.WriteLine(hej);
            Console.WriteLine("Tast + for addition");
            Console.WriteLine("Tast - for subtraktion");
            Console.WriteLine("Tast * for multiplikation");
            Console.WriteLine("Tast / for division");
            int number1, number2, result = 0;

            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("skriv tal 1:");
            Console.WriteLine();
            number1 = HentTal();
            Console.WriteLine("Tak skriv tal 2");
            Console.WriteLine();
            number2 = HentTal();

            switch (operation)
            {

                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                    result = number1 / number2;
                    break;
            }

            Console.WriteLine("Resultatet af alle anstrengelserne:" + result.ToString());

            Console.ReadLine();


        }

        static int HentTal()
        {
            int number1;
            while (true)
            {
                //Console.WriteLine("skriv et tal:");
                if (int.TryParse(Console.ReadLine(), out number1))
                {
                    break;
                }
            }

            return number1;
        }
    }



}

    
    
