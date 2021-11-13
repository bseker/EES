

using FluentNHibernate.Mapping;
 
using EES.Entities.Concrete;
        
namespace EES.DataLayer.Concrete.NHibernate.Mappings
{
    public class EvaluationQuestionMap : ClassMap<EvaluationQuestion>
    {
        public EvaluationQuestionMap()
        {
            Schema(@"dbo");

            Table(@"EvaluationQuestions");

            LazyLoad();

         
            Id(x => x.QuestionId).Column("QuestionId");
        
         
            Map(x => x.QuestionText).Column("QuestionText");
         
            Map(x => x.QuestionWeight).Column("QuestionWeight");
         
            Map(x => x.RoleId).Column("RoleId");
                   
        }
    }
}
