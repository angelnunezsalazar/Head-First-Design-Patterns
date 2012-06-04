package state;

public class SoldOutState implements State {
    GumballMachine gumballMachine;
 
    public SoldOutState(GumballMachine gumballMachine) {
        this.gumballMachine = gumballMachine;
    }
 
	public void insertQuarter() {
		System.out.println(MachineMessages.InsertWhenSoldOut);
	}
 
	public void ejectQuarter() {
		System.out.println(MachineMessages.EjectWhenSoldOut);
	}
 
	public void turnCrank() {
		System.out.println(MachineMessages.TurnWhenSoldOut);
	}
 
	public void dispense() {
		System.out.println(MachineMessages.DispenseWhenSoldOut);
	}
}
