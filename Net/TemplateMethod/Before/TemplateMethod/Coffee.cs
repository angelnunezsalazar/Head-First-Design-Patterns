namespace TemplateMethod
{
    using System;

    public class Coffee
    {
        public void PrepareRecipe()
        {
            this.BoilWater();
            this.BrewCoffeeGrinds();
            this.PourInCup();
            this.AddSugarAndMilk();
        }

        private void BoilWater()
        {
            Console.WriteLine(BeverageMessages.BoilWater);
        }

        private void BrewCoffeeGrinds()
        {
            Console.WriteLine(BeverageMessages.BrewCoffeeGrinds);
        }

        private void PourInCup()
        {
            Console.WriteLine(BeverageMessages.PourInCup);
        }

        private void AddSugarAndMilk()
        {
            Console.WriteLine(BeverageMessages.AddSugarAndMilk);
        }
    }
}