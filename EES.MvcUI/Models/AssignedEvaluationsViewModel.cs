using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EES.Entities.Concrete;

namespace EES.MvcUI.Models
{
    public class AssignedEvaluationsViewModel
    {
        public List<Employee> PeerEmployees { get; set; }

        public List<Employee> ProjectMembers { get; set; }

        public List<Employee> DepartmentWorkers { get; set; }

        public Employee Supervisor { get; set; }
    }
}