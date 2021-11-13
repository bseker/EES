using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EES.DataLayer.Abstract;
using EES.Entities.Concrete;
using EES.Entities.View;
using Mitras.Core.DataAccess.EntityFramework;

namespace EES.DataLayer.Concrete.EntityFramework
{
    public class EfEvaluationDal : EfEntityRepositoryBase<Evaluation,EesContext>,IEvaluationDal
    {
        public List<EvaluationView> GetEvaluationViewsByEvaluatedEmployeeId(int evaluatedEmployeeId)
        {
            using (var context = new EesContext())
            {
                return context.EvaluationViews.Where(x => x.EvaluatedEmployeeId == evaluatedEmployeeId).ToList();
            }
        }

        public List<EvaluationView> GetEvaluationsViewList()
        {
            using (var context = new EesContext())
            {
                return context.EvaluationViews.ToList();
            }
        }

        public List<EvaluationView> GetEvaluationViewsByEvaluatingEmployeeId(int evaluatingEmployeeId)
        {
            using (var context = new EesContext())
            {
                return context.EvaluationViews.Where(x => x.EvaluatingEmployeeId == evaluatingEmployeeId).ToList();
            }
        }
    }
}
