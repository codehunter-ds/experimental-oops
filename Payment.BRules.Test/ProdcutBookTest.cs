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
    public class ProdcutBookTest
    {
        [TestMethod]
        public void ValidateRules()
        {
            var membership = new ProdcutBook();
            var result = membership.Handle("book");

            // Assert
            Assert.AreEqual("Create duplicate packing slip for the royalty department", result);
        }

        [TestMethod]
        public void CheckNullRules()
        {
            var membershipMock = new Mock<ProdcutBook> { CallBase = true };
            var result = membershipMock.Setup(m => m.Handle("book")).Returns("Create duplicate packing slip for the royalty department");
            // Assert
            Assert.IsNotNull(result);

        }
    }
}
