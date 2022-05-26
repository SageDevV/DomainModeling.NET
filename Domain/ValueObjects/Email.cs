using Shared.ValueObjects;

namespace Domain.ValueObjects{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            
        }
        public string Address { get; set; }
    }
}