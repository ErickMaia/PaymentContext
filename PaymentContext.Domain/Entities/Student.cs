

using System;
using System.Collections.Generic;
using System.Linq;

namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }

        public IList<Subscription> _subscriptions; 
        public IReadOnlyCollection<Subscription> Subscriptions{ 
            get{
                return _subscriptions.ToArray(); 
            }
        }

        public Student(string firstName, string lastName, string document, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>(); 

            if(firstName is "" or null){
                throw new Exception("Invalid name. "); 
            }
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