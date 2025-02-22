using Azure;
using ConsoleApp1.Contexts;
using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            using AppDbContext context = new AppDbContext();

            #region Loading Navigational
            //var Department = new List<Department>()
            //{
            //    new Department(){Name = "HR"},
            //     new Department(){Name = "PR"},
            //     new Department(){Name = "IT"}
            //};

            //var employees = new List<Employee>()
            //{
            //   new Employee() {Name = "Ahmed Ali", Addres = "Cairo",  Age =29,Salary = 12000, DeptId = 130},
            //   new Employee() { Name = "Omar Ali", Addres = "Giza", Age =32, Salary =15000, DeptId = 130 },
            //   new Employee() { Name = "Mona Ali", Addres = "Cairo", Age= 25, Salary =13000, DeptId = 130 },
            //   new Employee() { Name = "Ahmed Khaled", Addres= "Nasr City", Age =30, Salary= 17000, DeptId = 140 },
            //    new Employee() { Name =  "Mariam Ahmed", Addres ="Alex", Age= 24, Salary = 10000, DeptId = 140 },
            //   new Employee() { Name = "Maha Ahmed", Addres = "Alex", Age= 25, Salary= 14000, DeptId = 150 },
            //   new Employee(){Name = "Mohamed Ali", Addres = "Cairo", Age =33, Salary = 18000, DeptId = 150},
            //};

            //context.AddRange(Department);
            //context.AddRange(employees);

            //context.SaveChanges();

            //var employee = context.Employees.FirstOrDefault(E => E.Id == 800);
            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Age ?? 0);
            //Console.WriteLine(employee?.Salary ?? 0.0f);
            //Console.WriteLine(employee?.Addres ?? "NA");
            //Console.WriteLine(employee?.HiringDate ?? DateTime.UtcNow); 
            //Console.WriteLine(employee?.Workfor?.Name ?? "NA");

            //var Department = context.Departments.FirstOrDefault(D => D.Id == 130);
            //Console.WriteLine(Department.Name);
            //foreach (var item in Department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //}

            // Note EF Core Don`t Loading Any Navigational Proprity

            // EF Core Loading Navigational Proprity
            //1. Explicit Loading
            //2. Eager Loading
            //3. Lazing Loading

            #region  Explicit Loading

            //1. Explicit Loading


            //var employee = context.Employees.FirstOrDefault(E => E.Id == 800);
            ////context.Entry(employee).Reference("Workfor").Load();// Explicit Loading
            //// context.Entry(employee).Reference(nameof(Employee.Workfor)).Load();
            //context.Entry(employee).Reference(E => E.Workfor).Load();
            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Age ?? 0);
            //Console.WriteLine(employee?.Salary ?? 0.0f);
            //Console.WriteLine(employee?.Addres ?? "NA");
            //Console.WriteLine(employee?.HiringDate ?? DateTime.UtcNow);
            //Console.WriteLine(employee?.Workfor?.Name ?? "NA");


            //var Department = context.Departments.FirstOrDefault(D => D.Id == 130);
            //context.Entry(Department).Collection( D=> D.Employees).Load();
            //Console.WriteLine(Department.Name);
            //foreach (var item in Department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //} 
            #endregion


            #region Eager Loading
            //2. Eager Loading

            //var employee = context.Employees.Include( E => E.Workfor).FirstOrDefault(E => E.Id == 800);
            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Age ?? 0);
            //Console.WriteLine(employee?.Salary ?? 0.0f);
            //Console.WriteLine(employee?.Addres ?? "NA");
            //Console.WriteLine(employee?.HiringDate ?? DateTime.UtcNow);
            //Console.WriteLine(employee?.Workfor?.Name ?? "NA");

            //var Department = context.Departments.Include( D => D.Employees).ThenInclude( E => E.Id)
            //                                     .FirstOrDefault(D => D.Id == 130);
            //Console.WriteLine(Department.Name);
            //foreach (var item in Department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //} 
            #endregion

            #region Lazing Loading
            //3. Lazing Loading
            //3.1.  Install Package Proxies 
            //3.2. Update OnConfiguring() , Use UseLazyLoadingProxies
            //3.3. Make All Entity Public
            //3.4 Make All Navogational Properties Virtual


            //var employee = context.Employees.FirstOrDefault(E => E.Id == 800);
            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Age ?? 0);
            //Console.WriteLine(employee?.Salary ?? 0.0f);
            //Console.WriteLine(employee?.Addres ?? "NA");
            //Console.WriteLine(employee?.HiringDate ?? DateTime.UtcNow);
            //Console.WriteLine(employee?.Workfor?.Name ?? "NA");

            //var Department = context.Departments.FirstOrDefault(D => D.Id == 130);
            //Console.WriteLine(Department.Name);
            //foreach (var item in Department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //} 
            #endregion
            #endregion


            #region Join OPerators - Join Inner

            // Join OPerators - Join Inner

            //// Fluent Syntax
            //var result = context.Employees.Join(context.Departments, E => E.DeptId, D => D.Id, (E, D) => new
            //{
            //    EmpId = E.Id,
            //    EmpName = E.Name,
            //    DeptId = D.Id,
            //    DeptName = D.Name
            //}).Where( D=> D.DeptName == "HR");

            //// Query Expertion

            //result = from E in context.Employees
            //         join D in context.Departments
            //         on E.DeptId equals D.Id
            //         where D.Name == "HR"
            //         select new
            //         {
            //             EmpId = E.Id,
            //             EmpName = E.Name,
            //             DeptId = D.Id,
            //             DeptName = D.Name
            //         };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Tracking vs NoTracking 
            //// Tracking vs NoTracking 
            //// Tracking 

            //var result = context.Employees.AsNoTracking().FirstOrDefault(E => E.Id == 10);
            //Console.WriteLine(context.Entry(result).State); // Unchanged 
            //result.Name = "Ali"; // Local 
            //Console.WriteLine(context.Entry(result).State); // Modified 
            //Console.WriteLine(result.Name);
            //context.SaveChanges(); // Remotly 
            #endregion


            #region Remotly Vs Local
            //Remotly Vs Local

            //Remotly
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();

            //Local
            //context.Employees.Load();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any(); 
            #endregion

            




        }

    }
}
