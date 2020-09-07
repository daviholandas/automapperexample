using AutoMapperExample.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoMapperExample.WebApi.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options){}
        public ApplicationDBContext(){}

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Sector> Sectors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sector>().HasData(new Sector(1,"Development"));
            modelBuilder.Entity<Employee>().HasData(new Employee(1, "Davi", "Holanda", Roles.Developer, 1));
            modelBuilder.Entity<Employee>().HasData(new Employee(2, "Alberto", "Monteiro", Roles.TeamLeader, 1));
        }

    }
}