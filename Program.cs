using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое значение");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите оператор");
            string oper = Console.ReadLine();

            Console.WriteLine("Введите второе значение");
            int b = int.Parse(Console.ReadLine());

            int result = 0;

            if (oper == "+")
            {
                result = a + b;
            }
            else if (oper == "-")
            {
                result = a - b;
            }
            else if (oper == "*")
            {
                result = a * b;
            }
            else if (oper == "/")
            {
                if ((a % b) == 0)
                {
                    result = a / b;
                }
                else
                {
                    Convert.ToDouble(a);
                    Convert.ToDouble(b);
                    Convert.ToDouble(result);

                    result = a / b;
                }
            }

            Console.WriteLine(result);
        }
    }
}
