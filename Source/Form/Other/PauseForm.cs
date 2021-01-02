using System;
using System.Drawing;
using System.Windows.Forms;

namespace Caro
{
    public partial class PauseForm : Form
    {
        public PauseForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(f.pForm.Location.X + 320, f.pForm.Location.Y + 200);
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            sound.Play(sound.start);
            f.pForm.timer.Start();
            f.pForm.CheckBoard.HideChessBoard(false);

            Close();


        }
    }
}
