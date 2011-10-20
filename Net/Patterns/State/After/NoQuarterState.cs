namespace Patterns.State.After
{
    using System;

    public class NoQuarterState : IState
    {
        private readonly GumballMachine gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Insert()
        {
            gumballMachine.State=new HasQuarterState(gumballMachine);
            Console.WriteLine(MachineMessages.InsertSuccessfully);
        }

        public void Eject()
        {
            Console.WriteLine(MachineMessages.EjectWhenNoQuarter);
        }

        public void TurnCrank()
        {
            Console.WriteLine(MachineMessages.TurnWhenNoQuarter);
        }

        public void Dispense()
        {
            Console.WriteLine(MachineMessages.DispenseWhenNoQuarter);
        }
    }
}