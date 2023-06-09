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
    public partial class GameEndWnd : Form
    {
        private GameResult gameResult;
        private string winnerName;
        private string winnerSymbol;
        internal static bool playAgain = false;

        public GameEndWnd(GameResult gameResult, string winnerName, string winnerSymbol)
        {
            this.gameResult = gameResult;
            this.winnerName = winnerName;
            this.winnerSymbol = winnerSymbol;
            InitializeComponent();
        }

        private string GetGameResule()
        {
            switch(gameResult)
            {
                case GameResult.Victory: return "Victory!";
                case GameResult.Draw: return "Draw!";
                case GameResult.Defeat: return "Defeat =(";
                default: return "";
            }
        }

        private void GameEndWnd_Load(object sender, EventArgs e)
        {            
            lbResult.Text = GetGameResule();            
            lbCongr.Text = gameResult == GameResult.Draw ? "You both are worthy opponents": 
                                                            $"{winnerName} has won, playing with {winnerSymbol}";
        }        

        private void Button_Click(object sender, EventArgs e)
        {            
            playAgain = ((Button)sender).Name == "btnPlayAgain";
            Close();
        }
    }
}
