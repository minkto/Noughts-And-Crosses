using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoughtsAndCrosses {
    public class Grid {

        public Cell[,] grid;
        public Player player;
       

        public Grid() {
            // 1. Initialise the grid.
            grid = new Cell[3, 3];

            // 2. Set all the cells as null.
            for (int i = 0; i < grid.GetLength(0); i++) {
                for (int j = 0; j < grid.GetLength(0); j++) {
                    grid[i, j] = new Cell();
                    
                                     
                }
            }

        } // end of constructor

        public bool CheckVerticalWin() {
            // Check rows vertcally all match a certain symbol.

            for (int i = 0; i < grid.GetLength(0); i++) {
                if (grid[0, i].Symbol == player.SymbolType && grid[1, i].Symbol == player.SymbolType && grid[2, i].Symbol == player.SymbolType) {
                    return true;
                }

            }
            return false;
        }



        public bool CheckHorizontalWin() {
            // Check rows horizonally all match a certain symbol.

            for (int i = 0; i < grid.GetLength(0); i++) {
                if (grid[i, 0].Symbol == player.SymbolType && grid[i, 1].Symbol == player.SymbolType && grid[i, 2].Symbol == player.SymbolType) {
                    return true;
                }

            }
            return false;
        }


        public bool CheckDiagonalWin() {
            // Check rows horizonally all match a certain symbol.

            int i = 0;
            if (grid[i, i].Symbol == player.SymbolType && grid[i + 1, i + 1].Symbol == player.SymbolType && grid[i + 2, i + 2].Symbol == player.SymbolType) {
                return true;
            }



            i = grid.GetLength(0) - 1;

            if (grid[i, 0].Symbol == player.SymbolType && grid[i-1, i-1].Symbol == player.SymbolType && grid[i-2, i].Symbol == player.SymbolType) {
                return true;
            }


            return false;
        }

        public bool CheckWin() {
            if (CheckHorizontalWin() || CheckVerticalWin() || CheckDiagonalWin()) {
                Console.WriteLine("A player has won!!!");
                return true;
            }
            else {
                return false;
            }
        }

        public void ChangePlayer(Player player1,Player player2) {
            if (this.player.Equals(player1)) {
                this.player = player2;
            }
            else {
                this.player = player1;
            }
        }


        

    } // end class


}

