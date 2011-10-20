namespace Patterns.State.Before
{
    using System;

    public class GumballMachine
    {
        private const int SOLD_OUT = 0;
        private const int NO_QUARTER = 1;
        private const int HAS_QUARTER = 2;
        private const int SOLD = 3;

        int state = SOLD_OUT;
        int count;

        public GumballMachine(int count)
        {
            this.count = count;
            if (count > 0)
            {
                state = NO_QUARTER;
            }
        }

        public void InsertQuarter()
        {
            if (state == HAS_QUARTER)
            {
                Console.WriteLine(MachineMessages.InsertTwice);
            }
            else if (state == NO_QUARTER)
            {
                state = HAS_QUARTER;
                Console.WriteLine(MachineMessages.InsertSuccessfully);
            }
            else if (state == SOLD_OUT)
            {
                Console.WriteLine(MachineMessages.InsertWhenSoldOut);
            }
            else if (state == SOLD)
            {
                Console.WriteLine(MachineMessages.InsertWhenSold);
            }
        }

        public void EjectQuarter()
        {
            if (state == HAS_QUARTER)
            {
                Console.WriteLine(MachineMessages.EjectSuccessfully);
                state = NO_QUARTER;
            }
            else if (state == NO_QUARTER)
            {
                Console.WriteLine(MachineMessages.EjectWhenNoQuarter);
            }
            else if (state == SOLD)
            {
                Console.WriteLine(MachineMessages.EjectWhenSold);
            }
            else if (state == SOLD_OUT)
            {
                Console.WriteLine(MachineMessages.EjectWhenSoldOut);
            }
        }

        public void TurnCrank()
        {
            if (state == SOLD)
            {
                Console.WriteLine(MachineMessages.TurnTwice);
            }
            else if (state == NO_QUARTER)
            {
                Console.WriteLine(MachineMessages.TurnWhenNoQuarter);
            }
            else if (state == SOLD_OUT)
            {
                Console.WriteLine(MachineMessages.TurnWhenSoldOut);
            }
            else if (state == HAS_QUARTER)
            {
                Console.WriteLine(MachineMessages.TurnSuccessfully);
                state = SOLD;
                Dispense();
            }
        }

        public void Dispense()
        {
            if (state == SOLD)
            {
                Console.WriteLine(MachineMessages.DispenseSuccessfully);
                count = count - 1;
                if (count == 0)
                {
                    Console.WriteLine(MachineMessages.DispenseTheLastGumball);
                    state = SOLD_OUT;
                }
                else
                {
                    state = NO_QUARTER;
                }
            }
            else if (state == NO_QUARTER)
            {
                Console.WriteLine(MachineMessages.DispenseWhenNoQuarter);
            }
            else if (state == SOLD_OUT)
            {
                Console.WriteLine(MachineMessages.DispenseWhenSoldOut);
            }
            else if (state == HAS_QUARTER)
            {
                Console.WriteLine(MachineMessages.DispenseWhenHasQuarter);
            }
        }
    }
}