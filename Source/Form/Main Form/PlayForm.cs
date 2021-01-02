using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace Caro
{
    public partial class PlayForm : Form
    {
        #region Properties
        private bool mouseDown;
        private Point lastLocation;
        public BoardManager CheckBoard;
        public bool Mode; //Game Mode: true = PvP, false = PvC
        public Timer timer; //Timer tick every second
        public int Time1, Time2; // Time each player have
        #endregion

        #region Initialize
        public PlayForm(bool GameMode)
        {
            //Initialize Form Component
            InitializeComponent();
            //Set player avatars
            Player1Avatar.BackgroundImage = Cons.Player1_avt_IMG;
            Player2Avatar.BackgroundImage = Cons.Player2_avt_IMG;


            //set Player Mark
            Player1Mark.Image = Cons.Player1_icon_IMG;
            Player2Mark.Image = Cons.Player2_icon_IMG;

            //Set Player Name
            Player2NameLabel.Text = Cons.Player2_Name;
            Player1NameLabel.Text = Cons.Player1_Name;

            //Create a panel of button
            CheckBoard = new BoardManager(PlayPanel, GameMode);
            CheckBoard.ClearChessBoard();
            CheckBoard.DrawChessBoard();
            Focus_Panel();
            //Set Score
            Score.Text = Cons.Player1_score.ToString()+":"+Cons.Player2_score.ToString();
            //set CurPlayer Avatar and mark
            if (DataBoard.Get_Cur_Player() == 1)
            {
                CurPlayerMark.BackgroundImage = Cons.Player1_icon_IMG;
                CurPlayerAvatar.BackgroundImage = Player1Avatar.BackgroundImage;
            }
            else
            {
                CurPlayerMark.BackgroundImage = Cons.Player2_icon_IMG;
                CurPlayerAvatar.BackgroundImage = Player2Avatar.BackgroundImage;
            }
            //Set Game Mode
            Mode = GameMode;
            //Initialize Timer
            InitTimer();

           
        }
        
        public void SetUp(bool status, int time1, int time2,int cur_player, List<Point> List)
        {
            DataBoard.Set_isGameOver(status);
            Time1 = time1;
            Time2 = time2;
            Player1Timer.Text = FormatTime(Time1);
            Player2Timer.Text = FormatTime(Time2);
            
            if (Time1 == 0 || Time2 == 0)
            {
                timer.Enabled = false;
                Player1Timer.Text = "No Limit";
                Player2Timer.Text = "No Limit";
            }

            DataBoard.Set_Cur_Player(cur_player);
            if (List.Count % 2 == 1)
                DataBoard.changePlayer();

           
            if (!status)
            f.pForm.timer.Start();
            for (int i = 0; i < List.Count; i++)
                f.pForm.CheckBoard.ButtonMove(f.pForm.CheckBoard.btn[List[i].X,List[i].Y], false);
            //Focus in last move
            Focus_Panel();
        }
        #endregion
        #region Event
        #region Button Click
        private void NewButton_Click(object sender, EventArgs e)
        {
            Focus_Panel();
            sound.Play(sound.click);
            timer.Stop();
            CheckBoard = new BoardManager(PlayPanel, Mode);
            CheckBoard.ClearChessBoard();
            CheckBoard.DrawChessBoard();
            // Reset timer and announce current player
            InitTimer();
            timer.Stop();
            //Set Score
            Score.Text = Cons.Player1_score.ToString() + ":" + Cons.Player2_score.ToString();
            //Set new First Player and set avatar
            DataBoard.Random_Player();

            if (DataBoard.Get_Cur_Player() == 1)
            {
                CurPlayerMark.BackgroundImage = Cons.Player1_icon_IMG;
                CurPlayerAvatar.BackgroundImage = Player1Avatar.BackgroundImage;
            }
            else
            {
                CurPlayerMark.BackgroundImage = Cons.Player2_icon_IMG;
                CurPlayerAvatar.BackgroundImage = Player2Avatar.BackgroundImage;
            }
            //Annouce
            AnnounceCurPlayer();
            timer.Start();
            Focus_Panel();
            if (Mode == false && DataBoard.Get_Cur_Player() == 2 && DataBoard.isEmpty())//PvC and Bot go first
                CheckBoard.ButtonMove(CheckBoard.btn[Cons.chess_board_width / 2, Cons.chess_board_height / 2], false);

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {

            sound.Play(sound.announce);
            //stop time
            timer.Stop();
            CheckBoard.HideChessBoard(true);
            //Show exit form
            Point location = new Point(Location.X + 295, Location.Y + 200);
            ExitForm eform = new ExitForm(location);
            eform.ShowDialog();
            //unpause
            timer.Start();
            CheckBoard.HideChessBoard(false);
            Focus_Panel();

        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            sound.Play(sound.click);
            timer.Stop();
            //Close PLayForm
            Close();
            //Show StartForm
            foreach (Form frm in Application.OpenForms)
                frm.Visible = true;

        }
        private void RedoButton_Click(object sender, EventArgs e)
        {

            sound.Play(sound.click);
            CheckBoard.Redo();
            if(Mode==false) CheckBoard.Redo();
            Focus_Panel();
           
        }
        private void PauseButton_Click(object sender, EventArgs e)
        {

            sound.Play(sound.announce);
            timer.Stop();
            CheckBoard.HideChessBoard(true);
            PauseForm pauseForm = new PauseForm();
            pauseForm.ShowDialog();
            Focus_Panel();
        }
        #endregion

        #region Time
        void timer_Tick(object sender, EventArgs e)
        {

            if (DataBoard.Get_Cur_Player() == 1 && Time1 > 0)
            {
                Time1--;
                Player1Timer.Text = FormatTime(Time1);
                if (Time1 == 0) DataBoard.GameOver(2); //player2 win when player 1 time out
            }
            if (DataBoard.Get_Cur_Player() == 2 && Time2 > 0)
            {
                Time2--;
                Player2Timer.Text = FormatTime(Time2);
                if (Time2 == 0) DataBoard.GameOver(1);  //player1 win when player 2 time out
            }
            if (DataBoard.isEmpty() && Mode == false && DataBoard.Get_Cur_Player() == 2)
            {
                CheckBoard.ButtonMove(CheckBoard.btn[Cons.chess_board_width / 2, Cons.chess_board_height / 2], false);
            }
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

        protected override bool ProcessDialogKey(Keys keyData)
        {
            return false;
            //disable tab change by key
        }
        #endregion
        #endregion

        #region Method
        public void Focus_Panel()
        {
            if (!DataBoard.isEmpty())

            {//focus last move
                CheckBoard.btn[DataBoard.Get_LastMove().X, DataBoard.Get_LastMove().Y].Focus();
            }

            else
            { //focus middle
                CheckBoard.btn[Cons.chess_board_width / 2, Cons.chess_board_height / 2].Focus();
            }

        }
        public void AnnounceCurPlayer()
        {
            AnnounceForm aForm = new AnnounceForm();
            aForm.ShowDialog();
            if (Mode == false && DataBoard.Get_Cur_Player() == 2 && DataBoard.isEmpty())//PvC and Bot go first
                CheckBoard.ButtonMove(CheckBoard.btn[Cons.chess_board_width / 2, Cons.chess_board_height / 2], false);
        }
        private String FormatTime(int Time)
        {
            int num1 = 0, num2 = 0;
            if (Time > 0)
                num1 = (Time / 60); //minute
            num2 = Time - num1 * 60; //second

            String s1 = num1.ToString(); //minute to String
            if (num1 < 10) s1 = "0" + s1;

            String s2 = num2.ToString(); //second to String
            if (num2 < 10) s2 = "0" + s2;

            return s1 + ":" + s2;
        } //Format int to String (mm:ss)

        private void SaveButton_Click(object sender, EventArgs e)
        {
            sound.Play(sound.click);
            //Set string for board data
            string num_Move = DataBoard.ListMove.Count.ToString();

            //Set string for game status 
            string game_status;
            if (DataBoard.Get_GameOver())
                game_status = "1";
            else game_status = "0";
            string[] lines = new string[12 + (2 * DataBoard.ListMove.Count)];
                
            lines[0]= Mode ? "1" : "0";
            lines[1] = Cons.Player1_Name;
            lines[2] = Cons.Player2_Name;
            lines[3] = Cons.Player1_score.ToString();
            lines[4] = Cons.Player2_score.ToString();
            lines[5] = num_Move;
            lines[6] = game_status;
            lines[7] = Time1.ToString();
            lines[8] = Time2.ToString();
            lines[9] = DataBoard.Get_Cur_Player().ToString();
            lines[10] = Cons.Player1_avt_num.ToString();
            lines[11] = Cons.Player2_avt_num.ToString();
            for (int i = 0; i < DataBoard.ListMove.Count; i++)
            { 
                lines[12+i*2] = DataBoard.ListMove[i].X.ToString();
                lines[12+i*2+1] = DataBoard.ListMove[i].Y.ToString();
            }
            /*
                0 gamemode (1:PVP , 0:PvC)
                1 player1_name
                2 player2_name
                3 player1_score
                4 player2_score
                5 number of Move
                6 game status (is Game end?)
                7 player1_time (int)
                8 player2_tine (int)
                9 curent player (int)
                10 player1_avatar_num  (index : 0->9)
                11 player2_avatar_num  (index : 0->9)
                
                12 Move[1] X
                13 Move[1] Y

                15 Move[2] X
                16 Move[2] Y
                ...
            */
            System.IO.File.WriteAllLines(Application.StartupPath+"Save.txt", lines);
            
            PauseButton_Click(sender, e);
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            sound.Play(sound.click);
            Point Location = new Point(this.Location.X + 250, this.Location.Y + 200);
            SettingForm sF = new SettingForm(Location);

            //Pause
            sound.Play(sound.announce);
            timer.Stop();
            CheckBoard.HideChessBoard(true);
            //Setting
            sF.ShowDialog();
            //Unpause
            timer.Start();
            sound.Play(sound.announce);
            CheckBoard.HideChessBoard(false);
            Focus_Panel();

        }

        public void InitTimer()
        {
            Time1 = Cons.PlayTime;
            Time2 = Cons.PlayTime;
            if (Mode == false)
            {
                Time1 = 0;
                Time2 = 0;
            }
            //Show PlayTime to Label
            Player1Timer.Text = FormatTime(Time1);
            Player2Timer.Text = FormatTime(Time2);

            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000; //Tick every 1 second ( 1000 millisec)
            //Cancel timer if PlayTime=0 (No limit)
            if (Time1 == 0)
            {
                timer.Enabled = false;
                Player1Timer.Text = "No Limit";
                Player2Timer.Text = "No Limit";
            }
            else timer.Enabled = true;
        }
        #endregion


    }
}
