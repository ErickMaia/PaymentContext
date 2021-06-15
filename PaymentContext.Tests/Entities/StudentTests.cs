using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Subscription sub = new Subscription(DateTime.Now.AddYears(1)); 
            var student = new Student("Erick", "Maia", "1234567890", "hello@balta.io"); 
            student.AddSubscription(sub); 

        }
    }
}
