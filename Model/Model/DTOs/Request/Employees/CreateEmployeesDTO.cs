﻿using System.ComponentModel.DataAnnotations;

namespace indigyTestProject.Model.Model.DTOs.Request.Employees
{
    public class CreateEmployeesDTO
    {
        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; } = null!;
        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; } = null!;
        [Required(ErrorMessage = "Designation is required")]
        public string Designation { get; set; } = null!;
        [Required(ErrorMessage = "HireDate is required")]
        public DateTime HireDate { get; set; }
        [Required(ErrorMessage = "Salary is required")]
        public int Salary { get; set; }
        [Required(ErrorMessage = "Comm is required")]
        public string Comm { get; set; }
        [Required(ErrorMessage = "DeptNo is required")]
        public int DeptNo { get; set; }
    }
}
