package state;

public class MachineMessages {
	public static final String InsertTwice = "You can't insert another quarter";

    public static final String InsertSuccessfully = "You inserted a quarter";

    public static final String InsertWhenSoldOut = "You can't insert a quarter, the machine is sold out";

    public static final String InsertWhenSold = "Please wait, we're already giving you a gumball";

    public static final String EjectSuccessfully = "Quarter returned";

    public static final String EjectWhenNoQuarter = "You haven't inserted a quarter";

    public static final String EjectWhenSoldOut = "You can't eject, you haven't inserted a quarter yet";

    public static final String EjectWhenSold = "You already turned the crank";

    public static final String TurnWhenNoQuarter = "You turned but there's no quarter";

    public static final String TurnTwice = "Turning twice doesn't get you another gumball!";

    public static final String TurnWhenSoldOut = "You turned, but there are no gumballs";

    public static final String TurnSuccessfully = "You turned...";

    public static final String DispenseWhenNoQuarter = "You need to pay first";

    public static final String DispenseTheLastGumball = "Oops, out of gumballs!";

    public static final String DispenseWhenSoldOut = "No gumball dispensed";

    public static final String DispenseSuccessfully = "A gumball comes rolling out the slot";

    public static final String DispenseWhenHasQuarter = "No gumball dispensed";
}
