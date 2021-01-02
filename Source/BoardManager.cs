using System;
using System.Drawing;
using System.Windows.Forms;

namespace Caro
{
    public class BoardManager
    {
        #region Properties
        private Panel panel_chessboard;
        //2d Array of Button
        public Button[,] btn = new Button[Cons.chess_board_width, Cons.chess_board_height];
        //Type for 2 Player : true = human // false = Bot
        public  bool TypePlayer1, TypePlayer2;
        public Panel ChessBoard
        {
            get { return panel_chessboard; }
            set { panel_chessboard = value; }
        }
        #endregion

        #region Initialize
        public BoardManager(Panel panel_chessboard, bool GameMode)
        {
            ChessBoard = panel_chessboard;

            //Set DataBoard Start value
            DataBoard.New_Board();

            //Set Player Bot or Human
            TypePlayer1 = true; //Player1 alway human
            TypePlayer2 = GameMode; //Player2 set to human or bot (true/false)

        }

        #endregion

        #region Methods
        public void DrawChessBoard()
        {
            //Draw height x width Button
            for (int i = 0; i < Cons.chess_board_height; i++)
            {

                for (int j = 0; j < Cons.chess_board_width; j++)
                {
                    btn[i, j] = new Button() //create a Button
                    {
                        Width = Cons.chess_width,
                        Height = Cons.chess_height,
                        Location = new Point(i * Cons.chess_width, j * Cons.chess_height),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };
                    btn[i, j].Click += btn_Click;
                    btn[i, j].KeyDown += btn_KeyDown;
                    panel_chessboard.Controls.Add(btn[i, j]);

                }
            }
        }
        public void Refesh()
        {
            for (int i = 0; i < Cons.chess_board_height; i++)
                for (int j = 0; j < Cons.chess_board_width; j++)
            {
                    if (DataBoard.Get_Board_value(i, j) == 1) btn[i, j].BackgroundImage = Cons.Player1_icon_IMG;
                    else if (DataBoard.Get_Board_value(i, j) == 2) btn[i, j].BackgroundImage = Cons.Player2_icon_IMG;
                    else btn[i, j].BackgroundImage = null;
            }
        }
        public void HideChessBoard(bool status)
        {
            ChessBoard.Visible = !status;
        }
        public void ClearChessBoard()
        {
            panel_chessboard.Controls.Clear();
        }
        public bool ButtonMove(Button bt,bool isSetUp)
        {
            Point Move = new Point(bt.Location.X / Cons.chess_width, bt.Location.Y / Cons.chess_height);

            if (bt.BackgroundImage == null)//Check that Button have been used (No Image)
            {   //Set Image to Button
                if (DataBoard.Get_Cur_Player() == 1) //Player 1
                {
                    if(!isSetUp) sound.Play(sound.p1);
                    bt.BackgroundImage = Cons.Player1_icon_IMG;
                }
                else    //Player 2
                {
                    if (!isSetUp) sound.Play(sound.p2);
                    bt.BackgroundImage = Cons.Player2_icon_IMG;
                }
                //Set Value in DataBoard
                DataBoard.Move(Move, isSetUp);
                return true;
            }
            return false;
        } //Make a Move by a Button
        public Point Location_Update(Point last_Location, int direction)
        {
            Point cur_Location;


            switch (direction)
            {
                case 1: //up
                    {
                        cur_Location = new Point(last_Location.X, last_Location.Y - 1);
                        break;
                    }
                case 2: //down
                    {
                        cur_Location = new Point(last_Location.X, last_Location.Y + 1);
                        break;
                    }
                case 3: //left
                    {
                        cur_Location = new Point(last_Location.X - 1, last_Location.Y);
                        break;
                    }
                case 4: //right
                    {
                        cur_Location = new Point(last_Location.X + 1, last_Location.Y);
                        break;
                    }
                default: // return last location
                    {
                        cur_Location = new Point(last_Location.X, last_Location.Y);
                        break;
                    }
            }
            //Handle when cur_Location when out of range
            while (cur_Location.X < 0) cur_Location.X += Cons.chess_board_width;
            while (cur_Location.X >= Cons.chess_board_width) cur_Location.X -= Cons.chess_board_width;
            while (cur_Location.Y < 0) cur_Location.Y += Cons.chess_board_height;
            while (cur_Location.Y >= Cons.chess_board_height) cur_Location.Y -= Cons.chess_board_height;


            return cur_Location;
        }// Keyboard Control change Location
        public void Redo()
        {
            if (!DataBoard.isEmpty())
            {   //Return to Pre-Win state

                if (DataBoard.Get_GameOver())
                {
                    BackForm backForm = new BackForm();
                    backForm.ShowDialog();
                }
                else
                {
                    //Remove Mark
                    btn[DataBoard.Get_LastMove().X, DataBoard.Get_LastMove().Y].BackgroundImage = null;
                    //Remove DataBoard Value
                    DataBoard.Remove_LastMove();
                }
            }
        }

        #endregion

        #region Event
        #region Click
        void btn_Click(object sender, EventArgs e)
        {
            if (!DataBoard.Get_GameOver())
            {
                Button movebtn = sender as Button;

                if (f.pForm.Mode==true) // PvP

                    {
                        ButtonMove(movebtn, false); //Player Move //and // change Player
                    }
                if(f.pForm.Mode == false)
                {
                    bool click_res=false;
                    //Player Move
                    if(DataBoard.Get_Cur_Player()==1 )
                    click_res=ButtonMove(movebtn, false); //Player Move //and // change Player
                    //Bot move
                    if(click_res)
                    {
                        Point BotMove = AI.BotFindMove();
                        ButtonMove(btn[BotMove.X, BotMove.Y], false);
                        f.pForm.Focus_Panel();
                    }
                }
            }

        }
        #endregion
        
        #region Key
        void btn_KeyDown(object sender, KeyEventArgs e)
        {
            //Enter to click
            if (e.KeyCode == Keys.Enter) { btn_Click(sender, e); return; }

            //WASD or Arrow to move
            Button cur_btn = (Button)sender;
            Point cur_Point = new Point(cur_btn.Location.X / Cons.chess_width, cur_btn.Location.Y / Cons.chess_height);
            int direction = 0;
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up) direction = 1;
            else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down) direction = 2;
            else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left) direction = 3;
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right) direction = 4;
            if (direction > 0) //avoid lag when hit rapiply on keyboard
            {
                cur_Point = Location_Update(cur_Point, direction);
                btn[cur_Point.X, cur_Point.Y].Focus();
            }
        }

        #endregion
        #endregion

    }

}
