using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Two_Numbers
{
    class Program
    {
      static void Main()
        {
            int number1, number2, total;
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
            total = number1 + number2;
            Console.Write("Total : " + total);
            Console.ReadKey();
        }
    }
}
