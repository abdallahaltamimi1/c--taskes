using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Student : person
    {
        public int Grade { get; set; }
        public int StudentId { get; set; }

        void DisplayStudentname()
        {
            Console.WriteLine($"Student Name: {SchoolName}");
        }

    }
}
