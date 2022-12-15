using ReadyList.Database.Models;

namespace ReadyList.Database.Repository
{
    public class MockRepository : IRepository
    {
        private readonly List<User> _users = new List<User>();
        private readonly List<Issue> _issues = new List<Issue>();

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

            for (var i = 1; i <= 5; i++)
            {
                _issues.Add(
                    new()
                    {
                        IssueId = Guid.NewGuid(),
                        Title = $"FirstName {i}",
                        Description = $"MiddleName {i}",
                        Date = DateTime.Now.Date,
                        Time = DateTime.Now.TimeOfDay,
                        IsDone = false,
                        AssociatedUsers = new[] { new User() },
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

        public void EditUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Issue> GetAllIssues()
        {
            return _issues;
        }

        public Issue GetIssueById(Guid issueId)
        {
            throw new NotImplementedException();
        }

        public Issue CrateIssue(Issue issue)
        {
            throw new NotImplementedException();
        }

        public void EditIssue(Issue issue)
        {
            throw new NotImplementedException();
        }

        public void DeleteIssue(Guid issueId)
        {
            throw new NotImplementedException();
        }
    }
}
