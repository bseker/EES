using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EES.MvcUI.Models
{
    public class SearchEvaluationsViewModel
    {
        public int EvaluationId { get; set; }

        public string EvaluatedEmployeeName { get; set; }

        public string EvaluatedEmplyeeSurname { get; set; }

        public int EvaluationYear { get; set; }

        public double EvaluationScore { get; set; }

        public string EvaluationType { get; set; }


    }
}