using System;
using System.Drawing;
using System.Windows.Forms;

namespace Caro
{
    public partial class WinForm : Form
    {
        public WinForm(int winner)
        {
            InitializeComponent();
            if (winner == 1)
            {
                WinnerAvatar.Image = Cons.Player1_avt_IMG;
                WinnerNameBox.Text = Cons.Player1_Name;
                PlayerMark.Image = Cons.Player1_icon_IMG;
            }
            else
            {
                WinnerAvatar.Image = Cons.Player2_avt_IMG;
                WinnerNameBox.Text = Cons.Player2_Name;
                PlayerMark.Image = Cons.Player2_icon_IMG;
            }
            Location = new Point(f.pForm.Location.X + 295, f.pForm.Location.Y + 200);
            sound.Play(sound.victory);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            sound.Play(sound.click2);
            Close();
        }

        private void WinnerAvatar_Click(object sender, EventArgs e)
        {

        }
    }
}
