using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(string cardHolderName, string cardLastFourDigits, string lastTransactionNumber, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, Document document, string payer, Address address, Email email) : base(paidDate, expireDate, total, totalPaid, document, payer, address, email)
        {
            CardHolderName = cardHolderName; 
            CardLastFourDigits = cardLastFourDigits; 
            LastTransactionNumber = lastTransactionNumber; 
        }

        public string CardHolderName { get; set; }
        public string CardLastFourDigits { get; set; }
        public string LastTransactionNumber { get; set; }
    }
}