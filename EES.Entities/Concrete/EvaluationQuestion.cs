

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using Mitras.Core.Entities;

namespace EES.Entities.Concrete
{
	public class EvaluationQuestion : IEntity
	{
		public EvaluationQuestion()
		{
		   
		}
		[Key]
		public virtual int QuestionId {  get; set; }
		 
		public virtual string QuestionText {  get; set; }
		 
		public virtual int? QuestionWeight {  get; set; }
		 
		public virtual int? RoleId {  get; set; }
						 
	}
}




