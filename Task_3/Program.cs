using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 3
//Користувач з клавіатури вводить шестизначне число. 
//Необхідно перевернути число і відобразити результат. 
//Наприклад, якщо введено 341256, результат 652143.

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the six digits integer number:");
            string str= Console.ReadLine();
            if (str.Length != 6)
            {
                Console.WriteLine("Error! The number is not correct!");
            }
            else
            {
                int num = Convert.ToInt32(str);
                //Console.WriteLine(num);
                int n1 = num % 10;
                int n2 = num / 10 % 10;
                int n3 = num / 100 % 10;
                int n4 = num / 1000 % 10;
                int n5 = num / 10000 % 10;
                int n6 = num / 100000;
                Console.WriteLine($"{n1}{n2}{n3}{n4}{n5}{n6}");
                //Console.WriteLine(n1*100000+n2*10000+n3*1000+n4*100+n5*10+n6);
            }           
        }
    }
}
