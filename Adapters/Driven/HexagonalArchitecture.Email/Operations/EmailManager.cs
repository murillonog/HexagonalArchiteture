using HexagonalArchitecture.Domain.Adapters;

namespace HexagonalArchitecture.Email.Operations
{
    public class EmailManager : IEmailAdapter
    {
        public Task SendEmail(string from, string to, string subject, string body)
        {
            throw new NotImplementedException();
        }
    }
}
