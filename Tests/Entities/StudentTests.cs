using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests{

    [TestClass]
    public class StudentTests{

        [TestMethod]

        public void TestMethod(){
            var subscription = new Subscription(null);
            var student = new Student("André", "Baltieri", "123456", "sageorpheu8@hotmail.com"); 
            student.AddSubscription(subscription);
        }
    }
}
