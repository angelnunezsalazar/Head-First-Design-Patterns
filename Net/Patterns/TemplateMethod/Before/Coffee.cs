namespace Patterns.TemplateMethod.Before
{
    using System;

    public class Coffee
    {
        public void PrepareRecipe()
        {
            BoilWater();
            BrewCoffeeGrinds();
            PourInCup();
            AddSugarAndMilk();
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