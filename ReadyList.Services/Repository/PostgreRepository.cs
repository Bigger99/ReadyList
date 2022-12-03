using ReadyList.Database.Context;
using ReadyList.Database.Models;

namespace ReadyList.Database.Repository
{
    public class PostgreRepository
    {
        private readonly DatabaseContext _databaseContext;

        public PostgreRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
    }
}
