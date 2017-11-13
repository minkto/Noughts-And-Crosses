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
