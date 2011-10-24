namespace Patterns.State.After
{
    public class GumballMachine
    {
        public readonly IState SoldOut;

        public readonly IState NoQuarter;

        public readonly IState HasQuarter;

        public readonly IState Sold;

        public IState State { get; set; }

        public int Count { get; set; }

        public GumballMachine(int count)
        {
            this.SoldOut = new SoldOutState();
            this.NoQuarter = new NoQuarterState(this);
            this.HasQuarter = new HasQuarterState(this);
            this.Sold = new SoldState(this);

            this.State = SoldOut;
            this.Count = count;
            if (count > 0)
            {
                this.State = NoQuarter;
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
            this.State.Turn();
        }

        public void Dispense()
        {
            this.State.Dispense();
        }
    }
}