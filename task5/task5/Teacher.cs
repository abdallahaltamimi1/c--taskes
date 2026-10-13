using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Teacher:person
    {
        public string Subject { get; set; }
      
        
        void DisplayTeacherinfo()
        {
            Console.WriteLine($"Teacher Name: {name}, Age: {Age}, Subject: {Subject}");
        }
    }
}
