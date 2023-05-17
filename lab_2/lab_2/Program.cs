using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1.Ввести А");
            Console.WriteLine("2.Ввести В");
            Console.WriteLine("3.Выполнить операцию “+”");
            Console.WriteLine("4.выполнить операцию “-”");
            Console.WriteLine("5.выполнить операцию “*”");
            Console.WriteLine("6.выполнить операцию “/”");

            int A = 0, B = 0, vibor = 0;
            bool sost = true;

            Console.Write("Введите номер команды - ");
            vibor = int.Parse(Console.ReadLine());

            do
            {
                switch (vibor)
                {
                    case 1:
                        A = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        B = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        A = A + B;
                        break;
                    case 4:
                        A = A - B;
                        break;
                    case 5:
                        A = A * B;
                        break;
                    case 6:
                        if (B == 0)
                            Console.WriteLine("Число B ровно 0");
                        else 
                            A = A / B;
                        break;
                    default:
                        sost = false;
                        break;
                }
            }
            while (true);
        }
    }
}
