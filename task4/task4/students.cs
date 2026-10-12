using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class students
    {
        public string name;
        public int age;
        public int grade;
        public students(string studentname, int studentage, int studentgrade)
        {
            name = studentname;
            age = studentage;
            grade = studentgrade;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("name: "+name); 
            Console.WriteLine("Age: "+age);
            Console.WriteLine("Grade: " + grade);
        }
    }
}
