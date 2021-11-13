

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using Mitras.Core.Entities;

namespace EES.Entities.Concrete
{
	public class Department : IEntity
	{
		public Department()
		{
		   
		}
		[Key]
		public virtual int DepartmentId {  get; set; }
		 
		public virtual string DepartmentName {  get; set; }
						 
	}
}




