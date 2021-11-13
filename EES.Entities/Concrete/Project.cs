

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using Mitras.Core.Entities;

namespace EES.Entities.Concrete
{
	public class Project : IEntity
	{
		public Project()
		{
		   
		}
		[Key]
		public virtual int ProjectId {  get; set; }
		 
		public virtual string ProjectName {  get; set; }
						 
	}
}




