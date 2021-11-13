using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EES.Entities.Concrete;
using EES.Entities.View;

namespace EES.MvcUI.Models.AuthModels
{
    public class LoginModel
    {
        public UserEmployeeView User { get; set; }

    }
}