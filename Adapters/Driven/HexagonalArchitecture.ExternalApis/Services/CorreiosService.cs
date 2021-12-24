using HexagonalArchitecture.Domain.Adapters;
using HexagonalArchitecture.Domain.DTOs;

namespace HexagonalArchitecture.ExternalApis.Services
{
    public class CorreiosService : ICorreiosAdapter
    {
        public Task<Address> GetAddress(string cep)
        {
            throw new NotImplementedException();
        }
    }
}
