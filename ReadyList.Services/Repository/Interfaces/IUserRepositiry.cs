using ReadyList.Database.Models;

namespace ReadyList.Database.Repository.Interfaces;
public interface IUserRepositiry
{
    public IEnumerable<User> GetAllUsers();

    public User GetUserById(Guid userId);

    public User CrateUser(User user);

    public void EditUser(User user);

    public void DeleteUser(Guid userId);
}

