using Domain.Enums;
using Shared.ValueObjects;

namespace Domain.ValueObjects{
    public class Document : ValueObject
    {
        public Document(string number, string lastName)
        {
            Number = number;
        }

        public string Number { get; set; }
        public EDocumentType Type { get; set; }
    }
}
