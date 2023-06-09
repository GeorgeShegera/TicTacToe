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
    public partial class OptionsWnd : Form
    {
        public OptionsWnd()
        {
            InitializeComponent();
        }

        private void OptionsWnd_Load(object sender, EventArgs e)
        {
            switch (MainWnd.GameOption)
            {
                case Option.PlayX:
                    rbPlayX.Checked = true;
                    break;
                case Option.PlayO:
                    rbPlayO.Checked = true;
                    break;
                case Option.Random:
                    rbRandom.Checked = true;
                    break;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (rbPlayX.Checked) MainWnd.GameOption = Option.PlayX;
            else if (rbPlayO.Checked) MainWnd.GameOption = Option.PlayO;
            else MainWnd.GameOption = Option.Random;
            Close();
        }
    }
}
