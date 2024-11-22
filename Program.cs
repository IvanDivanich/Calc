using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x, y;

            SpecialFuns sp = new SpecialFuns();
            Console.WriteLine("Введите номер операции\n1 - Плюс\n2 - Минус\n3 - Разделить\n4 - Умножить\n5 - Степень");

            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите первое число");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            y = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    Console.WriteLine(sp.Degree(x, y));
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}
