using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NoughtsAndCrosses {

    public class Player {
        private string symbolType;
        private Bitmap symbolIcon;

        public string SymbolType { get { return symbolType; } set { symbolType = value; } }
        public Bitmap SymbolIcon { get { return symbolIcon; } set { symbolIcon = value; } }

        // Constructors
        public Player(string symbolType) {
            this.symbolType = symbolType;

        }

        public Player(string symbolType,Bitmap symbolIcon) {
            this.symbolType = symbolType;
            this.symbolIcon = symbolIcon;

        }

        

    }
}
