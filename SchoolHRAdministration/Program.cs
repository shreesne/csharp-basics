using HRAdministrationAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;

namespace SchoolHRAdministration
{
    public enum EmployeeType
    {
        Teacher,
        HeadOfDepartment,
        DeputyHeadMaster,
        Headmaster
    }

    class Program
    {
        static void Main(string[] args)
        {
            decimal totalSalaries = 0;
            List<IEmployee> employees = new List<IEmployee>();
            SeedData(employees);

            //foreach (IEmployee employee in employees)
            //{
            //    totalSalaries += employee.Salary;
            //}

            //Console.WriteLine($"Total Annual Salaries(including bonus):{totalSalaries}");

            Console.WriteLine($"Total Annual Salaries(including bonus):{employees.Sum(e => e.Salary)}");
            Console.ReadKey();
        }

        public static void SeedData(List<IEmployee> employees)
        {
            IEmployee teacher1 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 1, "Bob", "Fisher", 40000);
            employees.Add(teacher1);

            IEmployee teacher2 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 2, "Jenny", "Thomas", 40000);
            employees.Add(teacher2);

            IEmployee headOfDepartment = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadOfDepartment, 3, "Tom", "Fisher", 50000);
            employees.Add(headOfDepartment);

            IEmployee deputyHeadMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.DeputyHeadMaster, 4, "Hbb", "Fisher", 60000);
            employees.Add(deputyHeadMaster);

            IEmployee headMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.Headmaster, 5, "Kob", "Fister", 80000);
            employees.Add(headMaster);

            //        IEmployee teacher1 = new Teacher
            //        {
            //            Id = 1,
            //            FirstName = "Bob",
            //            LastName = "Fisher",
            //            Salary = 40000
            //        };
            //        employees.Add(teacher1);

            //        IEmployee teacher2 = new Teacher
            //        {
            //            Id = 2,
            //            FirstName = "Jenny",
            //            LastName = "Thomas",
            //            Salary = 40000
            //        };
            //        employees.Add(teacher2);



            //        IEmployee headOfDepartment = new HeadOfDepartment
            //        {
            //            Id = 3,
            //            FirstName = "Tom",
            //            LastName = "Fisher",
            //            Salary = 50000
            //        };
            //        employees.Add(headOfDepartment);

            //        IEmployee deputyHeadMaster = new DeputyHeadMaster
            //        {
            //            Id = 4,
            //            FirstName = "Hbb",
            //            LastName = "Fisher",
            //            Salary = 60000
            //        };
            //        employees.Add(deputyHeadMaster);


            //        IEmployee headMaster = new HeadMaster
            //        {
            //            Id = 5,
            //            FirstName = "Kob",
            //            LastName = "Fister",
            //            Salary = 80000
            //        };
            //        employees.Add(headMaster);
            //    }
        }

        public class Teacher : EmployeeBase
        {
            public override decimal Salary
            {
                get => base.Salary + (base.Salary * 0.02m);
            }
        }
        public class HeadOfDepartment : EmployeeBase
        {
            public override decimal Salary { get => base.Salary + (base.Salary * 0.03m); }
        }
        public class DeputyHeadMaster : EmployeeBase
        {
            public override decimal Salary { get => base.Salary + (base.Salary * 0.04m); }
        }
        public class HeadMaster : EmployeeBase
        {
            public override decimal Salary { get => base.Salary + (base.Salary * 0.05m); }

        }

        public static class EmployeeFactory
        {
            public static IEmployee GetEmployeeInstance(EmployeeType employeeType, int id, string firstName, string lastName, decimal salary)
            {
                IEmployee employee = null;

                switch (employeeType)
                {
                    case EmployeeType.Teacher:
                        employee = new Teacher { Id = id, FirstName = firstName, LastName = lastName, Salary = salary };
                        break;
                    case EmployeeType.HeadOfDepartment:
                        employee = new HeadOfDepartment { Id = id, FirstName = firstName, LastName = lastName, Salary = salary };
                        break;
                    case EmployeeType.DeputyHeadMaster:

                        employee = new DeputyHeadMaster { Id = id, FirstName = firstName, LastName = lastName, Salary = salary };
                        break;
                    case EmployeeType.Headmaster:
                        employee = new HeadMaster { Id = id, FirstName = firstName, LastName = lastName, Salary = salary };
                        break;
                    default:
                        break;
                }
                return employee;
            }
        }

    }
}