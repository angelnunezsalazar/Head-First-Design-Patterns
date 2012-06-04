package state;

public class SoldState implements State {
 
    GumballMachine gumballMachine;
 
    public SoldState(GumballMachine gumballMachine) {
        this.gumballMachine = gumballMachine;
    }
       
	public void insertQuarter() {
		System.out.println(MachineMessages.InsertWhenSold);
	}
 
	public void ejectQuarter() {
		System.out.println(MachineMessages.EjectWhenSold);
	}
 
	public void turnCrank() {
		System.out.println(MachineMessages.TurnTwice);
	}
 
	public void dispense() {
		gumballMachine.releaseBall();
		if (gumballMachine.getCount()== 0) {
			gumballMachine.setState(gumballMachine.getSoldOutState());
			System.out.println(MachineMessages.DispenseTheLastGumball);
		} else {
			gumballMachine.setState(gumballMachine.getNoQuarterState());
		}
	}
}


