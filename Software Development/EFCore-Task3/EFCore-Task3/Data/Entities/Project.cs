﻿using System.ComponentModel.DataAnnotations;

namespace EFCore_Task3.Data.Entities
{
    public class Project
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public List<EmployeeProject> EmployeeProjects { get; set; }
    }
}
