using System;
using System.Collections.Generic;
using System.Linq;

namespace ZacharySales.CodeLou.ExerciseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool AppRunning = true;
            List<Student> studentList = new List<Student>();
            
            
            while (AppRunning)
            {
                DisplayMenu();
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                    { Student.GetStudentInput(studentList); }

                else if (input == 2)
                    { DisplayStudents(studentList); }
                
                else if (input == 3)
                    { SearchStudents(studentList); }
                else
                { AppRunning = false;}   
            }
        }
         static void DisplayStudents(List<Student> studentList)
        {
            studentList.ForEach(s =>
            {
                Console.WriteLine(s.studentRecord);
            });
        }
        
         static void SearchStudents(List<Student> studentList) 
            {
                Console.WriteLine("Search String:");
                var searchString = Console.ReadLine();
                var students = studentList.Where(s => s.StudentName.Contains(searchString)).ToList();
                if (students.Any()) 
                {
                    students.ForEach(s =>
                    {
                        Console.WriteLine(s.studentRecord);
                    });
                }
            }
        
         static void DisplayMenu()
         {
            Console.WriteLine("Menu");
            Console.WriteLine("1. New Student");
            Console.WriteLine("2. List Students");
            Console.WriteLine("3. Find Student by name");
            Console.WriteLine("4. Exit");
         }
    }
}
