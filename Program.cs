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
            string inputValStr = Console.ReadLine();
            int a = int.Parse(inputValStr);

            Console.WriteLine("Введите оператор");
            inputValStr = Console.ReadLine();
            char oper = char.Parse(inputValStr);

            Console.WriteLine("Введите второе значение");
            inputValStr = Console.ReadLine();
            int b = int.Parse(inputValStr);

            Console.WriteLine(a + oper + b);

            //if (oper == "+") 
            //{
            //    Console.WriteLine(a + b);
            //}
            //else if (oper == "-")
            //{
            //    Console.WriteLine(a - b);
            //}
            //else if (oper == "*")
            //{
            //    Console.WriteLine(a * b);
            //}
            //else if (oper == "/")
            //{
            //    Console.WriteLine(a / b);
            //} else
            //{
            //    Console.WriteLine("Введите корректные данные.");
            //}

        }
    }
}
