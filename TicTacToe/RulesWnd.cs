using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class RulesWnd : Form
    {
        public RulesWnd()
        {
            InitializeComponent();
        }

        private void RulesWnd_Load(object sender, EventArgs e)
        {
            lbRules.Text = "Tic-tac-toe is played on a three-by-three grid by two players, " +
                           "who alternately place the marks X and O in one of the nine spaces in the grid." +
                           "In the following example, the first player (X) wins the game in seven steps:\n" +
                           "The game can be generalized to an m,n,k-game, in which two players alternate placing " +
                           "stones of their own color on an m-by-n board with the goal of getting k of their own " +
                           "color in a row. Tic-tac-toe is the 3,3,3-game.";
        }
    }
}
