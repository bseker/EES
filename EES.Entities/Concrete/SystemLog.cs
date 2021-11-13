

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using Mitras.Core.Entities;

namespace EES.Entities.Concrete
{
	public class SystemLog : IEntity
	{
		public SystemLog()
		{
		   
		}
		[Key]
		public virtual int LogId {  get; set; }
		 
		public virtual int? UserId {  get; set; }
		 
		public virtual System.DateTime? DateTime {  get; set; }
		 
		public virtual int? LogTypeId {  get; set; }
						 
	}
}




