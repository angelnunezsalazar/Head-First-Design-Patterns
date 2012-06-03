namespace TemplateMethod.Tests
{
    using System;
    using System.IO;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CoffeeTests
    {
        private StringWriter sw;

        [TestInitialize]
        public void Setup()
        {
            this.sw = new StringWriter();
            Console.SetOut(this.sw);
        }

        [TestMethod]
        public void PrepareRecipe()
        {
            var coffee = new Coffee();

            coffee.PrepareRecipe();

            Assert.IsTrue(this.sw.ToString().Contains(BeverageMessages.BoilWater));
            Assert.IsTrue(this.sw.ToString().Contains(BeverageMessages.BrewCoffeeGrinds));
            Assert.IsTrue(this.sw.ToString().Contains(BeverageMessages.PourInCup));
            Assert.IsTrue(this.sw.ToString().Contains(BeverageMessages.AddSugarAndMilk));
        }
    }
}