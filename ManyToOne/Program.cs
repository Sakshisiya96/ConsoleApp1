using Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee em1 = new Employee() {
                Id = 1,
               Name = "Jane Doe",
               Email = "jane@gmail.com"
               
            };
            Employee em2 = new Employee()
            {
                Id = 2,
                Name = "John Smith",
                Email = "john@gmail.com"

            };
            Department dept = new Department()
            {
                DeptId = 101,
                DeptName = "Human Resources"
            };
            em1.Department = dept;
            em2.Department = dept;
            Console.WriteLine($"Employee 1: {em1.Name}, Email: {em1.Email}, Department: {em1.Department.DeptName}");
            Console.WriteLine($"Employee 2: {em2.Name}, Email: {em2.Email}, Department: {em2.Department.DeptName}");

        }
    }
}
