using System;
using System.Drawing;
using System.Windows.Forms;

namespace Caro
{
    public partial class DrawForm : Form
    {
        public DrawForm()
        {
            InitializeComponent();
            Player1Avatar.Image = Cons.Player1_avt_IMG;
            Player2Avatar.Image = Cons.Player2_avt_IMG;
            Player1Name.Text = Cons.Player2_Name;
            PLayer2Name.Text = Cons.Player2_Name;
            Location = new Point(f.pForm.Location.X + 200, f.pForm.Location.Y + 175);
            sound.Play(sound.tie);

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            sound.Play(sound.click2);
            Close();
        }
    }
}
