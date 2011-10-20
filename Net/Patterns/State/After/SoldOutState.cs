namespace Patterns.State.After
{
    using System;

    public class SoldOutState : IState
    {
        public void Insert()
        {
            Console.WriteLine(MachineMessages.InsertWhenSoldOut);
        }

        public void Eject()
        {
            Console.WriteLine(MachineMessages.EjectWhenSoldOut);
        }

        public void TurnCrank()
        {
            Console.WriteLine(MachineMessages.TurnWhenSoldOut);
        }

        public void Dispense()
        {
            Console.WriteLine(MachineMessages.DispenseWhenSoldOut);
        }
    }
}