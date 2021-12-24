using HexagonalArchitecture.Domain.Entities;

namespace HexagonalArchitecture.Domain.Services
{
    public interface IUserService
    {
        Task<int?> AddUser(User user);
        Task<IEnumerable<User>> GetAllUsers();
    }
}
