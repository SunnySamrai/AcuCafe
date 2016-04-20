using System;
using System.Diagnostics;
using System.Runtime;
using AcuCafe.Constants;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AcuCafe.Tests
{
    [TestClass]
    public class AcuCafeTests
    {
        [TestMethod]
        public void ExpressoTest()
        {
            var cafe = new AcuCafe();

            var expressoMilkAndSugar = (Expresso)cafe.OrderDrink(Enumerations.DrinkType.Expresso, true, true);
            Assert.AreEqual(expressoMilkAndSugar.HasMilk, true);
            Assert.AreEqual(expressoMilkAndSugar.HasSugar, true);
            Assert.AreEqual(expressoMilkAndSugar.ChocolateTopping, false);

            var expressoMilkNoSugar = (Expresso)cafe.OrderDrink(Enumerations.DrinkType.Expresso, true, false);
            Assert.AreEqual(expressoMilkNoSugar.HasMilk, true);
            Assert.AreEqual(expressoMilkNoSugar.HasSugar, false);
            Assert.AreEqual(expressoMilkNoSugar.ChocolateTopping, false);

            var expressoNoMilkAndSugar = (Expresso)cafe.OrderDrink(Enumerations.DrinkType.Expresso, false, true);
            Assert.AreEqual(expressoNoMilkAndSugar.HasMilk, false);
            Assert.AreEqual(expressoNoMilkAndSugar.HasSugar, true);
            Assert.AreEqual(expressoNoMilkAndSugar.ChocolateTopping, false);

            var expressoNoMilkOrSugar = (Expresso)cafe.OrderDrink(Enumerations.DrinkType.Expresso, false, false);
            Assert.AreEqual(expressoNoMilkOrSugar.HasMilk, false);
            Assert.AreEqual(expressoNoMilkOrSugar.HasSugar, false);
            Assert.AreEqual(expressoNoMilkOrSugar.ChocolateTopping, false);

            var expressoMilkAndSugarWithChocolate = (Expresso)cafe.OrderDrink(Enumerations.DrinkType.Expresso, true, true, true);
            Assert.AreEqual(expressoMilkAndSugarWithChocolate.HasMilk, true);
            Assert.AreEqual(expressoMilkAndSugarWithChocolate.HasSugar, true);
            Assert.AreEqual(expressoMilkAndSugarWithChocolate.ChocolateTopping, true);

            var expressoMilkNoSugarWithChocolate = (Expresso)cafe.OrderDrink(Enumerations.DrinkType.Expresso, true, false, true);
            Assert.AreEqual(expressoMilkNoSugarWithChocolate.HasMilk, true);
            Assert.AreEqual(expressoMilkNoSugarWithChocolate.HasSugar, false);
            Assert.AreEqual(expressoMilkNoSugarWithChocolate.ChocolateTopping, true);

            var expressoNoMilkAndSugarWithChocolate = (Expresso)cafe.OrderDrink(Enumerations.DrinkType.Expresso, false, true, true);
            Assert.AreEqual(expressoNoMilkAndSugarWithChocolate.HasMilk, false);
            Assert.AreEqual(expressoNoMilkAndSugarWithChocolate.HasSugar, true);
            Assert.AreEqual(expressoNoMilkAndSugarWithChocolate.ChocolateTopping, true);

            var expressoNoMilkOrSugarWithChocolate = (Expresso)cafe.OrderDrink(Enumerations.DrinkType.Expresso, false, false, true);
            Assert.AreEqual(expressoNoMilkOrSugarWithChocolate.HasMilk, false);
            Assert.AreEqual(expressoNoMilkOrSugarWithChocolate.HasSugar, false);
            Assert.AreEqual(expressoNoMilkOrSugarWithChocolate.ChocolateTopping, true);
        }

        [TestMethod]
        public void HotTeaTest()
        {
            var cafe = new AcuCafe();

            var hotTeaMilkAndSugar = cafe.OrderDrink(Enumerations.DrinkType.HotTea, true, true);
            Assert.AreEqual(hotTeaMilkAndSugar.HasMilk, true);
            Assert.AreEqual(hotTeaMilkAndSugar.HasSugar, true);

            var hotTeaMilkNoSugar = cafe.OrderDrink(Enumerations.DrinkType.HotTea, true, false);
            Assert.AreEqual(hotTeaMilkNoSugar.HasMilk, true);
            Assert.AreEqual(hotTeaMilkNoSugar.HasSugar, false);

            var hotTeaNoMilkAndSugar = cafe.OrderDrink(Enumerations.DrinkType.HotTea, false, true);
            Assert.AreEqual(hotTeaNoMilkAndSugar.HasMilk, false);
            Assert.AreEqual(hotTeaNoMilkAndSugar.HasSugar, true);

            var hotTeaNoMilkOrSugar = cafe.OrderDrink(Enumerations.DrinkType.HotTea, false, false);
            Assert.AreEqual(hotTeaNoMilkOrSugar.HasMilk, false);
            Assert.AreEqual(hotTeaNoMilkOrSugar.HasSugar, false);
        }

        [TestMethod]
        public void IceTeaTest()
        {
            var cafe = new AcuCafe();

            var iceTeaNoMilkAndSugar = cafe.OrderDrink(Enumerations.DrinkType.IceTea, false, true);
            Assert.AreEqual(iceTeaNoMilkAndSugar.HasMilk, false);
            Assert.AreEqual(iceTeaNoMilkAndSugar.HasSugar, true);

            var iceTeaNoMilkOrSugar = cafe.OrderDrink(Enumerations.DrinkType.IceTea, false, false);
            Assert.AreEqual(iceTeaNoMilkOrSugar.HasMilk, false);
            Assert.AreEqual(iceTeaNoMilkOrSugar.HasSugar, false);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void IceTeaMilkException()
        {
            var cafe = new AcuCafe();
            var iceTeaMilkNoSugar = cafe.OrderDrink(Enumerations.DrinkType.IceTea, true, false);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void IceTeaMilkException2()
        {
            var cafe = new AcuCafe();
            var iceTeaMilkAndSugar = cafe.OrderDrink(Enumerations.DrinkType.IceTea, true, true);
        }
    }
}
