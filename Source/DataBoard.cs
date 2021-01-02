using Caro;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
static public class DataBoard
{
    #region Properties
    static bool isGameOver;
    static private int[,] Board_value; // 0 = null , 1 = player1 , 2 = player2
    static private int Cur_Player = 0; //Current Player number
    static public List<Point> ListMove = new List<Point>(); // List of Move , use to Remove a Move
    static public readonly Point[] VectorCheck = new Point[4] { new Point { X = 1, Y = 0 }, new Point { X = 0, Y = 1 }, new Point { X = 1, Y = -1 }, new Point { X = 1, Y = 1 } };
//to check pieces value in a line ( - , | , \, /)

    #endregion

    #region Initialize
    static public void New_Board()
    {
        isGameOver = false;
        Random_Player(); // random 1 or 2 // random to find who "Move first"
       
        Board_value = new int[Cons.chess_board_width, Cons.chess_board_height];
        //set empty DataBoard value
        Clear_Board();

    } //Init
    static private void Clear_Board()
    {
        //set all  Board_value to 0 // remove all pieces
        for (int j = 0; j < Cons.chess_board_width; j++) //Y
        {
            for (int i = 0; i < Cons.chess_board_height; i++) //X
            {
                Board_value[j, i] = 0;
            }
        }
        //Clear all Move in List
        ListMove.Clear();
    }
    #endregion

    #region Method
    #region Get
    static public int Get_Cur_Player()
    {
        return Cur_Player;
    }
    static public bool Get_GameOver()
    {
        return isGameOver;
    }
    static public int Get_Board_value(int X, int Y)
    {
        //note: Y before X
        return Board_value[Y, X];
    }
    static public int Get_Board_value(Point p)
    {
        return Get_Board_value(p.X, p.Y);

    }
    static public Point Get_LastMove()
    {
        return ListMove.Last();
    }
    static public bool isEmpty()
    {
        if (ListMove.Count > 0) return false;
        return true;
    }
    #endregion
    #region Set
    static public void Set_isGameOver(bool b)
    {
        isGameOver = b;
    }
    static public void Set_Cur_Player(int player)
    {
        Cur_Player = player;
    }
    #endregion
    #region Move

    static public void Move(Point cur_Move,bool isSetup)
    {
        int player = Cur_Player;
        Board_value[cur_Move.Y, cur_Move.X] = player;
        ListMove.Add(cur_Move);
         // dont check if it is Set Up
        {
            //Game Over : @player is winner
            if (!isGameOver && Check(Board_value, cur_Move, player, Cons.Number_toWin))
            {
                GameOver(Cur_Player == 1 ? 1 : 2);
            }
            //Game Over : Tie // 

            if (!isGameOver && ListMove.Count >= Cons.chess_board_height * Cons.chess_board_width)
            {
                GameOver(0);
                return;
            }
        }
        changePlayer();


    }
    static public void GameOver(int player)
    {
        f.pForm.timer.Stop();
        isGameOver = true;
        if (player == 0)//tie
        {
            DrawForm dForm = new DrawForm();
            dForm.ShowDialog();
            //Set Score
            Cons.Player1_score++;
            Cons.Player2_score++;
        }
        else  //player win
        {
            WinForm wForm = new WinForm(player);
            wForm.ShowDialog();
            if(player == 1)
            {
                Cons.Player_icon_check_IMG = Cons.Player1_icon_IMG;
                Cons.Player_icon_won_IMG = Cons.Player1_icon_won_IMG;
                HighlightVictory();
                Cons.Player1_score++;
            }
            else
            {
                Cons.Player_icon_check_IMG = Cons.Player2_icon_IMG;
                Cons.Player_icon_won_IMG = Cons.Player2_icon_won_IMG;
                HighlightVictory();
                Cons.Player2_score++;
            }
        }
        f.pForm.Score.Text = Cons.Player1_score.ToString() + ":" + Cons.Player2_score.ToString();
    }

