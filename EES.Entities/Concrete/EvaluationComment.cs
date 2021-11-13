

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using Mitras.Core.Entities;

namespace EES.Entities.Concrete
{
	public class EvaluationComment : IEntity
	{
		public EvaluationComment()
		{
		   
		}
		[Key]
		public virtual int CommentId {  get; set; }
		 
		public virtual string CommentType {  get; set; }
		 
		public virtual string CommentText {  get; set; }
						 
	}
}




