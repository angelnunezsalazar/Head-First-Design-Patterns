package templatemethod;

public class Coffee {
 
	public void prepareRecipe() {
		boilWater();
		brewCoffeeGrinds();
		pourInCup();
		addSugarAndMilk();
	}
 
	private void boilWater() {
		System.out.println(BeverageMessages.BoilWater);
	}
 
	private void brewCoffeeGrinds() {
		System.out.println(BeverageMessages.BrewCoffeeGrinds);
	}
 
	private void pourInCup() {
		System.out.println(BeverageMessages.PourInCup);
	}
 
	private void addSugarAndMilk() {
		System.out.println(BeverageMessages.AddSugarAndMilk);
	}
}
