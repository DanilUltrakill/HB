using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3
{
    class Program
    {
        static void Main(string[] args)

        {
             case 1:
             Console.WriteLine("Введите A");
            int a = int.Parse(Console.ReadLine());
            break;

           case 2:
            Console.WriteLine("Введите B");
            int b = int.Parse(Console.ReadLine());
             case 3:
            int sum = a + b;
            Console.WriteLine("{0}", sum);
       
           case 4:
            int raz = a - b;
            Console.WriteLine("{0}", raz);

            break;
        }
    }
}
