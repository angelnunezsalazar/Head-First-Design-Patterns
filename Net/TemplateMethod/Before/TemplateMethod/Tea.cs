namespace TemplateMethod
{
    using System;

    public class Tea
    {
        public void PrepareRecipe()
        {
            this.BoilWater();
            this.SteepTeaBag();
            this.PourInCup();
            this.AddLemon();
        }

        private void BoilWater()
        {
            Console.WriteLine(BeverageMessages.BoilWater);
        }

        private void SteepTeaBag()
        {
            Console.WriteLine(BeverageMessages.SteepTeaBag);
        }

        private void PourInCup()
        {
            Console.WriteLine(BeverageMessages.PourInCup);
        }

        private void AddLemon()
        {
            Console.WriteLine(BeverageMessages.AddLemon);
        }
    }
}