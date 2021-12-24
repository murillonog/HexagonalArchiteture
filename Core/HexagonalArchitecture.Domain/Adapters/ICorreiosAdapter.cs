using HexagonalArchitecture.Domain.DTOs;

namespace HexagonalArchitecture.Domain.Adapters
{
    public interface ICorreiosAdapter
    {
        public Task<Address> GetAddress(string cep);
    }
}
