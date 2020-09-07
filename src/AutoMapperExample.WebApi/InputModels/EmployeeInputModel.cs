using System;

namespace AutoMapperExample.WebApi.InputModels
{
    public class EmployeeInputModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public Guid SectorId { get; set; }

    }
}