using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your birthday date is: {GetBirthdayDate(age + 1)} or  {GetBirthdayDate(age)}");

            Console.ReadKey();
        }

        static int GetBirthdayDate(int age)
        {
            return DateTime.Now.Year - age;
        }
    }
}
