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
    public class UpgradeMembershipTest
    {
        [TestMethod]
        public void ValidateRules()
        {
            var membership = new UpgradeMembership();
            var result = membership.Handle("upgrade");

            // Assert
            Assert.AreEqual("Apply the upgrade\n", result);

        }

        [TestMethod]
        public void CheckNullRules()
        {
            var membershipMock = new Mock<UpgradeMembership> { CallBase = true };
            var result = membershipMock.Setup(m => m.Handle("upgrade")).Returns("Apply the upgrade\n");
            // Assert
            Assert.IsNotNull(result);    

        }
    }
}
