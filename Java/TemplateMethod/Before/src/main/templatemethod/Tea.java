package templatemethod;

public class Tea {
 
	public void prepareRecipe() {
		boilWater();
		steepTeaBag();
		pourInCup();
		addLemon();
	}
 
	private void boilWater() {
		System.out.println(BeverageMessages.BoilWater);
	}
 
	private void steepTeaBag() {
		System.out.println(BeverageMessages.SteepTeaBag);
	}
 
	private void pourInCup() {
		System.out.println(BeverageMessages.PourInCup);
	}
	
	private void addLemon() {
		System.out.println(BeverageMessages.AddLemon);
	}
}
