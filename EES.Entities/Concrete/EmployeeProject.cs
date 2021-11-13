

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using Mitras.Core.Entities;

namespace EES.Entities.Concrete
{
	public class EmployeeProject : IEntity
	{
		public EmployeeProject()
		{
		   
		}
		[Key]
		public virtual int EmployeeProjectId {  get; set; }
		 
		public virtual int? EmployeeRoleId {  get; set; }
		 
		public virtual int? ProjectId {  get; set; }
						 
	}
}




