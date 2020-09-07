using System;

namespace AutoMapperExample.WebApi.Models
{
    public class Employee
    {
        public Employee(int id, string firstName, string lastName, Roles role, int sectorId)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            SectorId = sectorId;
        }

        private Employee(){}

        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Roles Role { get; private set; }
        public Sector Sector { get; private set; }

        //EF
        public int SectorId { get; private set; }
    }
}