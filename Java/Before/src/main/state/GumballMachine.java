package state;

public class GumballMachine {

	final static int SOLD_OUT = 0;
	final static int NO_QUARTER = 1;
	final static int HAS_QUARTER = 2;
	final static int SOLD = 3;

	int state = SOLD_OUT;
	int count = 0;

	public GumballMachine(int count) {
		this.count = count;
		if (count > 0) {
			state = NO_QUARTER;
		}
	}

	public void insertQuarter() {
		if (state == HAS_QUARTER) {
			System.out.println(MachineMessages.InsertTwice);
		} else if (state == NO_QUARTER) {
			state = HAS_QUARTER;
			System.out.println(MachineMessages.InsertSuccessfully);
		} else if (state == SOLD_OUT) {
			System.out.println(MachineMessages.InsertWhenSoldOut);
		} else if (state == SOLD) {
			System.out.println(MachineMessages.InsertWhenSold);
		}
	}

	public void ejectQuarter() {
		if (state == HAS_QUARTER) {
			System.out.println(MachineMessages.EjectSuccessfully);
			state = NO_QUARTER;
		} else if (state == NO_QUARTER) {
			System.out.println(MachineMessages.EjectWhenNoQuarter);
		} else if (state == SOLD) {
			System.out.println(MachineMessages.EjectWhenSold);
		} else if (state == SOLD_OUT) {
			System.out.println(MachineMessages.EjectWhenSoldOut);
		}
	}

	public void turnCrank() {
		if (state == SOLD) {
			System.out.println(MachineMessages.TurnTwice);
		} else if (state == NO_QUARTER) {
			System.out.println(MachineMessages.TurnWhenNoQuarter);
		} else if (state == SOLD_OUT) {
			System.out.println(MachineMessages.TurnWhenSoldOut);
		} else if (state == HAS_QUARTER) {
			System.out.println(MachineMessages.TurnSuccessfully);
			state = SOLD;
			dispense();
		}
	}

	public void dispense() {
		if (state == SOLD) {
			System.out.println(MachineMessages.DispenseSuccessfully);
			count = count - 1;
			if (count == 0) {
				System.out.println(MachineMessages.DispenseTheLastGumball);
				state = SOLD_OUT;
			} else {
				state = NO_QUARTER;
			}
		} else if (state == NO_QUARTER) {
			System.out.println(MachineMessages.DispenseWhenNoQuarter);
		} else if (state == SOLD_OUT) {
			System.out.println(MachineMessages.DispenseWhenSoldOut);
		} else if (state == HAS_QUARTER) {
			System.out.println(MachineMessages.DispenseWhenHasQuarter);
		}
	}
}
