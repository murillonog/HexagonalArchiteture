using HexagonalArchitecture.Domain.Adapters;
using HexagonalArchitecture.Domain.Entities;

namespace HexagonalArchitecture.DataBase.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task<int?> AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