    #region Hightlight victory
    static bool HighlightVictory()
    {
        bool HighlightVictoryHorizontal()
        {
            Point last = Get_LastMove();
            Point lastfirst = last;
            Point lastcheck = last;
            Point lastfirstcheck = lastfirst;
            int countleft = -1;
            int countright = -1;
            // Horizontal left check
            while (f.pForm.CheckBoard.btn[lastcheck.X, lastcheck.Y].BackgroundImage == Cons.Player_icon_check_IMG)
            {
                lastcheck.X -= 1;
                countleft++;
            }
            // Horizontal right check
            while (f.pForm.CheckBoard.btn[lastfirstcheck.X, lastfirstcheck.Y].BackgroundImage == Cons.Player_icon_check_IMG)
            {
                lastfirstcheck.X += 1;
                countright++;
            }
            if (countleft + countright == 4)
            {
                // Horizontal left change
                while (f.pForm.CheckBoard.btn[last.X, last.Y].BackgroundImage == Cons.Player_icon_check_IMG)
                {
                    f.pForm.CheckBoard.btn[last.X, last.Y].BackgroundImage = Cons.Player_icon_won_IMG;
                    last.X -= 1;
                }
                lastfirst.X += 1;
                // Horizontal right change
                while (f.pForm.CheckBoard.btn[lastfirst.X, lastfirst.Y].BackgroundImage == Cons.Player_icon_check_IMG)
                {
                    f.pForm.CheckBoard.btn[lastfirst.X, lastfirst.Y].BackgroundImage = Cons.Player_icon_won_IMG;
                    lastfirst.X += 1;
                }
                return true;
            }
            else return false;
        }

        bool HighlightVictoryVertical()
        {
            Point last = Get_LastMove();
            Point lastfirst = last;
            Point lastcheck = last;
            Point lastfirstcheck = lastfirst;
            int countdown = -1;
            int countup = -1;
            // Vertical down check
            while (f.pForm.CheckBoard.btn[lastcheck.X, lastcheck.Y].BackgroundImage == Cons.Player_icon_check_IMG)
            {
                lastcheck.Y -= 1;
                countdown++;
            }
            // Vertical up check
            while (f.pForm.CheckBoard.btn[lastfirstcheck.X, lastfirstcheck.Y].BackgroundImage == Cons.Player_icon_check_IMG)
            {
                lastfirstcheck.Y += 1;
                countup++;
            }
            if (countdown + countup == 4)
            {
                // Vertical down change
                while (f.pForm.CheckBoard.btn[last.X, last.Y].BackgroundImage == Cons.Player_icon_check_IMG)
                {
                    f.pForm.CheckBoard.btn[last.X, last.Y].BackgroundImage = Cons.Player_icon_won_IMG;
                    last.Y -= 1;
                }
                lastfirst.Y += 1;
                // Vertical up change
                while (f.pForm.CheckBoard.btn[lastfirst.X, lastfirst.Y].BackgroundImage == Cons.Player_icon_check_IMG)
                {
                    f.pForm.CheckBoard.btn[lastfirst.X, lastfirst.Y].BackgroundImage = Cons.Player_icon_won_IMG;
                    lastfirst.Y += 1;
                }
                return true;
            }
            else return false;
        }

        bool HighlightVictoryMajorDiagonal()
        {
            Point last = Get_LastMove();
            Point lastfirst = last;
            Point lastcheck = last;
            Point lastfirstcheck = lastfirst;
            int countdown = -1;
            int countup = -1;
            // Major Diagonal up to down check
            while (f.pForm.CheckBoard.btn[lastcheck.X, lastcheck.Y].BackgroundImage == Cons.Player_icon_check_IMG)
            {
                lastcheck.Y += 1;
                lastcheck.X -= 1;
                countdown++;
            }
            // Major Diagonal down to up check
            while (f.pForm.CheckBoard.btn[lastfirstcheck.X, lastfirstcheck.Y].BackgroundImage == Cons.Player_icon_check_IMG)
            {
                lastfirstcheck.Y -= 1;
                lastfirstcheck.X += 1;
                countup++;
            }
            if (countdown + countup == 4)
            {
                // Major Diagonal up to down change
                while (f.pForm.CheckBoard.btn[last.X, last.Y].BackgroundImage == Cons.Player_icon_check_IMG)
                {
                    f.pForm.CheckBoard.btn[last.X, last.Y].BackgroundImage = Cons.Player_icon_won_IMG;
                    last.Y += 1;
                    last.X -= 1;
                }
                lastfirst.Y -= 1;
                lastfirst.X += 1;
                // Major Diagonal down to up change
                while (f.pForm.CheckBoard.btn[lastfirst.X, lastfirst.Y].BackgroundImage == Cons.Player_icon_check_IMG)
                {
                    f.pForm.CheckBoard.btn[lastfirst.X, lastfirst.Y].BackgroundImage = Cons.Player_icon_won_IMG;
                    lastfirst.Y -= 1;
                    lastfirst.X += 1;
                }
                return true;
            }
            else return false;
        }

        bool HighlightVictorySubDiagonal()
        {
            Point last = Get_LastMove();
            Point lastfirst = last;
            Point lastcheck = last;
            Point lastfirstcheck = lastfirst;
            int countdown = -1;
            int countup = -1;
            // Sub Diagonal up to down check
            while (f.pForm.CheckBoard.btn[lastcheck.X, lastcheck.Y].BackgroundImage == Cons.Player_icon_check_IMG)
            {
                lastcheck.Y += 1;
                lastcheck.X += 1;
                countdown++;
            }
            // Sub Diagonal down to up check
            while (f.pForm.CheckBoard.btn[lastfirstcheck.X, lastfirstcheck.Y].BackgroundImage == Cons.Player_icon_check_IMG)
            {
                lastfirstcheck.Y -= 1;
                lastfirstcheck.X -= 1;
                countup++;
            }
            if (countdown + countup == 4)
            {
                // Sub Diagonal up to down change
                while (f.pForm.CheckBoard.btn[last.X, last.Y].BackgroundImage == Cons.Player_icon_check_IMG)
                {
                    f.pForm.CheckBoard.btn[last.X, last.Y].BackgroundImage = Cons.Player_icon_won_IMG;
                    last.Y += 1;
                    last.X += 1;
                }
                lastfirst.Y -= 1;
                lastfirst.X -= 1;
                // Sub Diagonal down to up change
                while (f.pForm.CheckBoard.btn[lastfirst.X, lastfirst.Y].BackgroundImage == Cons.Player_icon_check_IMG)
                {
                    f.pForm.CheckBoard.btn[lastfirst.X, lastfirst.Y].BackgroundImage = Cons.Player_icon_won_IMG;
                    lastfirst.Y -= 1;
                    lastfirst.X -= 1;
                }
                return true;
            }
            else return false;
        }
        return (HighlightVictoryHorizontal() || HighlightVictoryVertical() || HighlightVictoryMajorDiagonal() || HighlightVictorySubDiagonal());
    }
    #endregion

