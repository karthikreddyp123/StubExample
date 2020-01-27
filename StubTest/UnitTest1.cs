using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using StubExample;
using FakeTyresNameSpace;
namespace StubTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            var StubStartCar = new Mock<InnerWork>();
            StubStartCar.Setup(X => X.StartCar()).Returns(true);
            TyreCheck fakeTyreCheck = new FakeTyres();
            //act
            int currentSpeed = Program.accelerate(StubStartCar.Object,fakeTyreCheck);
            //assert
            Assert.AreEqual(currentSpeed, 10);

        }
    }
}
