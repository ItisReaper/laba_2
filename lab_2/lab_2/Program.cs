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
            Console.WriteLine("Ввести А");
            Console.WriteLine("Ввести В");
            Console.WriteLine("Выполнить операцию “+”");
            Console.WriteLine("выполнить операцию “-”");
            Console.WriteLine("выполнить операцию “*”");
            Console.WriteLine("выполнить операцию “/”");

            int A = 0, B = 0, vibor = 0;
            bool sost = true;

            Console.Write("Введите номер команды - ");
            vibor = int.Parse(Console.ReadLine());

            do
            {
                switch (vibor)
                {
                    case 3:
                        A += B;
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
