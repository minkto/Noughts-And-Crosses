using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoughtsAndCrosses {
    class Grid {

        Cell[,] grid;
        Player player;

        public Grid() {
            // 1. Initialise the grid.
            grid = new Cell[3, 3];

            // 2. Set all the cells as null.
            for (int i = 0; i < grid.Length; i++) {
                for (int j = 0; j < grid.Length; j++) {
                    grid[i, j].Symbol = null;
                }
            }

        } // end of constructor

        public bool CheckVerticalWin() {
            // Check rows vertcally all match a certain symbol.

            for (int i = 0; i < grid.Length; i++) {
                if (grid[0, i].Symbol == player.SymbolType && grid[1, i].Symbol == player.SymbolType && grid[2, i].Symbol == player.SymbolType) {
                    return true;
                }

            }
            return false;
        }



        public bool CheckHorizontalWin() {
            // Check rows horizonally all match a certain symbol.

            for (int i = 0; i < grid.Length; i++) {
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



            i = grid.Length;

            if (grid[i, i].Symbol == player.SymbolType && grid[i - 1, i - 1].Symbol == player.SymbolType && grid[i - 2, i - 2].Symbol == player.SymbolType) {
                return true;
            }


            return false;
        }

    } // end class


} 

