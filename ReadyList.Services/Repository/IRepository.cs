using ReadyList.Database.Models;

namespace ReadyList.Database.Repository
{
    public interface IRepository
    {
        #region Users

        public IEnumerable<User> GetAllUsers();

        public User GetUserById(Guid userId);

        public User CrateUser(User user);

        public void EditUser();

        public void DeleteUser();

        #endregion

        #region Tasks



        #endregion
    }
}
