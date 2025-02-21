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
    internal class DepartmentCofigruation : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D => D.Id).UseIdentityColumn(100, 10);
            builder.Property(D => D.Name).HasColumnName("DeptName")
                                                         .HasMaxLength(100).
                                                         HasColumnType("varchar");
        }
    }
}
