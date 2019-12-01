using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProcessChanger.Entities;
using ProcessChanger.Models;

namespace ProcessChanger.Repositories
{
    public class UserInDbRepository : IUserRepository
    {

        public void Add(AddUserModel model)
        {
           
        }
        public void Update(EditUserModel model)
        {
            

        }
        public IEnumerable<UserListItemModel> GetAllActiveUsers()
        {
            return Enumerable.Empty<UserListItemModel>();
        }
        public EditUserModel FindUserById(long Id)
        {
            return new EditUserModel();
        }

        public IEnumerable<User> GetUsers(Func<User, bool> whereClause)
        {
            return null;
        }
    }
}