

using FluentNHibernate.Mapping;
 
using EES.Entities.Concrete;
        
namespace EES.DataLayer.Concrete.NHibernate.Mappings
{
    public class EvaluationMap : ClassMap<Evaluation>
    {
        public EvaluationMap()
        {
            Schema(@"dbo");

            Table(@"Evaluation");

            LazyLoad();

         
            Id(x => x.EvaluationId).Column("EvaluationId");
        
         
            Map(x => x.Year).Column("Year");
         
            Map(x => x.CommentId).Column("CommentId");
         
            Map(x => x.ScoreId).Column("ScoreId");
         
            Map(x => x.EmployeeId).Column("EmployeeId");
                   
        }
    }
}
