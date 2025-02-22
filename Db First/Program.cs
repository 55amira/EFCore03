using Db_First.Data.Contexts;
using Db_First.Data.Model;

namespace Db_First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scaffold-DbContext "Server = DESKTOP-LA0JIU9\MSSQLSERVER01; Database = Demo; Trusted_Connection = True;TrustServerCertificate = True"
            // Microsoft.EntityFrameworkCore.SqlServer

           // using AppDbContext context = new AppDbContext();
            //Category category = new Category()
            //{
            //    CategoryName = "Hamda",
            //     Description = "Hamda",
            //};
            //context.Categories.Add(category);
            //context.SaveChanges();
           

            //var Result = context.Categories.ToList(); 
            //foreach (var item in Result) 
            //{ 
            //Console.WriteLine(item.CategoryName);
            //} 
            
             // Run SQL Query 
             // 1. Select Statments: FromSqlRaw(), FromSqlInterploated() 
             // 2. DML Statments [Update Insert Delete]: ExecuteSqlRaw(), ExecuteSqlInterploated()

        }
    }
}
