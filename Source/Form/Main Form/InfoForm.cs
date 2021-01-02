using Guna.UI.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Caro
{
    public partial class InfoForm : Form
    {
        #region Properties
        private bool mouseDown;
        private Point lastLocation;
        public BoardManager CheckBoard;
        readonly bool Mode;//Game Mode : true = PvP / false = PvC
        #endregion

        #region Initialize
        public InfoForm(bool GameMode)
        {
            InitializeComponent();
            Mode = GameMode; // true = PvP / false = PvC
            if (GameMode == false) //Set Player2 Name to "Bot" if PvC
            {
                Player2NameBox.Text = "Bot";
                Player2NameBox.Enabled = false;
                avap2.Enabled = false;
                //setting for PvC
                Cons.Player1_avt_num = 6;
                Cons.Player2_avt_num = 9;
            }
            else
            {
                //setting for PvP
                Cons.Player1_avt_num = 6;
                Cons.Player2_avt_num = 5;
            }
            Player1Mark.Image = Cons.Player1_icon_IMG;
            Player2Mark.Image = Cons.Player2_icon_IMG;
            Cons.Player1_score = 0;
            Cons.Player2_score = 0;

            avap1.Image = Cons.Player_avt_IMG[Cons.Player1_avt_num];
            avap2.Image = Cons.Player_avt_IMG[Cons.Player2_avt_num];

        }
        #endregion

        #region Event
        #region Click
        private void BackButton_Click(object sender, EventArgs e)
        {
            sound.Play(sound.click2);
            //Show StartForm
            foreach (Form frm in Application.OpenForms)
                frm.Visible = true;
            //close InfoForm
            Close();
        }
        private void PlayerNameBox_Enter(object sender, EventArgs e)
        {
            sound.Play(sound.click2);
            var textbox = (GunaTextBox)sender;
            textbox.Text = "";
        } //Clear Name when Click PlayerNameBox
        private void PlayerNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                StartButton.Select();
                sound.Play(sound.click2);
            }
            }
        private void avap1_Click(object sender, EventArgs e)
        {
            sound.Play(sound.click);
            PictureBox p = (PictureBox)sender;
            Point location = new Point(Location.X + p.Location.X + PanelPlayer1.Location.X, Location.Y + p.Location.Y + PanelPlayer1.Location.Y);
            createAvatarMenu(1, location);
        }
        private void avap2_Click(object sender, EventArgs e)
        {
            sound.Play(sound.click);
            PictureBox p = (PictureBox)sender;
            Point location = new Point(Location.X + p.Location.X + PanelPlayer2.Location.X, Location.Y + p.Location.Y + PanelPlayer2.Location.Y); ;
            createAvatarMenu(2, location);
        }
        #endregion

        #region Move Form
        private void Logo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }
        private void Logo_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void Logo_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion
        #endregion

        #region Method
        private void NewPlayForm(object sender, EventArgs e)
        {
            sound.Play(sound.click2);
            Hide();
            //Create PLayForm and close InfoForm
            Cons.Player1_avt_IMG = avap1.Image;
            Cons.Player2_avt_IMG = avap2.Image;
            Cons.Player1_Name = Player1NameBox.Text;
            Cons.Player2_Name = Player2NameBox.Text;
            f.pForm = new PlayForm(Mode);
            f.pForm.Show();
            //annouce first move player
            f.pForm.AnnounceCurPlayer();
            //focus middle
            f.pForm.CheckBoard.btn[Cons.chess_board_width / 2, Cons.chess_board_height / 2].Focus();
            Close();
        }
        private void createAvatarMenu(int player, Point location)
        {
            Console.WriteLine(location.X + " " + location.Y);
            AvatarForm aMenu = new AvatarForm(player, location);
            aMenu.ShowDialog();
        }
        #endregion
    }
}
