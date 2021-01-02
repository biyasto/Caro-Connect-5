using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace Caro
{
    public partial class StartForm : Form
    {
        #region Properties
        private bool mouseDown;
        private Point lastLocation;
        #endregion

        #region Initialize
        public StartForm()
        {
            sound.Theme_start();
            InitializeComponent();
            SetUp_Setting();

        }
        private void SetUp_Setting()
        {
            
            SettingForm sF = new SettingForm(this.Location);
            sF.ReadSetting();
            sound.PlayTheme(true);
            sF.Close();
        }
        #endregion

        #region Method
        private void StartPvPButton_Click(object sender, EventArgs e)
        {
            sound.Play(sound.click);
            //Run InfoForm 
            RuniForm(true); //True = PvP 
            //MessageBox.Show("Click the avatars to change and click the name boxes to rename.", "Announcement");
        }
        private void StartPvCButton_Click(object sender, EventArgs e)
        {
            sound.Play(sound.click);
            //Run InfoForm 
            RuniForm(false);//False = PvC
        }
        private void RuniForm(bool Mode)
        {
            ModeButton.Focus();
            //Create InfoForm
            f.iForm = new InfoForm(Mode);
            f.iForm.Show();
            //Hide StartForm
            ShowPlayModeButton(false);
            Visible = false;

        }
        #endregion

        #region Event
        #region Click
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            //hide Mode button
            ModeButton.Focus();
            ShowPlayModeButton(false);
            //Show exitForm;
            Point location = new Point(Location.X + 200, Location.Y + 200);
            ExitForm eform = new ExitForm(location);
            sound.Play(sound.announce);
            eform.ShowDialog();

        }

        private void ModeButton_Click(object sender, EventArgs e)
        {
            sound.Play(sound.click);
            //Show / Hide 2 GameMode Button
            if (StartPvCButton.Visible == false)
            {
                ShowPlayModeButton(true);
                StartPvPButton.Focus();
            }
            else
                ShowPlayModeButton(false);
        }
        private void ShowPlayModeButton(bool visible)
        {
            StartPvCButton.Visible = visible;
            StartPvPButton.Visible = visible;
        } //Show or hide (visable) 2 GameMode Button

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            sound.Play(sound.click);
            ModeButton.Focus();
            ShowPlayModeButton(false);
            f.rForm = new RuleForm(Location);
            f.rForm.Show();
            Visible = false;

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            sound.Play(sound.click);
            ModeButton.Focus();
            ShowPlayModeButton(false);
            f.cForm = new CreditForm(Location);
            f.cForm.Show();
            Visible = false;
        }
        private void SettingButton_Click(object sender, EventArgs e)
        {
            sound.Play(sound.click);
            Point Location = new Point(this.Location.X + 150, this.Location.Y + 120);
            SettingForm sF = new SettingForm(Location);
            sF.ShowDialog();
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

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "Save.txt"))
            {
                string[] lines = System.IO.File.ReadAllLines(Application.StartupPath + "Save.txt");
                /*
                    0 gamemode(1:PVP, 0:PvC)
                    1 player1_name
                    2 player2_name
                    3 player1_score
                    4 player2_score
                    5 num_move
                    6 game status(is Game end ?)
                    7 player1_time(int)
                    8 player2_tine(int)
                    9 curent player(int)
                    10 player1_avatar_num(index: 0->9)
                    11 player2_avatar_num(index: 0->9)

                    12 move[1] X
                    13 move[1] Y
                    ...

                */
                bool Mode = false;
                if (lines[0] == "1") Mode = true;
                Cons.Player1_Name = lines[1];
                Cons.Player2_Name = lines[2];
                Cons.Player1_score = Int32.Parse(lines[3]);
                Cons.Player2_score = Int32.Parse(lines[4]);
                int num_move = Int32.Parse(lines[5]);
                bool status = false;
                if (lines[6] == "1") status = true;
                int player1_time = Int32.Parse(lines[7]);
                int player2_time = Int32.Parse(lines[8]);
                int cur_player = Int32.Parse(lines[9]);
                int player1_avatar_num = Int32.Parse(lines[10]);
                int player2_avatar_num = Int32.Parse(lines[11]);
                //
                List<Point> ListMove = new List<Point>();
                for (int i = 0; i < num_move; i++)
                    ListMove.Add(new Point(Int32.Parse(lines[12 + i * 2]), Int32.Parse(lines[12 + i * 2 + 1])));
                //
                sound.Play(sound.click2);
                Hide();
                //Create PLayForm and close InfoForm
                Cons.Player1_avt_IMG = Cons.Player_avt_IMG[player1_avatar_num];
                Cons.Player2_avt_IMG = Cons.Player_avt_IMG[player2_avatar_num];
                f.pForm = new PlayForm(Mode);
                f.pForm.SetUp(status, player1_time, player2_time, cur_player, ListMove);
                f.pForm.Show();
                f.pForm.Focus_Panel();
                sound.Play(sound.start);

            }
            else
            {
                String[] lines = { "1", "PLAYER 1", "PLAYER 2", "0", "0","0", "0", "0", "0","1","6","5"};
                File.WriteAllLines(Application.StartupPath + "Save.txt", lines);
                ContinueButton_Click(sender,e);
            }
        }

        
    }
}
