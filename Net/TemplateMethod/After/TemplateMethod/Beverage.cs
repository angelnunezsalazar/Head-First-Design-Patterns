namespace TemplateMethod
{
    using System;

    public abstract class Beverage
    {
        public void PrepareRecipe()
        {
            this.BoilWater();
            this.Brew();
            this.PourInCup();
            this.AddCondiments();
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