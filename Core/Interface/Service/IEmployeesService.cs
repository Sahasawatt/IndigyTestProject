using indigyTestProject.Model.Model.DTOs.Request;
using indigyTestProject.Model.Model.DTOs.Request.Employees;

using indigyTestProject.Model.Model.Entities;

namespace indigyTestProject.Core.Interface.Service
{
    public interface IEmployeesService
    {
        Task<Employee> Create(CreateEmployeesDTO employees);

        Task<Tuple<int, List<Employee>>> List(ListRequsetDTO body);

        Task<Employee?> GetById(int id);

        Task<Employee?> Update(UpdateEmployeesRequestDTO employee);

        Task<Employee?> Delete(int id);
    }
}
