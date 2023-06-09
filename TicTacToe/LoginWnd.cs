using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class LoginWnd : Form
    {
        private string playerOrder;
        internal string playerName;
        internal LoginWndState state;
        public LoginWnd(string playerOrder)
        {
            this.playerOrder = playerOrder;
            state = LoginWndState.Unsuccessful;
            InitializeComponent();
        }

        private void AuthorizationWnd_Load(object sender, EventArgs e)
        {
            lbAuthorization.Text = $"Enter the name of the {playerOrder} player";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int textLength = tbName.Text.Length;
            if (textLength < 1 || textLength > 6)
            {
                MessageBox.Show("Name must not contain more than 6 and less than 1 letters",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            playerName = tbName.Text;
            state = LoginWndState.Successful;
            Close();
        }

        private void AuthorizationWnd_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (state != LoginWndState.Successful)
            {
                if (MessageBox.Show("You will lose your login progress. Do you want to exit?",
                                    "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    state = LoginWndState.Repeat;
                else state = LoginWndState.Unsuccessful;
            }
        }

        private void Enter_Click(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) btnSubmit_Click(sender, e);
        }
    }
}
