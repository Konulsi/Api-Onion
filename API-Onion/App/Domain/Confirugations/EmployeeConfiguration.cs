﻿using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Confirugations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee> //model qoydugumuz require veya bashqa shertleri burada yoxlayiriq
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(m => m.FullName).HasMaxLength(100).IsRequired(false);
            builder.Property(m => m.SoftDelete).IsRequired().HasDefaultValue(false);
            builder.Property(m => m.CreateAt).IsRequired().HasDefaultValue(DateTime.UtcNow);
            builder.Property(m => m.Address).IsRequired().HasMaxLength(100);
            builder.Property(m => m.Age).IsRequired();



        }
    }
}
