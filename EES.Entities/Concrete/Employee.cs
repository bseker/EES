

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using Mitras.Core.Entities;

namespace EES.Entities.Concrete
{
	public class Employee : IEntity
	{
		public Employee()
		{
		   
		}
		[Key]
		public virtual int EmployeeId {  get; set; }
		 
		public virtual string Name {  get; set; }
		 
		public virtual string Surname {  get; set; }
		
		public virtual int? IdNumber { get; set; }

		public virtual int? DepartmentId {  get; set; }
		 
		public virtual int? SupervisorId {  get; set; }
						 
	}
}




