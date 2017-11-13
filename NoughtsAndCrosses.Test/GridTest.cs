using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NoughtsAndCrosses.Test {
    [TestClass]
    public class GridTest {

      

        [TestMethod]
        public void TestCheckVerticalWin() {
            // Create grid
            Grid mainGrid = new Grid();
            Player player = new Player("Circle");

            // Choose current player.
            mainGrid.player = player;

            /* For the first row  ->
             xxo
             xoo
             x0x
             */
            mainGrid.grid[0, 0].Symbol = player.SymbolType;
            mainGrid.grid[1, 0].Symbol = player.SymbolType;
            mainGrid.grid[2, 0].Symbol = player.SymbolType;

            Assert.IsTrue(mainGrid.CheckVerticalWin());
            /* For the second row  ->
            0x0
            xx0
            0xx
            */
            mainGrid.grid[0, 1].Symbol = player.SymbolType;
            mainGrid.grid[1, 1].Symbol = player.SymbolType;
            mainGrid.grid[2, 1].Symbol = player.SymbolType;

            Assert.IsTrue(mainGrid.CheckVerticalWin());
            /* For the third row ->
            00x
            xxx
            0xx
            */

            mainGrid.grid[0, 2].Symbol = player.SymbolType;
            mainGrid.grid[1, 2].Symbol = player.SymbolType;
            mainGrid.grid[2, 2].Symbol = player.SymbolType;

            Assert.IsTrue(mainGrid.CheckVerticalWin());
        }

        [TestMethod]
        public void TestCheckHorizontalWin() {
            Grid mainGrid = new Grid();
            Player player = new Player("Cross");

            mainGrid.player = player;

            /* For the first row  ->
             0xo
             xoo
             xxx
             */
            mainGrid.grid[0, 0].Symbol = player.SymbolType;
            mainGrid.grid[0, 1].Symbol = player.SymbolType;
            mainGrid.grid[0, 2].Symbol = player.SymbolType;

            Assert.IsTrue(mainGrid.CheckHorizontalWin());

            /* For the second row ->
             0xo
             xxx
             00x
             */
            mainGrid = new Grid();
            player = new Player("Circle");

            mainGrid.player = player;

            mainGrid.grid[1, 0].Symbol = player.SymbolType;
            mainGrid.grid[1, 1].Symbol = player.SymbolType;
            mainGrid.grid[1, 2].Symbol = player.SymbolType;

            Assert.IsTrue(mainGrid.CheckHorizontalWin());

            /* For the third row ->
             xxx
             x00
             00x
             */
            mainGrid = new Grid();
            player = new Player("Circle");

            mainGrid.player = player;

            mainGrid.grid[2, 0].Symbol = player.SymbolType;
            mainGrid.grid[2, 1].Symbol = player.SymbolType;
            mainGrid.grid[2, 2].Symbol = player.SymbolType;

            Assert.IsTrue(mainGrid.CheckHorizontalWin());
        }

        [TestMethod]
        public void TestCheckDiagonalWin() {
            Grid mainGrid = new Grid();
            Player player = new Player("Circle");

            mainGrid.player = player;

            

            mainGrid.grid[0, 0].Symbol = player.SymbolType;
            mainGrid.grid[1, 1].Symbol = player.SymbolType;
            mainGrid.grid[2, 2].Symbol = player.SymbolType;

            Assert.IsTrue(mainGrid.CheckDiagonalWin());

             mainGrid = new Grid();
             player = new Player("Circle");

            mainGrid.player = player;

            mainGrid.grid[2, 0].Symbol = player.SymbolType;
            mainGrid.grid[1, 1].Symbol = player.SymbolType;
            mainGrid.grid[0, 2].Symbol = player.SymbolType;
            Assert.IsTrue(mainGrid.CheckDiagonalWin());


        }

    }


}
