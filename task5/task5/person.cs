using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class person
    {
        public string name;
        public int Age { get; set;}
        private string internalCode { get; set; } //it can't be accsessed outside person beacuse has private access modifier
        protected string SchoolName { get; set;}
        public void DisplayInfo()
        {
           Console.WriteLine($"Name: {name}, Age: {Age}");
        }
    }
}
