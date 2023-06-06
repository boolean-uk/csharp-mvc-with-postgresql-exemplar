﻿using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.api.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobName { get; set; }
        
        [ForeignKey("Salary")]
        public int SalaryFK { get; set; }
        public Salary Salary { get; set; }

        [ForeignKey("Department")]
        public int DepartmentFK { get; set; }
        public Department Department { get; set; }

    }
}
