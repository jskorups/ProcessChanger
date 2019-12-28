using System;
using System.Collections.Generic;
using ProcessChanger.Entities;
using ProcessChanger.Models;

namespace ProcessChanger.Repositories
{
    public interface IUserRepository
    {
         void Add(AddUserModel model);
         void Update(EditUserModel model);
         IEnumerable<UserListItemModel> GetAllActiveUsers();
         EditUserModel FindUserById(long Id);

        IEnumerable<User> GetUsers(Func<User, bool> whereClause);

        User GetEntity(long id);
    }
}
