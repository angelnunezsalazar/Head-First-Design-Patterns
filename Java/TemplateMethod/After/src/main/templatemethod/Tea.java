package templatemethod;

public class Tea extends Beverage {
	protected void brew() {
		System.out.println("Steeping the tea");
	}
	protected void addCondiments() {
		System.out.println("Adding Lemon");
	}
}
