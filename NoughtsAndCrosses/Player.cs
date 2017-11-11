using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoughtsAndCrosses {

    class Player {
        private string symbolType;

        public string SymbolType { get { return symbolType; } set { symbolType = value; } }

        public Player(string symbolType) {
            this.symbolType = symbolType;
        }
   
    }
}
