using College;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.RollNumber = 101;   
            student.Name = "John Doe";
            student.Email = "john.doe@example.com"; 
            student.Branch = new Branch();
            student.Branch.BranchName = "Computer Science";
            student.Branch.NoOfSemesters = 8;
            Console.WriteLine($"Roll Number: {student.RollNumber}");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Email: {student.Email}");
            Console.WriteLine($"Branch Name: {student.Branch.BranchName}");
            Console.WriteLine($"Number of Semesters: {student.Branch.NoOfSemesters}");
        }
    }
}
