

using System;
using System.Collections.Generic;
using System.Linq;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }

        public IList<Subscription> _subscriptions; 
        public IReadOnlyCollection<Subscription> Subscriptions{ 
            get{
                return _subscriptions.ToArray(); 
            }
        }

        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>(); 
            
            AddNotifications(name, document, email); 
        }

        public void AddSubscription(Subscription subscription){
            //Cancel all other subscriptions, and then add the new one

            foreach (Subscription sub in Subscriptions)
            {
                sub.Deactivate(); 
            }

            _subscriptions.Add(subscription); 
        }
    }
}