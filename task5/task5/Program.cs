using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person p = new person();
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();

            student1.name = "Abdallah";
            student1.Age = 26;
            student2.name = "Mohammad";
            student2.Age = 22;
            student3.name = "Ali";
            student3.Age = 21;
            Teacher teacher1 = new Teacher();
            teacher1.name = "Mr. Abdallah";
            teacher1.Age = 40;
            Teacher teacher2 = new Teacher();
            teacher2.name = "Mr. Mohammad";
            teacher2.Age = 35;
            
          
            student1.DisplayInfo();
            student2.DisplayInfo();
            student3.DisplayInfo();

            //p.internalCode = "12345"; // This line will cause a compilation error because internalCode is private
            //p.SchoolName= "ABC School"; // This line will cause a compilation error because SchoolName is protected
            SchoolReport report = new SchoolReport(); //another class cannot inherit from SchoolReport because it is sealed
            report.ReportTitle = "School Report";
            report.DisplayReportTitle();


        }
    }
}
