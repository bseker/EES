using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EES.Entities.Concrete;
using EES.Entities.View;

namespace EES.MvcUI.Models
{
    public class OwnedEvaluationsViewModel
    {
        public List<EvaluationView> GivenEvaluations { get; set; }
    }
}