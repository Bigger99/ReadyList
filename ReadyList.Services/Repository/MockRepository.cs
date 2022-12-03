using ReadyList.Database.Models;

namespace ReadyList.Database.Repository
{
    public class MockRepository : IRepository
    {
        private readonly List<User> _users = new List<User>();

        public MockRepository()
        {
            for (var i = 1; i <= 5; i++)
            {
                _users.Add(
                    new()
                    {
                        UserId = Guid.NewGuid(),
                        FirstName = $"FirstName {i}",
                        MiddleName = $"MiddleName {i}",
                        LastName = $"LastName {i}",
                        Email = $"Email {i}",
                        Password = $"pas {i}",
                    });
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

        public User CrateUser(User user)
        {
            var newUser = new User
            {
                UserId = Guid.NewGuid(),
                FirstName = $"FirstName {user.FirstName}",
                MiddleName = $"MiddleName {user.MiddleName}",
                LastName = $"LastName {user.LastName}",
                Email = $"Email {user.Email}",
                Password = $"pas {user.Password}",
            };

            _users.Add(newUser);
            return newUser;
        }
    }
}
