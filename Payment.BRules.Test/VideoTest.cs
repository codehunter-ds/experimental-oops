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
    public class VideoTest
    {
        [TestMethod]
        public void ValidateRules()
        {
            var membership = new Video();
            var result = membership.Handle("video");

            // Assert
            Assert.AreEqual("Add a 'First Aid' video to the packing sleep", result);

        }

        [TestMethod]
        public void CheckNullRules()
        {
            var membershipMock = new Mock<Video> { CallBase = true };
            var result = membershipMock.Setup(m => m.Handle("video")).Returns("Add a 'First Aid' video to the packing sleep");
            // Assert
            Assert.IsNotNull(result);

        }
    }
}
