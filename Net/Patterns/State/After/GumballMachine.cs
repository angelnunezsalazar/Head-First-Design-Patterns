namespace Patterns.State.After
{
    public class GumballMachine
    {
        public IState State { get; set; }

        public int Count { get; set; }

        public GumballMachine(int count)
        {
            State=new SoldOutState();
            this.Count = count;
            if (count > 0)
            {
                this.State=new NoQuarterState(this);
            }
        }

        public void InsertQuarter()
        {
            this.State.Insert();
        }

        public void EjectQuarter()
        {
            this.State.Eject();
        }

        public void TurnCrank()
        {
            this.State.TurnCrank();
        }

        public void Dispense()
        {
            this.State.Dispense();
        }
    }
}