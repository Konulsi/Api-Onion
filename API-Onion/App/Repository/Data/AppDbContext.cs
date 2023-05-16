using Domain.Confirugations;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.ApplyConfiguration(new EmployeeConfiguration()); //comfiguration etdiyimizi bildiririk. yeni bu shertlerden add elesin databazaya.
            // modelBuilder.ApplyConfiguration(new CountryConfiguration());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //tek-tek configuration etdityimizi bildirmemek uchun bele yaziriq.


            modelBuilder.Entity<Employee>().HasData(
                  new Employee
                  {
                      Id = 1,
                      FullName = "Anar Aliyev",
                      Address = "Xetai",
                      Age = 28,
                  },

                   new Employee
                   {
                       Id = 2,
                       FullName = "Fuad Aliyev",
                       Address = "Nesimi",
                       Age = 26,
                   },

                    new Employee
                    {
                        Id = 3,
                        FullName = "Konul Ibrahimova",
                        Address = "Neftchiler",
                        Age = 27,
                    });

            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Azerbaycan"
                },
                new Country
                {
                    Id = 2,
                    Name = "Turkiye"
                }, new Country
                {
                    Id = 3,
                    Name = "Gurcustan"
                });

        }
    }
}
