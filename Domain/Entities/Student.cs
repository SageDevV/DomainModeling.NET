using Domain.ValueObjects;
using Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private IList<Subscription> _subscriptions;
        public Student( Document document, Email email, Name name)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();
        }

        public Name Name { get; set; }

        public Document Document { get; set; }
        public Email Email { get;  set; }
        
        public Address Address { get; set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get {return _subscriptions.ToArray();}}
        public void AddSubscription(Subscription subscription){
            var inactive = false;
            foreach(var sub in Subscriptions)
                sub.Inactivate(inactive);
            
            _subscriptions.Add(subscription);
        }
    }
}