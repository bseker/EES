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
    public class EfUserDal: EfEntityRepositoryBase<User,EesContext>,IUserDal
    {
        public UserEmployeeView GetUserByEmail(string email)
        {
            using (var context = new EesContext())
            {
                return context.UserEmployeeView.SingleOrDefault(x => x.email == email);
            }
        }

        public User GetByEmail(string email)
        {
            using (var context = new EesContext())
            {
                return context.Users.SingleOrDefault(x => x.email == email);
            }
        }

    }
}
