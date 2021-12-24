using HexagonalArchitecture.Domain.Entities;

namespace HexagonalArchitecture.Domain.Adapters
{
    public interface IUserRepository
    {
        Task<int?> AddUser(User user);
        Task<IEnumerable<User>> GetAllUsers();
    }
}
