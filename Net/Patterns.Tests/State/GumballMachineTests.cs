namespace Patterns.Tests.State
{
    using System;
    using System.IO;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Patterns.State;

    [TestClass]
    public class GumballMachineTests
    {
        private const int NO_GUMBALLS = 0;

        private StringWriter sw;

        [TestInitialize]
        public void Setup()
        {
            sw = new StringWriter();
            Console.SetOut(sw);
        }

        [TestMethod]
        public void InsertQuarter()
        {
            var gumballMachine = CreateGumballMachine(1);

            gumballMachine.InsertQuarter();

            AssertMachineMessage(MachineMessages.InsertSuccessfully);
        }

        [TestMethod]
        public void InsertQuarterTwice()
        {
            GumballMachine gumballMachine = CreateGumballMachine(1);

            gumballMachine.InsertQuarter();
            gumballMachine.InsertQuarter();

            AssertMachineMessage(MachineMessages.InsertTwice);
        }

        [TestMethod]
        public void InsertWhenSoldOut()
        {
            const int NO_GUMBALLS = 0;
            GumballMachine gumballMachine = CreateGumballMachine(NO_GUMBALLS);

            gumballMachine.InsertQuarter();

            AssertMachineMessage(MachineMessages.InsertWhenSoldOut);
        }

        [TestMethod]
        public void EjectQuarter()
        {
            GumballMachine gumballMachine = CreateGumballMachine(1);

            gumballMachine.InsertQuarter();
            gumballMachine.EjectQuarter();

            AssertMachineMessage(MachineMessages.EjectSuccessfully);
        }

        [TestMethod]
        public void EjectWhenNoQuarter()
        {
            GumballMachine gumballMachine = CreateGumballMachine(1);

            gumballMachine.EjectQuarter();

            AssertMachineMessage(MachineMessages.EjectWhenNoQuarter);
        }

        [TestMethod]
        public void EjectWhenSoldOut()
        {
            GumballMachine gumballMachine = CreateGumballMachine(NO_GUMBALLS);

            gumballMachine.EjectQuarter();

            AssertMachineMessage(MachineMessages.EjectWhenSoldOut);
        }

        [TestMethod]
        public void TurnWhenSoldOut()
        {
            GumballMachine gumballMachine = CreateGumballMachine(NO_GUMBALLS);

            gumballMachine.TurnCrank();

            AssertMachineMessage(MachineMessages.TurnWhenSoldOut);
        }

        [TestMethod]
        public void TurnWhenNoQuarter()
        {
            GumballMachine gumballMachine = CreateGumballMachine(1);

            gumballMachine.TurnCrank();

            AssertMachineMessage(MachineMessages.TurnWhenNoQuarter);
        }

        [TestMethod]
        public void Dispense()
        {
            GumballMachine gumballMachine = CreateGumballMachine(1);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            AssertMachineMessage(MachineMessages.TurnSuccessfully);
            AssertMachineMessage(MachineMessages.DispenseSuccessfully);
        }

        [TestMethod]
        public void DispenseTheLastGumball()
        {
            GumballMachine gumballMachine = CreateGumballMachine(1);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            AssertMachineMessage(MachineMessages.DispenseTheLastGumball);
        }

        [TestMethod]
        public void DispenseWhenNoQuarter()
        {
            GumballMachine gumballMachine = CreateGumballMachine(1);

            gumballMachine.Dispense();

            AssertMachineMessage(MachineMessages.DispenseWhenNoQuarter);
        }

        [TestMethod]
        public void DispenseWhenHasQuarter()
        {
            GumballMachine gumballMachine = CreateGumballMachine(1);

            gumballMachine.InsertQuarter();
            gumballMachine.Dispense();

            AssertMachineMessage(MachineMessages.DispenseWhenHasQuarter);
        }

        [TestMethod]
        public void DispenseWhenSoldOut()
        {
            GumballMachine gumballMachine = CreateGumballMachine(NO_GUMBALLS);

            gumballMachine.Dispense();

            AssertMachineMessage(MachineMessages.DispenseWhenSoldOut);
        }

        private static GumballMachine CreateGumballMachine(int count)
        {
            GumballMachine gumballMachine = new GumballMachine(count);
            return gumballMachine;
        }

        private void AssertMachineMessage(string message)
        {
            Assert.IsTrue(sw.ToString().Contains(message));
        }

        [TestCleanup]
        public void TearDown()
        {
            sw.Dispose();
        }
    }
}