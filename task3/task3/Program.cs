using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Guessing Game");
            //Console.WriteLine();
            //Console.WriteLine("Game Rules:");
            //Console.WriteLine("1st attempt → 10 points");
            //Console.WriteLine("2nd attempt → 7 points");
            //Console.WriteLine("3rd attempt → 5 points");
            //Console.WriteLine("More than 3 attempts → 0 points");
            //Console.WriteLine();
            //int randomnumber = new Random().Next(50, 75);
            //Console.WriteLine(randomnumber);
            //int guessnumber = 0;
            //int count = 0;
            //int attempt = 0;
            //do
            //{
            //    if (count > 0 && guessnumber < randomnumber)
            //    {
            //        Console.WriteLine("Your guess is too low.");
            //    }
            //    else if (count > 0 && guessnumber > randomnumber)
            //    {
            //        Console.WriteLine("Your guess is too high.");
            //    }

            //    Console.WriteLine("Guess a number between 50 and 75");
            //    guessnumber = Convert.ToInt32(Console.ReadLine());
            //    count++;
            //} while (guessnumber != randomnumber);
            //Console.WriteLine($"Congratulations! You guessed the number {randomnumber} in {count} attempts.");
            //if (count == 1)
            //{
            //    attempt = 10;
            //    Console.WriteLine("1ST attempt  your score is " + attempt + "points");

            //}
            //else if (count == 2)
            //{
            //    attempt = 8;
            //    Console.WriteLine("2ND attempt  your score is " + attempt + "points");
            //}
            //else if (count == 3)
            //{
            //    attempt = 6;
            //    Console.WriteLine("3RD attempt  your score is " + attempt + "points");
            //}

            //else
            //{
            //    attempt = 0;
            //    Console.WriteLine("You have exceeded the maximum number of attempts. You scored " + attempt + " points.");
            //}

            Console.WriteLine("School System");
            Console.WriteLine();
            string[] students = { "Abdallah", "Mohammed", "Khalid", "Ahmed", "Al'a" };
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
            int[] grades = { 90, 85, 78, 92, 88 };
            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }
            Console.WriteLine("Enter a student name.");
            string studentName = Console.ReadLine();
            int index = 0;
            while (index < students.Length)
            {
                if (students[index] == studentName)
                {
                    Console.WriteLine($"Student found: {studentName}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Student not found: {studentName}");
                    break;
                }
                index++;
            }
            Console.WriteLine("Enter a student's grade.");
            int studentGrade = Convert.ToInt32(Console.ReadLine());
            switch (studentGrade)
            {
                case int n when (n >= 90):
                    Console.WriteLine("Excellent");
                    break;
                case int n when (n >= 80):
                    Console.WriteLine("Very Good");
                    break;
                case int n when (n >= 70):
                    Console.WriteLine("Good");
                    break;
                case int n when (n >= 60):
                    Console.WriteLine("Pass");
                    break;
                default:
                    Console.WriteLine("Fail");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("-----------------Main Menu--------------------");
            string choice;
            do
            {
                Console.WriteLine("1.Display Students");
                Console.WriteLine("2.Search for Student");
                Console.WriteLine("3.Check Student Result");
                Console.WriteLine("4. Exit");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Displaying Students:");
                        foreach (string student in students)
                        {
                            Console.WriteLine(student);
                        }
                        break;
                    case "2":
                        Console.WriteLine("Enter a student name to search:");
                        string searchName = Console.ReadLine();
                        int searchIndex = Array.IndexOf(students, searchName);
                        if (searchIndex >= 0)
                        {
                            Console.WriteLine($"Student found: {searchName}");
                        }
                        else
                        {
                            Console.WriteLine($"Student not found: {searchName}");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Enter a student's grade to check result:");
                        int checkGrade = Convert.ToInt32(Console.ReadLine());
                        switch (checkGrade)
                        {
                            case int n when (n >= 90):
                                Console.WriteLine("Excellent");
                                break;
                            case int n when (n >= 80):
                                Console.WriteLine("Very Good");
                                break;
                            case int n when (n >= 70):
                                Console.WriteLine("Good");
                                break;
                            case int n when (n >= 60):
                                Console.WriteLine("Pass");
                                break;
                            default:
                                Console.WriteLine("Fail");
                                break;
                        }
                        break;
                }
            }
            while (choice != "4");
            Console.WriteLine("You have exited the program.");

            }
        }
    }

