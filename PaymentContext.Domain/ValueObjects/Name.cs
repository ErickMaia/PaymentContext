using PaymentContext.Shared.ValueObjects;
using Flunt.Notifications; 

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            if(string.IsNullOrEmpty(FirstName))
                AddNotification("FirstName", "String is null or empty. "); 
            
            if(string.IsNullOrEmpty(LastName))
                AddNotification("LastName", "String is null or empty. ");           

        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}