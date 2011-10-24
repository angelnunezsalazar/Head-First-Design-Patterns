namespace Patterns.State.After
{
    using System;

    internal class HasQuarterState : IState
    {
        private readonly GumballMachine gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Insert()
        {
            Console.WriteLine(MachineMessages.InsertTwice);
        }

        public void Eject()
        {
            Console.WriteLine(MachineMessages.EjectSuccessfully);
            gumballMachine.State = gumballMachine.NoQuarter;
        }

        public void Turn()
        {
            Console.WriteLine(MachineMessages.TurnSuccessfully);
            gumballMachine.State = gumballMachine.Sold;
            gumballMachine.Dispense();
        }

        public void Dispense()
        {
            Console.WriteLine(MachineMessages.DispenseWhenHasQuarter);
        }
    }
}