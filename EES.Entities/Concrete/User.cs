

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using Mitras.Core.Entities;

namespace EES.Entities.Concrete
{
	public class User : IEntity
	{
		public User()
		{
		   
		}
		[Key]
		public virtual int UserId {  get; set; }
		 
		public virtual string email {  get; set; }
		 
		public virtual string UserRole {  get; set; }
		 
		public virtual int EmployeeId {  get; set; }
						 
	}
}




