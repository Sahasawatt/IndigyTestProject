
using indigyTestProject.Core.Interface.Service;
using indigyTestProject.Database;
using indigyTestProject.Model.Model.DTOs.Request;
using indigyTestProject.Model.Model.DTOs.Request.Employees;
using indigyTestProject.Model.Model.Entities;
using Mapster;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace indigyTestProject.Core.Service
{
    public class EmployeeService : IEmployeesService
    {
        private readonly DatabaseContext _databaseContext;


        public EmployeeService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public async Task<Employee> Create(CreateEmployeesDTO employees)
        {

            Employee newEmployee = new Employee
            {
                FirstName = employees.FirstName,
                LastName = employees.LastName,
                Designation = employees.Designation,
                HireDate = employees.HireDate,
                Salary = employees.Salary,
                Comm = employees.Comm,
                DeptNo = employees.DeptNo
            };
            _databaseContext.Employees.Add(newEmployee);
            await _databaseContext.SaveChangesAsync();
            return newEmployee;
        }

        public async Task<Employee?> Delete(int id)
        {
            var employeeToDelete = _databaseContext.Employees.AsQueryable().FirstOrDefault(x => x.Id == id);
            if(employeeToDelete == null)
            {
                return null;
            }
            _databaseContext.Employees.Remove(employeeToDelete);
            await _databaseContext.SaveChangesAsync();
            return employeeToDelete;
        }

        public async Task<Employee?> GetById(int id)
        {
            var employee = await _databaseContext.Employees.AsQueryable().FirstOrDefaultAsync(x => x.Id == id);
            if(employee == null)
            {
                return null;
            }
            return employee;

        }

        public async Task<Tuple<int, List<Employee>>> List(ListRequsetDTO body)
        {
            var employee = await _databaseContext.Employees.AsQueryable().Skip((body.page -1) * body.pageSize).Take(body.pageSize).ToListAsync();
            var count = await _databaseContext.Employees.AsQueryable().CountAsync();
            return new Tuple<int, List<Employee>>(count, employee);
        }

        public async Task<Employee?> Update(UpdateEmployeesRequestDTO employee)
        {
            var employeeToUpdate = _databaseContext.Employees.AsQueryable().FirstOrDefault(x => x.Id == employee.Id);
            if (employeeToUpdate == null)
            {
                return null;
            }
            employeeToUpdate.FirstName = employee.FirstName;
            employeeToUpdate.LastName = employee.LastName;
            employeeToUpdate.Designation = employee.Designation;
            employeeToUpdate.HireDate = employee.HireDate;
            employeeToUpdate.Salary = employee.Salary;
            employeeToUpdate.Comm = employee.Comm;
            employeeToUpdate.DeptNo = employee.DeptNo;

            _databaseContext.Employees.Update(employeeToUpdate);
            await _databaseContext.SaveChangesAsync();
            return employeeToUpdate;
        }
    }
}
