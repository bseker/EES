

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using Mitras.Core.Entities;

namespace EES.Entities.Concrete
{
	public class LogType : IEntity
	{
		public LogType()
		{
		   
		}
		[Key]
		public virtual int LogTypeId {  get; set; }
		 
		public virtual string LogTypeName {  get; set; }
						 
	}
}




