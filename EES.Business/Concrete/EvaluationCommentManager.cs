

using System.Linq;
using System.Collections.Generic;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.DataLayer.Abstract;
         

namespace EES.Business.Concrete
{
    public class EvaluationCommentManager : IEvaluationCommentService
    {
        private readonly IEvaluationCommentDal _evaluationcommentDal;

        public EvaluationCommentManager(IEvaluationCommentDal evaluationcommentDal)
        {
            this._evaluationcommentDal = evaluationcommentDal;;
        }

        public List<EvaluationComment> GetAll()
        {
            return _evaluationcommentDal.GetList();
        }

        public EvaluationComment GetById(int commentId)
        {
            return _evaluationcommentDal.Get(t=>t.CommentId==commentId);
        }

        public EvaluationComment Insert(EvaluationComment evaluationComment)
        {
            return _evaluationcommentDal.Add(evaluationComment);
        } 

        public EvaluationComment Update(EvaluationComment evaluationComment)
        {
            return _evaluationcommentDal.Update(evaluationComment);
        }

        public void Delete(int commentId)
        {
            var evaluationcomment = _evaluationcommentDal.Get(t=>t.CommentId==commentId);

            _evaluationcommentDal.Delete(evaluationcomment);
        }
    }
}