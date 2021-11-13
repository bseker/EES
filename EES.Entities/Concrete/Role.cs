

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using Mitras.Core.Entities;

namespace EES.Entities.Concrete
{
	public class Role : IEntity
	{
		public Role()
		{
		   
		}
		[Key]
		public virtual int RoleId {  get; set; }
		 
		public virtual string RoleName {  get; set; }
						 
	}
}




