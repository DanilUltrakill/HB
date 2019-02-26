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

            int i;

            {

                {
                    Console.Write("Меню:\n1) Введите A \n2) Введите B \n3) Сложение \n4) Вычитание \n5) Умножение \n6) Деление \n7) Выход");
                    i = int.Parse(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            Console.WriteLine("Введите A");
                            int a = int.Parse(Console.ReadLine());
                            break;

                        case 2:
                            Console.WriteLine("Введите B");
                            int b = int.Parse(Console.ReadLine());
                            break;

                        case 3:
                            int sum = a + b;
                            Console.WriteLine("{0}", sum);
                            break;

                        case 4:
                            int raz = a - b;
                            Console.WriteLine("{0}", raz);
                            break;

                        case 5:
                            int pro = a * b;
                            Console.WriteLine("{0}", pro);
                            break;

                        case 6:
                            int del = a / b;
                            Console.WriteLine("{0}", del);
                            break;

                        default:
                            Console.WriteLine("");
                            break;
                    }
                    Console.Write("\nНажмите любую клавишу...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            comixcon
           

        }
    }
}
