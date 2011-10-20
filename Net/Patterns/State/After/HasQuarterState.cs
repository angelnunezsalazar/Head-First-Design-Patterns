namespace Patterns.State.After
{
    using System;

    public class HasQuarterState : IState
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
            gumballMachine.State=new NoQuarterState(gumballMachine);
        }

        public void TurnCrank()
        {
            Console.WriteLine(MachineMessages.TurnSuccessfully);
            gumballMachine.State=new SoldState(gumballMachine);
            gumballMachine.Dispense();
        }

        public void Dispense()
        {
            Console.WriteLine(MachineMessages.DispenseWhenHasQuarter);
        }
    }
}