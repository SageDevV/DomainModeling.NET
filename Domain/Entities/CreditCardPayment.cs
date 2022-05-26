using Domain.ValueObjects;
using PaymentContext.Domain.Entities;

namespace Domain.Entities{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, Address address) : base(paidDate, expireDate, total, totalPaid, payer, document, address)
        {
        }

        public string CardHoldName { get; set; }
        public string CardNumber { get; set; }
        public string LastTransactionNumber { get; set; }
        
    }
}