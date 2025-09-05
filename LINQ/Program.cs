using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public int Salary { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){EmpId=101,Name="Herry",Job="Designer",Salary=4838},
                new Employee(){EmpId=102,Name="Jack",Job="Hr",Salary=5000},
                new Employee(){EmpId=103,Name="Gabreile",Job="Software",Salary=6000},
                new Employee(){EmpId=104,Name="Sak",Job="Manager",Salary=7000},
                new Employee(){EmpId=105,Name="Alexe",Job="Manager",Salary=8000},
            };//it will return IEnumerable<Employee>
            IEnumerable<Employee> managers = employees.Where(x => x.Job == "Manger").ToList();
            var orderedEmployees = employees.OrderBy(emp=>emp.Salary);//it will return IOrderedEnumerable<Employee>
            var orderedEmployeesDesc = employees.OrderByDescending(emp=>emp.Salary);//it will return IOrderedEnumerable<Employee>
            var orderedSecondOrder = employees.OrderBy(emp=>emp.Job).ThenBy(emp=>emp.Salary);//it will return IOrderedEnumerable<Employee>

            //Where
            var ManagerFromEmployeeWithWhere = employees.Where(x => x.Job == "Manager").ToList();
            Console.WriteLine("Where"+ManagerFromEmployeeWithWhere[0].EmpId);

            // First 
            Employee ManagerFirstEmployee = employees.First(x => x.Job == "Manager");
            Console.WriteLine("First"+ ManagerFirstEmployee.EmpId);

            //FirstOrDefault
            Employee ManagerFirstOrDefaultEmployee = employees.FirstOrDefault(x => x.Job == "Clerk");
            if (ManagerFirstOrDefaultEmployee != null)
            {
                Console.WriteLine("Clerk " + ManagerFirstOrDefaultEmployee.EmpId);

            }
            Console.WriteLine("No clerk Found");

            //USing where
            var ManagerLastEmployeeWithWhere = employees.Where(x => x.Job == "Manager").ToList();
            Console.WriteLine("Where" + ManagerLastEmployeeWithWhere[ManagerLastEmployeeWithWhere.Count - 1].EmpId);


            //Last
            Employee ManagerLastEmployee = employees.Last(x => x.Job == "Manager");
            Console.WriteLine("Last" + ManagerLastEmployee.EmpId);

            //LastOrDefault
            Employee ManagerLastOrDefaultEmployee = employees.LastOrDefault(x => x.Job == "Clerk");
            if (ManagerLastOrDefaultEmployee != null)
            {
                Console.WriteLine("LastOrDefault" + ManagerLastOrDefaultEmployee.EmpId);
            }
            else
            {
                Console.WriteLine("No clerk Found");
            }
                foreach (var emp in managers)
            {
                Console.WriteLine($"Employee Name: {emp.Name}, Job: {emp.Job}, City: {emp.Salary}, ID: {emp.EmpId}"   );
            }
        }
    }
}
