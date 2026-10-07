using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Average: ");
            double average = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your gender: ");
            string gender = Console.ReadLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Wellcom Mr:{name}");
            Console.WriteLine($"Your Name:{name}");
            Console.WriteLine($"Your Age:{age}");
            Console.WriteLine($"Your Grade:{grade}");
            Console.WriteLine($"Your Average:{average}");
            Console.WriteLine($"Your Gender:{gender}");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("to uppercase and lowercase");

            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name[0]);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("check Average");
            bool ispassed=false; 
            bool isadult=false;
            Console.Write("Enter your NewAverage: ");
            double newaverage = Convert.ToDouble(Console.ReadLine());
            if (average >= 50)
            {
               ispassed = true;
                Console.WriteLine("Passed");
            }
            else
                Console.WriteLine("Failed");

            if (age >= 18)
            {
                isadult=true;
                Console.WriteLine(newaverage);
                Console.WriteLine($"passed:{ispassed}");
                Console.WriteLine($"Adult{isadult}");

            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("---------------STUDENT SUMMARY---------------");

           Console.WriteLine($"Wellcom Mr:{name}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Your Age:{age}");
            Console.WriteLine($"Your Grade:{grade}");
            Console.WriteLine($"Your Average:{average}");
            Console.WriteLine($"Your NewAverage:{newaverage}");
            Console.WriteLine($"Your Gender:{gender}");
            Console.WriteLine($"passed:{ispassed}");
            Console.WriteLine($"Adult{isadult}");
        }
    }
}
