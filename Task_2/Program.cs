using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
//Завдання 2
//Користувач вводить з клавіатури п'ять чисел.
//Необхідно знайти суму чисел, максимум і мінімум з п'яти чисел,
//добуток чисел. Результат обчислень вивести на екран.

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter the {i+1} number");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int Summ = 0, Max = arr[0], Min = arr[1], Mult = 1;
            foreach (int k in arr)
            {
                Summ += k;
                Mult *= k;
                if (k > Max) Max = k;
                if (k < Min) Min = k;
            }
            Console.WriteLine($"The numbers Summ = {Summ}");
            Console.WriteLine($"The Product of numbers = {Mult}");
            Console.WriteLine($"The Min number = {Min}");
            Console.WriteLine($"The Max number = {Max}");

        }
    }
}
