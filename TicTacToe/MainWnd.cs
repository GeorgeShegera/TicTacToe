using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeLib;

namespace TicTacToe
{
    public partial class MainWnd : Form
    {
        public static Option GameOption { get; set; } = Option.PlayX;
        public MainWnd()
        {
            InitializeComponent();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            RulesWnd rulesWnd = new RulesWnd();
            rulesWnd.ShowDialog();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            OptionsWnd optionsWnd = new OptionsWnd();
            optionsWnd.ShowDialog();
        }        

        private void btnPlay_Click(object sender, EventArgs e)
        {
            GameWnd gameWnd = new GameWnd((sender as Button).Name == "btnVsBot");
            do
            {                
                gameWnd.ShowDialog();
            } while (GameEndWnd.playAgain);
        }
    }
}
