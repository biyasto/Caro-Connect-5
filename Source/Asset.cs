using System.Drawing;

namespace Caro
{
    public static class Cons
    {
        #region Constant
        //chiều rộng, chiều dài một ô cờ
        public const int chess_width = 25;
        public const int chess_height = 25;

        //chiều rộng, chiều dài bàn cờ
        public const int chess_board_width = 20;
        public const int chess_board_height = 20;

        // Số lượng ô thẳng hàng để Thắng
        public const int Number_toWin = 5;

        //Thời gian chơi
        public static int PlayTime = 180;

        //Các ảnh để làm avatar
        public static Image[] Player_avt_IMG = new Image[10] { Properties.Resources._1, Properties.Resources._2, Properties.Resources._3, Properties.Resources._4, Properties.Resources._5, Properties.Resources._6, Properties.Resources._7, Properties.Resources._8, Properties.Resources._9, Properties.Resources._10 };
        #endregion

        #region Static Variables
        //Tên người chơi
        public static string Player1_Name;
        public static string Player2_Name;
        //Icon Con Cờ của người chơi, player avts
        public static Image Player_icon_check_IMG;
        public static Image Player1_icon_IMG = Properties.Resources.X_icon;
        public static Image Player2_icon_IMG = Properties.Resources.O_icon;
        public static Image Player_icon_won_IMG;
        public static Image Player1_icon_won_IMG = Properties.Resources.X_icon_won;
        public static Image Player2_icon_won_IMG = Properties.Resources.O_icon_won;
        //Ảnh người chơi
        public static Image Player1_avt_IMG;
        public static Image Player2_avt_IMG;
        //Diem
        public static int Player1_score;
        public static int Player2_score;
        //Vi tri Avatar
        public static int Player1_avt_num;
        public static int Player2_avt_num;
        //Setting
        public static int[] index = { 0, 0, 0 };


        #endregion
    }
    static class f
    {
        //Asset Main Class
        public static PlayForm pForm;
        public static InfoForm iForm;
        public static RuleForm rForm;
        public static CreditForm cForm;
    }
    
}
