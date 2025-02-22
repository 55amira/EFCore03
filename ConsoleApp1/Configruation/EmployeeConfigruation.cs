using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Configruation
{
    internal class EmployeeConfigruation : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(E => E.Id).UseIdentityColumn(100, 100);
            builder.Property(E => E.Name).HasColumnName("EmpName")
                                                         .HasColumnType("varchar")
                                                         .HasMaxLength(100);
            builder.Property(E => E.Salary).HasColumnType("money");
            builder.Property( E => E.Addres).HasColumnType("varchar").HasMaxLength(100);

            builder.HasOne(E => E.Workfor)
                   .WithMany(D => D.Employees)
                   .HasForeignKey(E => E.DeptId);
        }
    }
}
