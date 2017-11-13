using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoughtsAndCrosses {
    public class Cell {


        private string symbol;

        public Cell() {
            symbol = "EMPTY";
        }

        /// <summary>
        /// The symbol of the current cell.
        /// </summary>
        public string Symbol {
            get {
                return symbol;
            }
            set {
                if (IsCellEmpty()) {
                    symbol = value;
                }
            }
        }


        /// <summary>
        /// Checks to see if the current cell is empty.
        /// </summary>
        /// <returns></returns>
        public bool IsCellEmpty() {
            if (symbol.Equals("EMPTY")) {                             
                return true;
            }
            else {
                return false;
            }

        }



    }
}
