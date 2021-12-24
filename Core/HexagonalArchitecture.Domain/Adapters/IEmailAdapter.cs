﻿namespace HexagonalArchitecture.Domain.Adapters
{
    public interface IEmailAdapter
    {
        Task SendEmail(string from, string to, string subject, string body);
    }
}
