using ReadyList.Database.Models;

namespace ReadyList.Services.Repository
{
    public interface IRepository
    {
        #region Users

        public IEnumerable<User> GetAllUsers();

        public User GetUserById(Guid userId);

        public void EditUser();

        public void DeleteUser();

        #endregion

        #region Tasks



        #endregion
    }
}
