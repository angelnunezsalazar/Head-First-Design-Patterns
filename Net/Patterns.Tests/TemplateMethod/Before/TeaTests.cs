namespace Patterns.Tests.TemplateMethod.Before
{
    using System;
    using System.IO;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Patterns.TemplateMethod;
    using Patterns.TemplateMethod.Before;

    [TestClass]
    public class TeaTests
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
            var tea = new Tea();

            tea.PrepareRecipe();

            Assert.IsTrue(sw.ToString().Contains(BeverageMessages.BoilWater));
            Assert.IsTrue(sw.ToString().Contains(BeverageMessages.SteepTeaBag));
            Assert.IsTrue(sw.ToString().Contains(BeverageMessages.PourInCup));
            Assert.IsTrue(sw.ToString().Contains(BeverageMessages.AddLemon));
        }
    }
}