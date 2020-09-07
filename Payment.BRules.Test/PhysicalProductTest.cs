using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RulesEngine.Rules;

namespace Payment.BRules.Test
{
    [TestClass]
    public class PhysicalProductTest
    {
     
        [TestMethod]
        public void ValidateRules()
        {
            var membership = new PhysicalProduct();
            var result = membership.Handle("physical");

            // Assert
            Assert.AreEqual("Create a packing slip for shipping", result); 

        }

        [TestMethod]
        public void CheckNullRules()
        {
            var membershipMock = new Mock<PhysicalProduct> { CallBase = true };
            var result = membershipMock.Setup(m => m.Handle("physical")).Returns("Create a packing slip for shipping");
            // Assert
            Assert.IsNotNull(result);   

        }
    }
}
