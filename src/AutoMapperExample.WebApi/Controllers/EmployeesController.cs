using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using AutoMapperExample.WebApi.Data;
using AutoMapperExample.WebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperExample.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IMapper _mapper;

        public EmployeesController(ApplicationDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("projectTo")]
        public IEnumerable<EmployeeViewModel> GetAllEmployees()
            => _context.Employees.ProjectTo<EmployeeViewModel>(_mapper.ConfigurationProvider).ToList();
        
        [HttpGet("map")]
        public IEnumerable<EmployeeViewModel> GetAllEmployeesToList()
            => _mapper.Map<IEnumerable<EmployeeViewModel>>(_context.Employees.ToList());
        
        [HttpGet("map/{id:int}")]
        public EmployeeViewModel GetAllEmployeeByIdMap(int id)
        {
            var employee = _context.Employees.Where(e => e.Id == id).Select(e =>new EmployeeViewModel{
                Id = e.Id,
                Name = e.FirstName + " " + e.LastName,
                Role = e.Role.ToString(),
                Sector = e.Sector.Name
            }).FirstOrDefault();
            return employee;
        }
         

        [HttpGet("projectTo/{id:int}")]
        public EmployeeViewModel GetAllEmployeeByIdProject(int id)
        {
            return _context.Employees.Where(e => e.Id == id).ProjectTo<EmployeeViewModel>(_mapper.ConfigurationProvider).FirstOrDefault();
            
        }
    }
}