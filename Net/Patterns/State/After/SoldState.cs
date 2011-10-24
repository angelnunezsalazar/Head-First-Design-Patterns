namespace Patterns.State.After
{
    using System;

    internal class SoldState : IState
    {
        private readonly GumballMachine gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Insert()
        {
            Console.WriteLine(MachineMessages.InsertWhenSold);
        }

        public void Eject()
        {
            Console.WriteLine(MachineMessages.EjectWhenSold);
        }

        public void Turn()
        {
            Console.WriteLine(MachineMessages.TurnTwice);
        }

        public void Dispense()
        {
            Console.WriteLine(MachineMessages.DispenseSuccessfully);
            gumballMachine.Count = gumballMachine.Count - 1;
            if (gumballMachine.Count == 0)
            {
                Console.WriteLine(MachineMessages.DispenseTheLastGumball);
                gumballMachine.State = gumballMachine.SoldOut;
            }
            else
            {
                gumballMachine.State = gumballMachine.NoQuarter;
            }
        }
    }
}