using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Caro
{
    class AI
    {
        public static long[]  Score_DEF = new long[6] {0, 4, 32, 256, 2048, 16384};
        public static long[]  Score_ATK = new long[6] {0, 9, 81, 729, 6561, 59049};


    static public Point BotFindMove()
        {
            return SearchRoads();
        }
        #region Hàm tìm kiếm nước đi
    static private Point SearchRoads()
        {
            Point move = new Point();

            long Score = 0;
            long extra_Score = 0;
            for (int i = 0; i < Cons.chess_board_height; i++)
            {
                for (int j = 0; j < Cons.chess_board_width; j++)
                {
                    long p_Attack = 0;
                    long p_Defend = 0;
                    if (DataBoard.Get_Board_value(i, j) == 0 && !Prunning(j, i))
                    {
                        p_Attack += attack_1(j, i);
                        p_Attack += attack_2(j, i);
                        p_Attack += attack_3(j, i);
                        p_Attack += attack_4(j, i);

                        p_Defend += defend_1(j, i);
                        p_Defend += defend_2(j, i);
                        p_Defend += defend_3(j, i);
                        p_Defend += defend_4(j, i);


                        if (p_Defend < p_Attack)
                        {
                            if (Score < p_Attack || (Score == p_Attack && extra_Score < p_Defend))
                            {
                                Score = p_Attack ;
                                extra_Score = p_Defend;
                                move = new Point(i, j);
                            }
                        }
                        else
                        {
                            if (Score < p_Defend || (Score == p_Defend && extra_Score < p_Attack))
                            {
                                Score = p_Defend;
                                extra_Score = p_Attack;
                                move = new Point(i, j);
                            }
                        }
                    }
                }
            }
            return move;
        }
        #endregion

        #region atk
        static private long attack_1(int curr_Row, int curr_Column)
        {
            long Sum = 0;
            long PointTemp = 0;
            int QuanTa = 0;
            int QuanDich = 0;
            for (int count = 1; count < 6 && curr_Row + count < Cons.chess_board_height; count++)
            {
                if (DataBoard.Get_Board_value(curr_Column, curr_Row + count) == 2)
                    QuanTa++;
                else
                    if (DataBoard.Get_Board_value(curr_Column, curr_Row + count) == 1)
                {
                    QuanDich++;
                    PointTemp -= Score_ATK[1];
                    break;
                }
                else
                    break;
            }

            for (int count = 1; count < 6 && curr_Row - count >= 0; count++)
            {
                if (DataBoard.Get_Board_value(curr_Column, curr_Row - count) == 2)
                    QuanTa++;
                else
                    if (DataBoard.Get_Board_value(curr_Column, curr_Row - count) == 1)
                {
                    QuanDich++;
                    PointTemp -= Score_ATK[1];
                    break;
                }
                else
                    break;
            }


            if (QuanDich == 2)
                return 0;
            if (QuanTa > 5)
                return 0;

            Sum += Score_ATK[QuanTa];
            Sum -= Score_ATK[QuanDich];
            PointTemp += Sum;

            return PointTemp;
        }

        static private long attack_2(int curr_Row, int curr_Column)
        {
            long Sum = 0;
            long PointTemp = 0;
            int QuanTa = 0;
            int QuanDich = 0;
            for (int count = 1; count < 6 && curr_Column + count < Cons.chess_board_width; count++)
            {
                if (DataBoard.Get_Board_value(curr_Column + count, curr_Row) == 2)
                    QuanTa++;
                else
                    if (DataBoard.Get_Board_value(curr_Column + count, curr_Row) == 1)
                {
                    QuanDich++;
                    PointTemp -= Score_ATK[1];
                    break;
                }
                else
                    break;
            }


            for (int count = 1; count < 6 && curr_Column - count >= 0; count++)
            {
                if (DataBoard.Get_Board_value(curr_Column - count, curr_Row) == 2)
                    QuanTa++;
                else
                    if (DataBoard.Get_Board_value(curr_Column - count, curr_Row) == 1)
                {
                    QuanDich++;
                    PointTemp -= Score_ATK[1];
                    break;
                }
                else
                    break;
            }


            if (QuanDich == 2)
                return 0;
            if (QuanTa > 5)
                return 0;

            Sum += Score_ATK[QuanTa];
            Sum -= Score_ATK[QuanDich];
            PointTemp += Sum;

            return PointTemp;
        }

        static private long attack_3(int curr_Row, int curr_Column)
        {
            long Sum = 0;
            long PointTemp = 0;
            int QuanTa = 0;
            int QuanDich = 0;
            for (int count = 1; count < 6 && curr_Column + count < Cons.chess_board_width && curr_Row - count >= 0; count++)
            {
                if (DataBoard.Get_Board_value(curr_Column + count, curr_Row - count) == 2)
                    QuanTa++;
                else
                    if (DataBoard.Get_Board_value(curr_Column + count, curr_Row - count) == 1)
                {
                    QuanDich++;
                    PointTemp -= Score_ATK[1];
                    break;
                }
                else
                    break;
            }


            for (int count = 1; count < 6 && curr_Column - count >= 0 && curr_Row + count < Cons.chess_board_height; count++)
            {
                if (DataBoard.Get_Board_value(curr_Column - count, curr_Row + count) == 2)
                    QuanTa++;
                else
                    if (DataBoard.Get_Board_value(curr_Column - count, curr_Row + count) == 1)
                {
                    QuanDich++;
                    PointTemp -= Score_ATK[1];
                    break;
                }
                else
                    break;
            }


            if (QuanDich == 2)
                return 0;
            if (QuanTa > 5)
                return 0;

            Sum += Score_ATK[QuanTa];
            Sum -= Score_ATK[QuanDich];
            PointTemp += Sum;

            return PointTemp;
        }

        static private long attack_4(int curr_Row, int curr_Column)
        {
            long Sum = 0;
            long PointTemp = 0;
            int QuanTa = 0;
            int QuanDich = 0;
            for (int count = 1; count < 6 && curr_Column + count < Cons.chess_board_width && curr_Row + count < Cons.chess_board_height; count++)
            {
                if (DataBoard.Get_Board_value(curr_Column + count, curr_Row + count) == 2)
                    QuanTa++;
                else
                    if (DataBoard.Get_Board_value(curr_Column + count, curr_Row + count) == 1)
                {
                    QuanDich++;
                    PointTemp -= Score_ATK[1];
                    break;
                }
                else
                    break;
            }


            for (int count = 1; count < 6 && curr_Column - count >= 0 && curr_Row - count >= 0; count++)
            {
                if (DataBoard.Get_Board_value(curr_Column - count, curr_Row - count) == 2)
                    QuanTa++;
                else
                    if (DataBoard.Get_Board_value(curr_Column - count, curr_Row - count) == 1)
                {
                    QuanDich++;
                    PointTemp -= Score_ATK[1];
                    break;
                }
                else
                    break;
            }


            if (QuanDich == 2)
                return 0;
            if (QuanTa > 5)
                return 0;

            Sum += Score_ATK[QuanTa];
            Sum -= Score_ATK[QuanDich];
            PointTemp += Sum;

            return PointTemp;
        }
        #endregion


        #region def
        static private long defend_1(int curr_Row, int curr_Column)
        {
            long Sum = 0;
            long PointTemp = 0;
            int QuanTa = 0;
            int QuanDich = 0;
            for (int count = 1; count < 6 && curr_Row + count < Cons.chess_board_height; count++)
            {
                if (DataBoard.Get_Board_value(curr_Column, curr_Row + count) == 2)
                {
                    QuanTa++;
                    break;
                }
                else
                    if (DataBoard.Get_Board_value(curr_Column, curr_Row + count) == 1)
                    QuanDich++;
                else
                    break;
            }


            for (int count = 1; count < 6 && curr_Row - count >= 0; count++)
            {
                if (DataBoard.Get_Board_value(curr_Column, curr_Row - count) == 2)
                {
                    QuanTa++;
                    break;
                }
                else
                    if (DataBoard.Get_Board_value(curr_Column, curr_Row - count) == 1)
                    QuanDich++;
                else
                    break;
            }


            if (QuanTa == 2)
                return 0;

            Sum += Score_DEF[QuanDich];
            if (QuanDich > 0)
                Sum -= Score_ATK[QuanTa];
            PointTemp += Sum;

            return PointTemp;
        }

        static private long defend_2(int curr_Row, int curr_Column)
        {
            long Sum = 0;
            long PointTemp = 0;
            int QuanTa = 0;
            int QuanDich = 0;
            for (int count = 1; count < 6 && curr_Column + count < Cons.chess_board_width; count++)
            {
                if (DataBoard.Get_Board_value(curr_Column + count, curr_Row) == 2)
                {
                    QuanTa++;
                    break;
                }
                else
                    if (DataBoard.Get_Board_value(curr_Column + count, curr_Row) == 1)
                    QuanDich++;
                else
                    break;
            }


            for (int count = 1; count < 6 && curr_Column - count >= 0; count++)
            {
                if (DataBoard.Get_Board_value(curr_Column - count, curr_Row) == 2)
                {
                    QuanTa++;
                    break;
                }
                else
                    if (DataBoard.Get_Board_value(curr_Column - count, curr_Row) == 1)
                    QuanDich++;
                else
                    break;
            }


            if (QuanTa == 2)
                return 0;

            Sum += Score_DEF[QuanDich];
            if (QuanDich > 0)
                Sum -= Score_ATK[QuanTa];
            PointTemp += Sum;


            return PointTemp;
        }


        static private long defend_3(int curr_Row, int curr_Column)
        {
            long Sum = 0;
            long PointTemp = 0;
            int QuanTa = 0;
            int QuanDich = 0;
            for (int count = 1; count < 6 && curr_Column + count < Cons.chess_board_width && curr_Row - count >= 0; count++)
            {
                if (DataBoard.Get_Board_value(curr_Column + count, curr_Row - count) == 2)
                {
                    QuanTa++;
                    break;
                }
                else
                    if (DataBoard.Get_Board_value(curr_Column + count, curr_Row - count) == 1)
                    QuanDich++;
                else
                    break;
            }


            for (int count = 1; count < 6 && curr_Column - count >= 0 && curr_Row + count < Cons.chess_board_height; count++)
            {
                if (DataBoard.Get_Board_value(curr_Column - count, curr_Row + count) == 2)
                {
                    QuanTa++;
                    break;
                }
                else
                    if (DataBoard.Get_Board_value(curr_Column - count, curr_Row + count) == 1)
                    QuanDich++;
                else
                    break;
            }


            if (QuanTa == 2)
                return 0;

            Sum += Score_DEF[QuanDich];
            if (QuanDich > 0)
                Sum -= Score_ATK[QuanTa] * 2;
            PointTemp += Sum;

            return PointTemp;
        }


        static private long defend_4(int curr_Row, int curr_Column)
        {
            long Sum = 0;
            long PointTemp = 0;
            int QuanTa = 0;
            int QuanDich = 0;
            for (int count = 1; count < 6 && curr_Column + count < Cons.chess_board_width && curr_Row + count < Cons.chess_board_height; count++)
            {
                if (DataBoard.Get_Board_value(curr_Column + count, curr_Row + count) == 2)
                {
                    QuanTa++;
                    break;

                }
                else
                    if (DataBoard.Get_Board_value(curr_Column + count, curr_Row + count) == 1)
                    QuanDich++;
                else
                    break;
            }


            for (int count = 1; count < 6 && curr_Column - count >= 0 && curr_Row - count >= 0; count++)
            {
                if (DataBoard.Get_Board_value(curr_Column - count, curr_Row - count) == 2)
                {
                    QuanTa++;
                    break;
                }
                else
                    if (DataBoard.Get_Board_value(curr_Column - count, curr_Row - count) == 1)
                    QuanDich++;
                else
                    break;
            }


            if (QuanTa == 2)
                return 0;

            Sum += Score_DEF[QuanDich];
            if (QuanDich > 0)
                Sum -= Score_ATK[QuanTa] * 2;
            PointTemp += Sum;

            return PointTemp;
        }
        #endregion


        #region Alpha - Beta Prunning
        static public bool Prunning(int curr_row, int curr_coll)
        {
            if (PrunningHorizontal(curr_row, curr_coll) && PrunningVertical(curr_row, curr_coll) && PrunningMajorDiagonal(curr_row, curr_coll) && PrunningSubDiagonal(curr_row, curr_coll))
                return true;
            return false;
        }

        static private bool PrunningHorizontal(int curr_row, int curr_coll)
        {
            // Right way check
            if (curr_coll < Cons.chess_board_width - 5)
                for (int i = 1; i <= 4; i++)
                    if (DataBoard.Get_Board_value(curr_coll + i, curr_row) != 0)
                        return false;
            // Left way check
            if (curr_coll >= 4)
                for (int i = 1; i <= 4; i++)
                    if (DataBoard.Get_Board_value(curr_coll - i, curr_row) != 0)
                        return false;
            return true;
        }

        static private bool PrunningVertical(int curr_row, int curr_coll)
        {
            // Down way check
            if (curr_row <= Cons.chess_board_height - 5)
                for (int i = 1; i <= 4; i++)
                    if (DataBoard.Get_Board_value(curr_coll, curr_row + i) != 0)
                        return false;
            // Up way check
            if (curr_row >= 4)
                for (int i = 1; i <= 4; i++)
                    if (DataBoard.Get_Board_value(curr_coll, curr_row - i) != 0)
                        return false;
            return true;
        }

        static private bool PrunningMajorDiagonal(int curr_row, int curr_coll)
        {
            // Up to down way check
            if (curr_row <= Cons.chess_board_height - 5 && curr_coll >= 4)
                for (int i = 1; i <= 4; i++)
                    if (DataBoard.Get_Board_value(curr_coll - i, curr_row + i) != 0)
                        return false;
            // Down to up way check
            if (curr_coll <= Cons.chess_board_width - 5 && curr_row >= 4)
                for (int i = 1; i <= 4; i++)
                    if (DataBoard.Get_Board_value(curr_coll + i, curr_row - i) != 0)
                        return false;
            return true;
        }

        static private bool PrunningSubDiagonal(int curr_row, int curr_coll)
        {
            // Up to down way check
            if (curr_row <= Cons.chess_board_height - 5 && curr_coll <= Cons.chess_board_width - 5)
                for (int i = 1; i <= 4; i++)
                    if (DataBoard.Get_Board_value(curr_coll + i, curr_row + i) != 0)
                        return false;
            // Down to up way check
            if (curr_coll >= 4 && curr_row >= 4)
                for (int i = 1; i <= 4; i++)
                    if (DataBoard.Get_Board_value(curr_coll - i, curr_row - i) != 0)
                        return false;
            return true;
        }

        #endregion

    }
}

