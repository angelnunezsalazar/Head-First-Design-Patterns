namespace TemplateMethod
{
    using System;

    public class Coffee:Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine(BeverageMessages.BrewCoffeeGrinds);
        }
        protected override void AddCondiments()
        {
            Console.WriteLine(BeverageMessages.AddSugarAndMilk);
        }
    }
}