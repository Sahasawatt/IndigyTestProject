using indigyTestProject.Core.Interface.Service;
using indigyTestProject.Model.Model.DTOs.Request;
using indigyTestProject.Model.Model.DTOs.Request.Employees;
using indigyTestProject.Model.Model.DTOs.Response;
using indigyTestProject.Model.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace indigyTestProject.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesService _employeesService;

        public EmployeesController(IEmployeesService employeesService)
        {
            _employeesService = employeesService;
        }

        [HttpPost("Create")]
        public async Task<ActionResult<ResponseDTO<Employee>>> Create([FromForm] CreateEmployeesDTO employee)
        {
            var result = await _employeesService.Create(employee);
            return new ResponseDTO<Employee>(200 , "successful" , result);
        }

        [HttpGet("List")]
        public async Task<ActionResult<ResponseWithCountDTO<List<Employee>>>> List([FromQuery] ListRequsetDTO body)
        {
            var result = await _employeesService.List(body);
            return new ResponseWithCountDTO<List<Employee>>(200 , "successful" , result.Item1 , result.Item2);
        }

        [HttpGet("GetById")]
        public async Task<ActionResult<ResponseDTO<Employee>>> GetById(int id)
        {
            var result = await _employeesService.GetById(id);
            if(result == null)
                return new BadRequestObjectResult(new ResponseDTO<Employee?>(400 , "not found" , null));
            return new ResponseDTO<Employee>(200 , "successful" , result);
        }

        [HttpPut("Update")]
        public async Task<ActionResult<ResponseDTO<Employee>>> Update(UpdateEmployeesRequestDTO employee)
        {
            var result = await _employeesService.Update(employee);
            if(result == null)
                return new BadRequestObjectResult(new ResponseDTO<Employee?>(400 , "not found" , null));
            return new ResponseDTO<Employee>(200 , "successful" , result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ResponseDTO<string>>> Delete(int id)
        {
            var result = await _employeesService.Delete(id);
            if(result == null)
                return new BadRequestObjectResult(new ResponseDTO<string?>(400 , "not found" , ""));
            return new ResponseDTO<string>(200 , "successful" , result.Id.ToString());
        }

    }
}
