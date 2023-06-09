using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using TicTacToeLib;
using Point = TicTacToeLib.Point;

namespace TicTacToe
{
    public partial class GameWnd : Form
    {
        private bool vsBot;
        private Player firstPlayer;
        private Player secondPlayer;
        private Bot bot;

        private GameResult gameResult;

        private Field GameField { get; set; }
        private List<List<Button>> Buttons { get; }
        private string CurName { get; set; }

        private Symbol curSymbol;

        public GameWnd(bool vsBot)
        {
            this.vsBot = vsBot;
            GameField = new Field();
            InitializeComponent();
            Buttons = new List<List<Button>>
            {
                new List<Button>{ btnCell1, btnCell2, btnCell3 },
                new List<Button>{ btnCell4, btnCell5, btnCell6 },
                new List<Button>{ btnCell7, btnCell8, btnCell9 }
            };
        }

        private void ClearField()
        {
            GameField = new Field();
            foreach (List<Button> buttons in Buttons)
            {
                foreach (Button button in buttons)
                {
                    button.Text = "";
                }
            }
        }
      
        private void GetPoint(Button clickedButton, out Point point)
        {
            point = new Point();
            foreach (List<Button> buttons in Buttons)
            {
                foreach (Button button in buttons)
                {
                    if (button.Name == clickedButton.Name)
                    {
                        point = new Point(buttons.IndexOf(button), Buttons.IndexOf(buttons));
                        return;
                    }
                }
            }
        }

        private void SwitchCurData()
        {
            curSymbol = SwitchSymbol(curSymbol);
            if (vsBot) SwitchName(firstPlayer.Name);
            else SwitchName(firstPlayer.Name, secondPlayer.Name);
            void SwitchName(string firstName, string secName = "Bot")
                => CurName = CurName == firstName ? secName : firstName;
        }

        public static Symbol SwitchSymbol(Symbol symbol) => symbol == Symbol.X ? Symbol.O : Symbol.X;        

        private Symbol SelectSymbol()
        {
            switch (MainWnd.GameOption)
            {
                case Option.PlayX: return Symbol.X;
                case Option.PlayO: return Symbol.O;
                case Option.Random: return (Symbol)new Random().Next(0, 2);
                default: return new Symbol();
            }
        }

        private bool Login(ref Player player, string nameOrder)
        {
            LoginWnd loginWnd = new LoginWnd(nameOrder);
            do
            {
                loginWnd.ShowDialog();
            } while (loginWnd.state == LoginWndState.Repeat);
            if (loginWnd.state != LoginWndState.Successful)
            {
                Close();
                return false;
            }
            player = new Player(loginWnd.playerName);
            return true;
        }

        private void GameWnd_Load(object sender, EventArgs e)
        {
            gameResult = GameResult.None;
            Symbol gameItem = SelectSymbol();
            if (!GameEndWnd.playAgain)
            {
                if (!Login(ref firstPlayer, "first")) return;
                if (vsBot) bot = new Bot(SwitchSymbol(gameItem));
                else if (!Login(ref secondPlayer, "second")) return;
            }
            GameEndWnd.playAgain = false;
            firstPlayer.GameSymbol = gameItem;
            gameItem = SwitchSymbol(gameItem);
            if (!vsBot) secondPlayer.GameSymbol = gameItem;
            else bot.symbol = gameItem;
            curSymbol = Symbol.X;
            CurName = curSymbol == firstPlayer.GameSymbol ? firstPlayer.Name : (vsBot ? "Bot" : secondPlayer.Name);
            lbCurPlayer.Text = $"Player {CurName} plays with X";
            if (vsBot && bot.symbol == curSymbol) MakeMove(bot.SelectPoint(GameField));
        }

        private void cellBtn_Click(object sender, EventArgs e)
        {
            GetPoint((Button)sender, out Point point);
            if (!GameField.FreeCell(point))
            {
                MessageBox.Show("This cell has already occupied", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MakeMove(point);
            if (gameResult == GameResult.None && vsBot) MakeMove(bot.SelectPoint(GameField));
        }

        private void MakeMove(Point point)
        {
            GameField[point].symbol = curSymbol;
            Buttons[point.CoordY][point.CoordX].Text = curSymbol.ToString();
            if (EndOfGame(GameField, curSymbol))
            {
                GameEndWnd endWnd = new GameEndWnd(gameResult, CurName, curSymbol.ToString());
                endWnd.ShowDialog();
                Close();
                if (GameEndWnd.playAgain) ClearField();
                return;
            }
            if (GameField.IsClear) GameField.IsClear = false;
            SwitchCurData();
            lbCurPlayer.Text = $"Player {CurName} plays with {curSymbol}";            
        }

        public bool EndOfGame(Field field, Symbol symbol)
        {
            bool gameEnd = true;
            if (Field.CheckVictory(field, symbol))
            {
                if (vsBot && CurName == "Bot") gameResult = GameResult.Defeat;
                else gameResult = GameResult.Victory;
            }
            else if (Field.CheckDraw(field)) gameResult = GameResult.Draw;
            else gameEnd = false;
            return gameEnd;
        }
    }
}
