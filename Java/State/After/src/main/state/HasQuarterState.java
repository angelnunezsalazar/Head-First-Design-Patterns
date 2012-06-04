package state;

public class HasQuarterState implements State {
	GumballMachine gumballMachine;
 
	public HasQuarterState(GumballMachine gumballMachine) {
		this.gumballMachine = gumballMachine;
	}
  
	public void insertQuarter() {
		System.out.println(MachineMessages.InsertTwice);
	}
 
	public void ejectQuarter() {
		System.out.println(MachineMessages.EjectSuccessfully);
		gumballMachine.setState(gumballMachine.getNoQuarterState());
	}
 
	public void turnCrank() {
		System.out.println(MachineMessages.TurnSuccessfully);
		gumballMachine.setState(gumballMachine.getSoldState());
		gumballMachine.dispense();
	}

    public void dispense() {
        System.out.println(MachineMessages.DispenseWhenHasQuarter);
    }
}
