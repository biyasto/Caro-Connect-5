using System;
using System.Drawing;
using System.Windows.Forms;

namespace Caro
{
    public partial class AnnounceForm : Form
    {

        public AnnounceForm()
        {
            InitializeComponent();
            Location = new Point(f.pForm.Location.X + 250, f.pForm.Location.Y + 175);
            if (DataBoard.Get_Cur_Player() == 1)
            {
                Avatar.Image = Cons.Player1_avt_IMG;
                NameBox.Text = Cons.Player1_Name;
                PlayerMark.Image = Cons.Player1_icon_IMG;
            }
            else
            {
                Avatar.Image = Cons.Player2_avt_IMG;
                NameBox.Text = Cons.Player2_Name;
                PlayerMark.Image = Cons.Player2_icon_IMG;
            }
        }
        public void StartButton1_Click(object sender, EventArgs e)
        {
            sound.Play(sound.start);
            Close();
            f.pForm.timer.Start();
        }
    }
}
