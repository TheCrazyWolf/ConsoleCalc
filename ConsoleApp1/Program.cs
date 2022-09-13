using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Добро пожаловать в кукулятор v1");
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Какое действие вы хотите выполнить?");
            var enter = Console.ReadKey();
            char enter_key = enter.KeyChar;

            if(enter_key == '+')
            {
                Console.WriteLine(a + b);
            }
            else if(enter_key == '-')
            {
                Console.WriteLine(a - b);
            }
            else if(enter_key == '*')
            {
                Console.WriteLine(a * b);
            }
            else if(enter_key == '/')
            {
                Console.WriteLine(a / b);
            }
            else
            {
                Console.WriteLine("Неверно выбрано действие");
            }

            Console.WriteLine("Калькулятор успешно завершил работу!");


        }
    }
}
