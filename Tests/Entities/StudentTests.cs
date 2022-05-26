using System;
using Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PaymentContext.Tests
{

    [TestClass]
    public class StudentTests
    {

        [TestMethod]

        public void AdicionarAssinatura()
        {
            var name = new Name("Pedro André", "dos Santos");
            foreach (var not in name.Notifications)
            {
                Console.WriteLine("Teste");
                Console.WriteLine(not.Message);
            }
        }
    }
}
