using Domain.ValueObjects;
using PaymentContext.Domain.Entities;

namespace Domain.Entities{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, Address address) : base(paidDate, expireDate, total, totalPaid, payer, document, address)
        {
        }

        public string TransactionCode { get; set; }
    }
}