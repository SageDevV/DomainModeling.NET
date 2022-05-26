using Domain.ValueObjects;
using PaymentContext.Domain.Entities;

namespace Domain.Entities{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, Address address) : base(paidDate, expireDate, total, totalPaid, payer, document, address)
        {
        }

        public string BarCode { get; set; }
        public string BoletoNumber { get; set; }

        
    }
}
    