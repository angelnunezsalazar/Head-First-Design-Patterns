namespace TemplateMethod.Tests
{
    using System;
    using System.IO;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TeaTests
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
            var tea = new Tea();

            tea.PrepareRecipe();

            Assert.IsTrue(this.sw.ToString().Contains(BeverageMessages.BoilWater));
            Assert.IsTrue(this.sw.ToString().Contains(BeverageMessages.SteepTeaBag));
            Assert.IsTrue(this.sw.ToString().Contains(BeverageMessages.PourInCup));
            Assert.IsTrue(this.sw.ToString().Contains(BeverageMessages.AddLemon));
        }
    }
}