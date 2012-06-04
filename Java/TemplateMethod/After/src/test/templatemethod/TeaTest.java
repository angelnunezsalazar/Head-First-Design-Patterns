package templatemethod;

import static org.junit.Assert.*;

import java.io.ByteArrayOutputStream;
import java.io.PrintStream;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class TeaTest {

	private final ByteArrayOutputStream outContent = new ByteArrayOutputStream();

	@Before
	public void setUp() {
		System.setOut(new PrintStream(outContent));
	}

	@After
	public void tearDown() {
		System.setOut(null);
	}

	@Test
	public void PrepareRecipe() {
		Tea tea = new Tea();

		tea.prepareRecipe();

		assertTrue(this.outContent.toString().contains(BeverageMessages.BoilWater));
		assertTrue(this.outContent.toString().contains(BeverageMessages.SteepTeaBag));
		assertTrue(this.outContent.toString().contains(BeverageMessages.PourInCup));
		assertTrue(this.outContent.toString().contains(BeverageMessages.AddLemon));
	}
}
