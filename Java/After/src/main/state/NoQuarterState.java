package state;

public class NoQuarterState implements State {
    GumballMachine gumballMachine;
 
    public NoQuarterState(GumballMachine gumballMachine) {
        this.gumballMachine = gumballMachine;
    }
 
	public void insertQuarter() {
		System.out.println(MachineMessages.InsertSuccessfully);
		gumballMachine.setState(gumballMachine.getHasQuarterState());
	}
 
	public void ejectQuarter() {
		System.out.println(MachineMessages.EjectWhenNoQuarter);
	}
 
	public void turnCrank() {
		System.out.println(MachineMessages.TurnWhenNoQuarter);
	 }
 
	public void dispense() {
		System.out.println(MachineMessages.DispenseWhenNoQuarter);
	} 
}
