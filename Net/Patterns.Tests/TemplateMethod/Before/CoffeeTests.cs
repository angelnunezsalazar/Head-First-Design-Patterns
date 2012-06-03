namespace Patterns.Tests.TemplateMethod.Before
{
    using System;
    using System.IO;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Patterns.TemplateMethod;
    using Patterns.TemplateMethod.Before;

    [TestClass]
    public class CoffeeTests
    {
        private StringWriter sw;

        [TestInitialize]
        public void Setup()
        {
            sw = new StringWriter();
            Console.SetOut(sw);
        }

        [TestMethod]
        public void PrepareRecipe()
        {
            var coffee = new Coffee();

            coffee.PrepareRecipe();

            Assert.IsTrue(sw.ToString().Contains(BeverageMessages.BoilWater));
            Assert.IsTrue(sw.ToString().Contains(BeverageMessages.BrewCoffeeGrinds));
            Assert.IsTrue(sw.ToString().Contains(BeverageMessages.PourInCup));
            Assert.IsTrue(sw.ToString().Contains(BeverageMessages.AddSugarAndMilk));
        }
    }
}