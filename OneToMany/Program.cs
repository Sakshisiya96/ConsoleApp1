using College;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToMany
{
    public class Program
    {
        static void Main(string[] args)
        {
            StudentE studentE = new StudentE();
            studentE.Name = "Alice Smith";
            studentE.Email = "Alic@gmai.com";
            studentE.RollNumber = 102;
            studentE.Examinations=new List<Examination>();
            studentE.Examinations.Add(new Examination() { ExamName = "Maths", Month = 5, Year = 2023, MaxMarks = 100, SecuredMarks = 95 });
            Console.WriteLine($"Roll Number: {studentE.RollNumber}");
            Console.WriteLine($"Name: {studentE.Name}");
            Console.WriteLine($"Email: {studentE.Email}");
            foreach (var exam in studentE.Examinations)
            {
                Console.WriteLine($"Exam Name: {exam.ExamName}");
                Console.WriteLine($"Month: {exam.Month}");
                Console.WriteLine($"Year: {exam.Year}");
                Console.WriteLine($"Max Marks: {exam.MaxMarks}");
                Console.WriteLine($"Secured Marks: {exam.SecuredMarks}");
            }



        }
    }
}
