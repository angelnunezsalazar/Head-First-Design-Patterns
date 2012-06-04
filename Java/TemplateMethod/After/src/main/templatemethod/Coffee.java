package templatemethod;

public class Coffee extends Beverage {
	protected void brew() {
		System.out.println("Dripping Coffee through filter");
	}
	protected void addCondiments() {
		System.out.println("Adding Sugar and Milk");
	}
}
