using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro
{
    public partial class BackForm : Form
    {
        public BackForm()
        {
            
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(f.pForm.Location.X + 270, f.pForm.Location.Y + 200);
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            DataBoard.Set_isGameOver(false);
            f.pForm.timer.Start();
            //Remove Mark
            f.pForm.CheckBoard.btn[DataBoard.Get_LastMove().X, DataBoard.Get_LastMove().Y].BackgroundImage = null;
            //Remove DataBoard Value
            DataBoard.Remove_LastMove();
            f.pForm.CheckBoard.Refesh();
            if (DataBoard.Get_Cur_Player() == 1) Cons.Player1_score--;
            else Cons.Player2_score--;
            f.pForm.Score.Text = Cons.Player1_score.ToString() + ":" + Cons.Player2_score.ToString();
            this.Close();
        }
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
