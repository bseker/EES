

using FluentNHibernate.Mapping;
 
using EES.Entities.Concrete;
        
namespace EES.DataLayer.Concrete.NHibernate.Mappings
{
    public class EvaluationScoreMap : ClassMap<EvaluationScore>
    {
        public EvaluationScoreMap()
        {
            Schema(@"dbo");

            Table(@"EvaluationScore");

            LazyLoad();

         
            Id(x => x.ScoreId).Column("ScoreId");
        
         
            Map(x => x.Score).Column("Score");
                   
        }
    }
}
