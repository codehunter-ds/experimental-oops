using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RulesEngine.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.BRules.Test
{
    [TestClass]
    public class CommissionPaymentTest
    {
        [TestMethod]
        public void ValidateRules()
        {
            var membership = new CommissionPayment();
            var result = membership.Handle("commission");

            // Assert
            Assert.AreEqual("Generate a commission payment to the agent", result);

        }

        [TestMethod]
        public void CheckNullRules()
        {
            var membershipMock = new Mock<CommissionPayment> { CallBase = true };
            var result = membershipMock.Setup(m => m.Handle("commission")).Returns("Generate a commission payment to the agent");
            // Assert
            Assert.IsNotNull(result);

        }
    }
}
