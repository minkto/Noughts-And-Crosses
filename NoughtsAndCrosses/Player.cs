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

        /// <summary>
        /// The symbol string belonging to this player.
        /// </summary>
        public string SymbolType { get { return symbolType; } set { symbolType = value; } }

        /// <summary>
        /// The symbol bitmap image belonging to this player.
        /// </summary>
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
