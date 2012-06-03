namespace TemplateMethod
{
    using System;

    public class Tea : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine(BeverageMessages.SteepTeaBag);
        }
        protected override void AddCondiments()
        {
            Console.WriteLine(BeverageMessages.AddLemon);
        }
    }
}