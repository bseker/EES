

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using Mitras.Core.Entities;

namespace EES.Entities.Concrete
{
	public class EvaluationQuestionList : IEntity
	{
		public EvaluationQuestionList()
		{
		   
		}
		[Key]
		public virtual int Id {  get; set; }
		 
		public virtual int? QuestionId {  get; set; }
		 
		public virtual int? EvaluationId {  get; set; }
		public virtual int? GivenRating { get; set; }

	}
}




