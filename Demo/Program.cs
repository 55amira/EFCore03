using Demo.Contexts;
using Demo.Models;
using System.Net;

namespace Demo
{
    internal class Program
    {
        static void Main()
        {
            using AppDbContext context = new AppDbContext();


            //FullTimeEmployee fullTime = new FullTimeEmployee()
            //{
            //    Name = "Ahmed Ali",
            //    Address = "Cairo",
            //    Email = "AhmedAli@gmail.com",
            //    Salary = 12000
            //};
            //FullTimeEmployee fullTime02 = new FullTimeEmployee()
            //{
            //    Name = "Ahmed Khaled",
            //    Address = "Cairo",
            //    Email = "AhmedKhaled@gmail.com",
            //    Salary = 15000
            //};
            //FullTimeEmployee fullTime03 = new FullTimeEmployee()
            //{
            //    Name = "Marim Ali",
            //    Address = "Giza",
            //    Email = "MarimAli@gmail.com",
            //    Salary = 12000
            //};
            //PartTimeEmployee partTime01 = new PartTimeEmployee()
            //{
            //    Name = "Mohamed Ahmed",
            //    Address = "Cairo",
            //    Email = "MohamedAhmed@gmail.com",
            //    NumberOfHour = 120,
            //    HourRate = 200
            //};
            //PartTimeEmployee partTime02 = new PartTimeEmployee()
            //{
            //    Name = "Maha Khaled",
            //    Address = "Alex",
            //    Email = "MahaKhaled@gmail.com",
            //    NumberOfHour = 200,
            //    HourRate = 300
            //};
            //PartTimeEmployee partTime03 = new PartTimeEmployee()
            //{
            //    Name = "Maraim Ahmed",
            //    Address = "Giza",
            //    Email = "MaraimAhmed@gmail.com",
            //    HourRate = 300,
            //    NumberOfHour = 100
            //};
            //context.Employees.Add(fullTime);
            //context.Employees.Add(fullTime02);
            //context.Employees.Add(fullTime03);
            //context.Employees.Add(partTime01);
            //context.Employees.Add(partTime02);
            //context.Employees.Add(partTime03);
            //context.SaveChanges(); // Remotly

            ////foreach (var item in context.Employees)
            ////{
            ////    Console.WriteLine(item.Name);
            ////}

            //var result = context.Employees.OfType < PartTimeEmployee>();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Name);
            //}

        }

        
    }
}
