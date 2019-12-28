using ProcessChanger.Models;
using ProcessChanger.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProcessChanger.Repositories
{
    public class UserInMemoryRepository  : IUserRepository
    {
        private static IList<User> _users = new List<User>()
        {
            new User
            {
                Id = 1,
                Department = DepartmentType.Engineering,
                Email = "test@gmail.com",
                IsActive = true,
                Firstname = "Adrian",
                Lastname = "Kowalski"
            }
        };
        

        public void Add(AddUserModel model)
        {
            var userEntity = new User
            {
                Id = GetId(),
                Firstname  =model.Firstname,
                Lastname = model.Lastname,
                Email = model.Email,
                Department = model.Department,
                IsActive = true,
            };

            _users.Add(userEntity);
        }
        public void Update(EditUserModel model)
        {
            var user = _users.SingleOrDefault(x => x.Id == model.ID);
            if(user != null)
            {
                user.Email = model.Email;
                user.Department = model.Department;
                user.IsActive = model.IsActive;
            }
                
        }
        public IEnumerable<UserListItemModel> GetAllActiveUsers()
        {
            return _users.Where(x => x.IsActive)
                .Select(u => new UserListItemModel
                {
                    Id = u.Id,
                    Department = u.Department,
                    email = u.Email,
                    FullName = u.Firstname + " " + u.Lastname
                });
        }
        public EditUserModel FindUserById(long Id)
        {
            return _users.Where(x => x.Id == Id)
                .Select(u => new EditUserModel
                {
                    ID = u.Id,
                    Email = u.Email,
                    Department = u.Department,
                    IsActive = u.IsActive,
                    FullName = u.Firstname + " " + u.Lastname
                })
                .FirstOrDefault();
        }
        private long GetId()
        {
            return _users.Count > 0 ? _users.Max(u => u.Id) + 1 : 1;
        }

        public IEnumerable<User> GetUsers(Func<User, bool> predicate)
        {
            return _users.Where(predicate);
        }

        public User GetEntity(long id)
        {
            return _users.SingleOrDefault(u => u.Id == id);
        }
    }
}