

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using Mitras.Core.Entities;

namespace EES.Entities.Concrete
{
	public class Evaluation : IEntity
	{
		public Evaluation()
		{
		   
		}
		[Key]
		public virtual int EvaluationId {  get; set; }
		 
		public virtual int? Year {  get; set; }
		 
		public virtual int? CommentId {  get; set; }
		 
		public virtual double Score {  get; set; }
		 
		public virtual int? EmployeeId {  get; set; }
		public virtual int? SubmittedEmployeeId { get; set; }

	}
}




