

using System.Linq;
using System.Collections.Generic;
 
using EES.Entities.Concrete;
         
using EES.Business.Abstract;
         
using EES.DataLayer.Abstract;
using EES.Entities.View;


namespace EES.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            this._userDal = userDal;;
        }

        public List<User> GetAll()
        {
            return _userDal.GetList();
        }

        public User GetById(int userId)
        {
            return _userDal.Get(t=>t.UserId==userId);
        }

        public User Insert(User user)
        {
            return _userDal.Add(user);
        } 

        public User Update(User user)
        {
            return _userDal.Update(user);
        }

        public void Delete(int userId)
        {
            var user = _userDal.Get(t=>t.UserId==userId);

            _userDal.Delete(user);
        }

        public UserEmployeeView GeEmployeeUserbyEmail(string email)
        {
            return _userDal.GetUserByEmail(email);
        }

        public User GetbyEmail(string email)
        {
            return _userDal.GetByEmail(email);
        }
    }
}