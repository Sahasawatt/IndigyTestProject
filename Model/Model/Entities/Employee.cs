using System.ComponentModel.DataAnnotations;

namespace indigyTestProject.Model.Model.Entities
{
    public partial class Employee
    {
        public int EMPNO { get; set; }
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;
        public string Designation { get; set; } = null!;
        public DateTime HireDate { get; set; }
        public int Salary { get; set; }
        public string Comm { get; set; } = null!;
        public int DeptNo { get; set; }
    }
}
