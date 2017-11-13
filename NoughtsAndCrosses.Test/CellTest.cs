using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NoughtsAndCrosses.Test {
    [TestClass]
    public class CellTest {


        [TestMethod]
        public void TestSymbolProperty() {
            Cell cell = new Cell();
            cell.Symbol = "Cross";
            Assert.IsTrue(cell.Symbol.Equals("Cross"));

            cell.Symbol = "Circle";
            Assert.IsFalse(cell.Symbol.Equals("Circle"));


        }


    }
}
