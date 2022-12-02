using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadyList.Database.Models;
using ReadyList.Services.Repository;

namespace ReadyList.Database.Repository
{
    internal class MockRepository : IRepository
    {
        private IEnumerable<User> _users;

        public MockRepository()
        {
            for (var i = 1; i <= 5; i++)
            {
                _users = new List<User>
                {
                    new()
                    {
                        UserId = Guid.NewGuid(),
                        FirstName = $"FirstName {i}",
                        MiddleName = $"MiddleName {i}",
                        LastName = $"LastName {i}",
                        Email = $"Email {i}",
                        Password = $"pas {i}",
                    }
                };
            }
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _users;
        }

        public User GetUserById(Guid userId)
        {
            var user = _users.FirstOrDefault(user => user.UserId == userId);
            return new User();
        }

        public void EditUser()
        {
            throw new NotImplementedException();
        }

        public void DeleteUser()
        {
            throw new NotImplementedException();
        }
    }
}
