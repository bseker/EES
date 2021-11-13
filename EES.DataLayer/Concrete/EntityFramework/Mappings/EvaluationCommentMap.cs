using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EES.Entities.Concrete;

namespace EES.DataLayer.Concrete.EntityFramework.Mappings
{
    public class EvaluationCommentMap : EntityTypeConfiguration<EvaluationComment>
    {
        public EvaluationCommentMap()
        {
            HasKey(x => x.CommentId);
        }
    }
}
