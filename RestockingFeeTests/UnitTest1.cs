using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestockingFee;

namespace RestockingFeeTests
{
    [TestClass]
    public class UnitTestColorValidator
    {
        [TestMethod]
        public void ColorTurnsGreenToWhiteOnPass()
        {
            Assert.AreEqual(Color.White, ColorGenerator.GenerateColor(1000,10,true));
        }

        [TestMethod]
        public void ColorTurnsRedToWhiteOnPass()
        {
            Assert.AreEqual(Color.White, ColorGenerator.GenerateColor(1000, 10, false));
        }

        [TestMethod]
        public void ColorIsLightRed()
        {
            Assert.AreEqual(Color.FromArgb(255, 127, 127), ColorGenerator.GenerateColor(0, 100, false));
        }

        [TestMethod]
        public void ColorIsLightGreen()
        {
            Assert.AreEqual(Color.FromArgb(127, 255, 127), ColorGenerator.GenerateColor(0, 100, true));
        }
    }

    [TestClass]
    public class UnitTestRestockingFee
    {
        [TestMethod]
        public void Price2525Cents()
        {
            Assert.AreEqual(22.73, RestockingFeeCalculator.TenPercent(25.25));
        }

        [TestMethod]
        public void Price3685Cents()
        {
            Assert.AreEqual(33.17, RestockingFeeCalculator.TenPercent(36.85));
        }

        [TestMethod]
        public void Price3030Cents()
        {
            Assert.AreEqual(27.27, RestockingFeeCalculator.TenPercent(30.30));
        }

        [TestMethod]
        public void Price2727Cents()
        {
            Assert.AreEqual(24.54, RestockingFeeCalculator.TenPercent(27.27));
        }

        [TestMethod]
        public void Price2522Cents()
        {
            Assert.AreEqual(22.70, RestockingFeeCalculator.TenPercent(25.22));
        }

        [TestMethod]
        public void Price4555Cents()
        {
            Assert.AreEqual(41.00, RestockingFeeCalculator.TenPercent(45.55));
        }

        [TestMethod]
        public void Price45555Cents()
        {
            Assert.AreEqual(410.00, RestockingFeeCalculator.TenPercent(455.55));
        }

        [TestMethod]
        public void Price455555Cents()
        {
            Assert.AreEqual(4100.00, RestockingFeeCalculator.TenPercent(4555.55));
        }

        [TestMethod]
        public void Price455554Cents()
        {
            Assert.AreEqual(4099.99, RestockingFeeCalculator.TenPercent(4555.54));
        }
    }

    [TestClass]
    public class UnitTestRestockingFeeSmallChange
    {
        [TestMethod]
        public void Price1Cent()
        {
            Assert.AreEqual(0.01, RestockingFeeCalculator.TenPercent(0.01));
        }

        [TestMethod]
        public void Price2Cents()
        {
            Assert.AreEqual(0.02, RestockingFeeCalculator.TenPercent(0.02));
        }

        [TestMethod]
        public void Price3Cents()
        {
            Assert.AreEqual(0.03, RestockingFeeCalculator.TenPercent(0.03));
        }

        [TestMethod]
        public void Price4Cents()
        {
            Assert.AreEqual(0.04, RestockingFeeCalculator.TenPercent(0.04));
        }

        [TestMethod]
        public void Price5Cents()
        {
            Assert.AreEqual(0.05, RestockingFeeCalculator.TenPercent(0.05));
        }

        [TestMethod]
        public void Price6Cents()
        {
            Assert.AreEqual(0.05, RestockingFeeCalculator.TenPercent(0.06));
        }

        [TestMethod]
        public void Price7Cents()
        {
            Assert.AreEqual(0.06, RestockingFeeCalculator.TenPercent(0.07));
        }

        [TestMethod]
        public void Price8Cents()
        {
            Assert.AreEqual(0.07, RestockingFeeCalculator.TenPercent(0.08));
        }

        [TestMethod]
        public void Price9Cents()
        {
            Assert.AreEqual(0.08, RestockingFeeCalculator.TenPercent(0.09));
        }

        [TestMethod]
        public void Price10Cents()
        {
            Assert.AreEqual(0.09, RestockingFeeCalculator.TenPercent(0.10));
        }

        [TestMethod]
        public void Price99Cents()
        {
            Assert.AreEqual(0.89, RestockingFeeCalculator.TenPercent(0.99));
        }

        [TestMethod]
        public void Price100Cents()
        {
            Assert.AreEqual(0.90, RestockingFeeCalculator.TenPercent(1));
        }

        [TestMethod]
        public void Price55Cents()
        {
            Assert.AreEqual(0.50, RestockingFeeCalculator.TenPercent(.55));
        }
    }
}
