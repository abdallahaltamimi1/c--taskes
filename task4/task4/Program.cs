using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            students student1 = new students("Abdallah", 26, 85);
           
            student1.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
            students student2 = new students("Ahmad", 20, 85);
            
            student2.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
            students student3 = new students("al'a", 18, 85);
           
            student3.DisplayInfo();

        }
    }
}
