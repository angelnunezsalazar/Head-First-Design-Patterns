namespace Patterns.State.After
{
    public interface IState
    {
        void Insert();

        void Eject();

        void TurnCrank();

        void Dispense();
    }
}