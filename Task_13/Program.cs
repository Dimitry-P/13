using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    internal class Program
    {
        //•	Задача 13: Напишите программу, которая делит число на два и выводит результат.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            string number = Console.ReadLine();
            float result = float.Parse(number);
            Console.WriteLine("Результат: "+result/2);
        }
    }
}
