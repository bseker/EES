

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using Mitras.Core.Entities;

namespace EES.Entities.Concrete
{
	public class SystemMode : IEntity
	{
		public SystemMode()
		{
		   
		}
		[Key]
		public virtual int ModeId {  get; set; }
		 
		public virtual string ModeName {  get; set; }
		 
		public virtual bool? IsCurrentSystemMode {  get; set; }
						 
	}
}




