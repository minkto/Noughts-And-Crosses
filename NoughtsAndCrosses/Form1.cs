using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoughtsAndCrosses {
    public partial class Form1 : Form {

        private Grid mainGrid;
        private Player player1;
        private Player player2;

        public Form1() {
            InitializeComponent();

            mainGrid = new Grid();
            player1 = new Player("Cross",Properties.Resources.Cross);
            player2 = new Player("Circle", Properties.Resources.Circle);

            mainGrid.player = player1;

        }

        /// <summary>
        /// Places a symbol on the grid and shows it via the UI.
        /// </summary>
        /// <param name="row"> The row to be selected.</param>
        /// <param name="col"> The column to be selected.</param>
        /// <param name="button"> The button which has been selected.</param>
        private void PlayMove(int row ,int col,Button button) {
            if (mainGrid.grid[row, col].IsCellEmpty()) {
                mainGrid.grid[row, col].Symbol = mainGrid.player.SymbolType;
                button.BackgroundImage = mainGrid.player.SymbolIcon;

                if (mainGrid.CheckWin()) {
                    Console.WriteLine("Disable all controls now. A player has woooon!!");
                    DisableGrid();
                    IncrementScore();
                    WinnerLabel.Visible = true;
                }
                else {

                    mainGrid.ChangePlayer(player1, player2);
                }
            }

        }
        private void cell_0_0_Click(object sender, EventArgs e) {
            PlayMove(0, 0,cell_0_0);
        }

        private void cell_0_1_Click(object sender, EventArgs e) {
            PlayMove(0, 1,cell_0_1);
        }

        private void cell_0_2_Click(object sender, EventArgs e) {
            PlayMove(0, 2,cell_0_2);
        }

        private void cell_1_0_Click(object sender, EventArgs e) {
            PlayMove(1, 0,cell_1_0);
        }

        private void cell_1_1_Click(object sender, EventArgs e) {
            PlayMove(1, 1,cell_1_1);
        }

        private void cell_1_2_Click(object sender, EventArgs e) {
            PlayMove(1, 2,cell_1_2);
        }

        private void cell_2_0_Click(object sender, EventArgs e) {
            PlayMove(2, 0,cell_2_0);
        }

        private void cell_2_1_Click(object sender, EventArgs e) {
            PlayMove(2, 1,cell_2_1);
        }

        private void cell_2_2_Click(object sender, EventArgs e) {
            PlayMove(2, 2,cell_2_2);
        }


        /// <summary>
        /// Disables all the buttons used to place symbols.
        /// </summary>
        public void DisableGrid() {
            cell_0_0.Enabled = false;
            cell_0_1.Enabled = false;
            cell_0_2.Enabled = false;
            cell_1_0.Enabled = false;
            cell_1_1.Enabled = false;
            cell_1_2.Enabled = false;
            cell_2_0.Enabled = false;
            cell_2_1.Enabled = false;
            cell_2_2.Enabled = false;
        }

  
        /// <summary>
        /// Increments the scores for players and sets a congradulation label for 
        /// whoever wins.
        /// </summary>
        public void IncrementScore() {
            
            if (mainGrid.player.Equals(player1)) {
                int score = Convert.ToInt32(Player1WinScoreLabel.Text);
                score++;
                Player1WinScoreLabel.Text = score.ToString();
                WinnerLabel.Text = "Congradulations Player 1";

            }
            else {
                int score = Convert.ToInt32(Player2WinScoreLabel.Text);
                score++;
                Player2WinScoreLabel.Text = score.ToString();
                WinnerLabel.Text = "Congradulations Player 2";

            }
        } 

        
        /// <summary>
        /// Resets the score placed on the score board.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetScore_Click(object sender, EventArgs e) {
            Player1WinScoreLabel.Text = "0";
            Player2WinScoreLabel.Text = "0";
        }


        /// <summary>
        /// Starts a new game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartNewGame_Click(object sender, EventArgs e) {
            WinnerLabel.Visible = false;

            mainGrid = new Grid();
            player1 = new Player("Cross", Properties.Resources.Cross);
            player2 = new Player("Circle", Properties.Resources.Circle);

            mainGrid.player = player1;

            cell_0_0.Enabled = true;
            cell_0_0.BackgroundImage = null;

            cell_0_1.Enabled = true;
            cell_0_1.BackgroundImage = null;

            cell_0_2.Enabled = true;
            cell_0_2.BackgroundImage = null;

            cell_1_0.Enabled = true;
            cell_1_0.BackgroundImage = null;

            cell_1_1.Enabled = true;
            cell_1_1.BackgroundImage = null;

            cell_1_2.Enabled = true;
            cell_1_2.BackgroundImage = null;

            cell_2_0.Enabled = true;
            cell_2_0.BackgroundImage = null;

            cell_2_1.Enabled = true;
            cell_2_1.BackgroundImage = null;

            cell_2_2.Enabled = true;
            cell_2_2.BackgroundImage = null;
        }
    }
}
