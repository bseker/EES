

using System;
using System.Collections.Generic;
using System.Configuration;
using Mitras.Core.Entities;

namespace EES.Entities.Concrete
{
	public class EvaluationScore : IEntity
	{
		public EvaluationScore()
		{
		   
		}
		 
			public virtual int ScoreId {  get; set; }
		 
			public virtual decimal? Score {  get; set; }
						 
	}
}




