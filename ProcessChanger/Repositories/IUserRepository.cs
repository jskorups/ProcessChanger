using System.Collections.Generic;
using ProcessChanger.Models;

namespace ProcessChanger.Repositories
{
    public interface IUserRepository
    {
         void Add(AddUserModel model);
         void Update(EditUserModel model);
         IEnumerable<UserListItemModel> GetAllActiveUsers();
         EditUserModel FindUserById(long Id);
    }
}
