using HexagonalArchitecture.Domain.Adapters;
using HexagonalArchitecture.Domain.Entities;
using HexagonalArchitecture.Domain.Services;
using Microsoft.Extensions.Logging;

namespace HexagonalArchitecture.Application.Services
{
    public class UserService : IUserService
    {
        private readonly ILogger<UserService> _logger;
        private readonly IUserRepository _userRepository;

        public UserService(
            ILogger<UserService> logger, 
            IUserRepository userRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
        }

        public async Task<int?> AddUser(User user)
        {
            try
            {
                return await _userRepository.AddUser(user);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception.Message);
                return null;
            }
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            try
            {
                return await _userRepository.GetAllUsers();
            }
            catch (Exception exception)
            {
                _logger.LogError(exception.Message);
                return null;
            }
        }
    }
}
