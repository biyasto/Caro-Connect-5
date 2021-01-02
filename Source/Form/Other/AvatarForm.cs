using System;
using System.Drawing;
using System.Windows.Forms;

namespace Caro
{
    public partial class AvatarForm : Form
    {
        readonly int Player;
        public AvatarForm(int CheckChoose, Point location)
        {
            InitializeComponent();
            Player = CheckChoose;
            StartPosition = FormStartPosition.Manual;
            Location = location;
        }


        private void pictureBox_Click(object sender, EventArgs e)
        {
            sound.Play(sound.click2);
            PictureBox p = (PictureBox)sender;
            //find index pic by location
            Setting(Player, p.Location.X / 75 + 3 * p.Location.Y / 75);
        }
        private void Setting(int player, int num)
        {
            if (player == 1)
            {
                f.iForm.avap1.Image = Cons.Player_avt_IMG[num];
                Cons.Player1_avt_num = num;
            }
            else
            {
                f.iForm.avap2.Image = Cons.Player_avt_IMG[num];
                Cons.Player2_avt_num = num;
            }
            Close();
           
        }


    }
}
