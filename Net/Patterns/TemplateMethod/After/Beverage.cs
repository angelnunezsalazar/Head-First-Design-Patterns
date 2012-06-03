namespace Patterns.TemplateMethod.After
{
    using System;

    public abstract class Beverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        protected abstract void Brew();

        protected abstract void AddCondiments();

        private void BoilWater()
        {
            Console.WriteLine(BeverageMessages.BoilWater);
        }

        private void PourInCup()
        {
            Console.WriteLine(BeverageMessages.PourInCup);
        }
    }
}