    static public void Move(int x, int y)
    {
        Move(new Point(x, y),true);
    }

    static public void Remove_LastMove() //undo previous Player move
    {
        Point cur_Move = ListMove.Last();
        Board_value[cur_Move.Y, cur_Move.X] = 0;
        changePlayer();
        ListMove.RemoveAt(ListMove.Count - 1);
    }
    static public void changePlayer()
    {
        if (Cur_Player == 1)
        {
            Cur_Player = 2;
            f.pForm.CurPlayerAvatar.BackgroundImage = Cons.Player2_avt_IMG;
            f.pForm.CurPlayerMark.BackgroundImage = Cons.Player2_icon_IMG;


        }//switch to Player2
        else
        {
            Cur_Player = 1;
            f.pForm.CurPlayerAvatar.BackgroundImage = Cons.Player1_avt_IMG;
            f.pForm.CurPlayerMark.BackgroundImage = Cons.Player1_icon_IMG;


        }//switch to Player1
        return;
    }
    #endregion
    #region Check
    static public bool Check(int[,] Board_data,Point cur_Move, int player, int num)
    {
        int MaxCheck = 0;
        for (int i = 0; i < 4; i++) //Find the most "Pieces in a row"
        {
            int tmp=0;//use to check blocked
            int Check = Check_Vector(Board_data,cur_Move, VectorCheck[i], player,ref tmp);
            if (Check > MaxCheck)
                MaxCheck = Check;
        }

        // debug
        //Console.WriteLine(MaxCheck);

        return (MaxCheck == num);
    }//Find the most "Pieces in a row" of 4 line
    static public int Check_Vector(int[,] Board_data, Point cur_Move, Point VectorCheck, int player,ref int blocked)
    {   //VectorCheck is Vector of the row
        int count = 1;
        blocked = 0;
        //check exception
        if (Board_data[cur_Move.Y, cur_Move.X] != player) return 0;
        //count "Pieces in a row" by this player by direction of Vector
        count += CountPieces(Board_data,cur_Move, VectorCheck, player, 1, ref blocked);

        //count "Pieces in a row" by this player by oppisite direction of Vector
        count += CountPieces(Board_data,cur_Move, VectorCheck, player, -1, ref blocked);
        if (blocked == 2) return 0;
        return count;
    }// Count "Pieces in a row" in a line
    public static int CountPieces(int[,] Board_data,Point Last_Move, Point VectorCheck, int player, int i,ref int blocked)
    {
        Point cur_Move = new Point(Last_Move.X + i * VectorCheck.X, Last_Move.Y + i * VectorCheck.Y);
        //out of range, blocked by wall
        if (cur_Move.X < 0 || cur_Move.X >= Cons.chess_board_width || cur_Move.Y < 0 || cur_Move.Y >= Cons.chess_board_height)
            {
                blocked++;
                return 0; 
            }
        
        if (Board_data[cur_Move.Y, cur_Move.X] == player) //if next value is same as player
            return 1 + CountPieces(Board_data, cur_Move, VectorCheck, player, i, ref blocked);
        else //next value diffent from player
            {
                if (Board_data[cur_Move.Y, cur_Move.X] != 0) //Check if next value is other player
                        blocked++;
                 return 0; 
              }
    }// Count  "Pieces in a row" in a direction of a line

    #endregion
    static public void Random_Player()
    {
        Random rnd = new Random();
        Cur_Player = rnd.Next(1, 3);
    }

    #endregion
}
