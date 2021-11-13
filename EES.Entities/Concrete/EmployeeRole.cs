

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using Mitras.Core.Entities;

namespace EES.Entities.Concrete
{
	public class EmployeeRole : IEntity
	{
		public EmployeeRole()
		{
		   
		}
		[Key]
		public virtual int EmployeeRoleId {  get; set; }
		 
		public virtual int? RoleId {  get; set; }
		 
		public virtual int? EmployeeId {  get; set; }
						 
	}
}




