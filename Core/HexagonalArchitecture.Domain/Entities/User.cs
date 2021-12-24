namespace HexagonalArchitecture.Domain.Entities
{
    public class User : EntityBase
    {
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Cep { get; set; }
    }
}
