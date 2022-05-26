using Shared.ValueObjects;

namespace Domain.ValueObjects{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            if(String.IsNullOrEmpty(firstName)){
                AddNotification("Name.firstName", "Nome inválido");
            }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}