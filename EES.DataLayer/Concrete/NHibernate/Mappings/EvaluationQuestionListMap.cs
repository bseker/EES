

using FluentNHibernate.Mapping;
 
using EES.Entities.Concrete;
        
namespace EES.DataLayer.Concrete.NHibernate.Mappings
{
    public class EvaluationQuestionListMap : ClassMap<EvaluationQuestionList>
    {
        public EvaluationQuestionListMap()
        {
            Schema(@"dbo");

            Table(@"EvaluationQuestionList");

            LazyLoad();

         
            Id(x => x.Id).Column("Id");
        
         
            Map(x => x.QuestionId).Column("QuestionId");
         
            Map(x => x.EvaluationId).Column("EvaluationId");
                   
        }
    }
}
