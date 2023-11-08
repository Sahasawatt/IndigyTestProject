namespace indigyTestProject.Model.Model.DTOs.Response.Employees
{
    public class EmployeesResponseDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Designation { get; set; } = null!;
        public DateTime HireDate { get; set; }
        public int Salary { get; set; }
        public string Comm { get; set; }
        public int DeptNo { get; set; }
    }
}
