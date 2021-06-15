using System;
using System.Collections.Generic;
using System.Linq;

namespace PaymentContext.Domain.Entities
{
    public class Subscription
    {
        private IList<Payment> _payments; 
        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }
        public DateTime? ExpireDate { get; private set; }
        public bool IsActive { get; private set; }
        public IReadOnlyCollection<Payment> Payments { 
            get {
                return _payments.ToArray();
            }
        }

        public Subscription(DateTime? expireDate)
        {
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            ExpireDate = expireDate;
            IsActive = true;
            _payments = new List<Payment>(); 
        }

        public void AddPayment(Payment payment){
            _payments.Add(payment); 
        }

        public void Activate(){
            IsActive = true; 
            LastUpdateDate = DateTime.Now; 
        }

        public void Deactivate(){
            IsActive = false;
            LastUpdateDate = DateTime.Now; 
        }
    }
}