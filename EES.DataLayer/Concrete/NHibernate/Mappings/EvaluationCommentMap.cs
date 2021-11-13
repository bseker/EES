

using FluentNHibernate.Mapping;
 
using EES.Entities.Concrete;
        
namespace EES.DataLayer.Concrete.NHibernate.Mappings
{
    public class EvaluationCommentMap : ClassMap<EvaluationComment>
    {
        public EvaluationCommentMap()
        {
            Schema(@"dbo");

            Table(@"EvaluationComments");

            LazyLoad();

         
            Id(x => x.CommentId).Column("CommentId");
        
         
            Map(x => x.CommentType).Column("CommentType");
         
            Map(x => x.CommentText).Column("CommentText");
                   
        }
    }
}
